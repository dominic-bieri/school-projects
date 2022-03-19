package sample;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.control.*;
import javafx.scene.Scene;
import javafx.stage.Stage;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;


public class Controller {
    @FXML
    private TextField txtEmail;
    @FXML
    private TextField txtName;
    @FXML
    private TableView tbvEntrys;

    public static boolean IsEmailValid(String email){
        String regex = "^[\\w-_\\.+]*[\\w-_\\.]\\@([\\w]+\\.)+[\\w]+[\\w]$"; // https://www.tutorialspoint.com/validate-email-address-in-java
        return email.matches(regex);
    }

    private void InsertEmail(){
        try{
            Connection DbConnection = SQLConnection.getDBConnection();
            Statement stmt = DbConnection.createStatement();
            String email = txtEmail.getText();
            String name = txtName.getText();
            stmt.executeUpdate("INSERT INTO usernewsletter (email, userName) VALUES ('"+email+"','"+name+"')");
        }catch (Exception e){
            System.out.println(e);
        }
    }

    private ResultSet CheckIfEmailExists(){
        try{
            Connection DbConnection = SQLConnection.getDBConnection();
            Statement stmt = DbConnection.createStatement();
            String email = txtEmail.getText();
            ResultSet result = stmt.executeQuery("SELECT * FROM usernewsletter WHERE email ='" + email + "'");
            return result;
        }catch (Exception e){
            System.out.println(e);
        }
        return null;
    }
    @FXML
    private void OnSubscribe(ActionEvent event){

        if(txtEmail.getText().isEmpty()){
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Input");
            alert.setContentText("Please enter your Email!");
            alert.setHeaderText("Input Alert");
            alert.showAndWait();
        }
        else{
            try {
                if(IsEmailValid(txtEmail.getText())){
                    if(!CheckIfEmailExists().next()){
                        InsertEmail();
                    }
                    else {
                        Alert alert = new Alert(Alert.AlertType.INFORMATION);
                        alert.setTitle("Input");
                        alert.setContentText("Email already exists");
                        alert.setHeaderText("Input Alert");
                        alert.showAndWait();
                    }
                }
                else{
                    Alert alert = new Alert(Alert.AlertType.WARNING);
                    alert.setTitle("Input");
                    alert.setContentText("Please enter a valid email address");
                    alert.setHeaderText("Input Alert");
                    alert.showAndWait();
                }

            } catch (Exception e) {
                System.out.println(e);
            }
        }
    }

    private void TableViewSelect(){
        try{
            Connection DbConnection = SQLConnection.getDBConnection();
            Statement statement = DbConnection.createStatement();
            ResultSet result = statement.executeQuery("SELECT email, userName FROM usernewsletter");
            TableView tableView = tbvEntrys;
            while (result.next()){
                tableView.getColumns().add(result);
            }
        }catch (Exception e) {
            System.out.println(e);
        }
    }

    @FXML
    private void OnAdminView(ActionEvent event){
        try{
            FXMLLoader loader = new FXMLLoader(getClass().getResource("adminNewsletter.fxml"));
            Parent root = (Parent) loader.load();
            Stage stage = new Stage();

            stage.setTitle("Admin View");
            stage.setScene(new Scene(root));
            stage.show();

            TableViewSelect();
        }catch (Exception e){
            System.out.println(e);
        }
    }
}
