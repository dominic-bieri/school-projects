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
import java.sql.SQLException;
import java.sql.Statement;


public class userController {
    @FXML
    private TextField txtEmail;
    @FXML
    private TextField txtName;

    public static boolean IsEmailValid(String email) {
        String regex = "^[\\w-_.+]*[\\w-_.]@([\\w]+\\.)+[\\w]+[\\w]$"; // https://www.tutorialspoint.com/validate-email-address-in-java
        return email.matches(regex);
    }

    private void InsertEmail() throws SQLException {
        Connection DbConnection = SQLConnection.getDBConnection();
        Statement stmt = DbConnection.createStatement();
        stmt.executeUpdate("INSERT INTO usernewsletter (email, userName) VALUES ('" + txtEmail.getText() + "','" + txtName.getText() + "')");
        Alert alert = new Alert(Alert.AlertType.CONFIRMATION);
        alert.setTitle("Successful");
        alert.setContentText("Email is successful registered");
        alert.setHeaderText("Successful Registration");
        alert.showAndWait();
    }

    private ResultSet CheckIfEmailExists() {
        try {
            Connection DbConnection = SQLConnection.getDBConnection();
            Statement stmt = DbConnection.createStatement();
            ResultSet result = stmt.executeQuery("SELECT * FROM usernewsletter WHERE email ='" + txtEmail.getText() + "'");
            return result;
        } catch (Exception e) {
            System.out.println(e);
        }
        return null;
    }

    @FXML
    private void OnSubscribe(ActionEvent event) throws SQLException {

        if (txtEmail.getText().isEmpty()) {
            Alert alert = new Alert(Alert.AlertType.ERROR);
            alert.setTitle("Input");
            alert.setContentText("Please enter your Email!");
            alert.setHeaderText("Input Alert");
            alert.showAndWait();
        } else {
            if (IsEmailValid(txtEmail.getText())) {
                if (!CheckIfEmailExists().next()) {
                    InsertEmail();
                } else {
                    Alert alert = new Alert(Alert.AlertType.INFORMATION);
                    alert.setTitle("Input");
                    alert.setContentText("Email already exists");
                    alert.setHeaderText("Input Alert");
                    alert.showAndWait();
                }
            } else {
                Alert alert = new Alert(Alert.AlertType.WARNING);
                alert.setTitle("Input");
                alert.setContentText("Please enter a valid email address");
                alert.setHeaderText("Input Alert");
                alert.showAndWait();
            }

        }
    }

    @FXML
    private void OnAdminView(ActionEvent event) {
        try {
            FXMLLoader loader = new FXMLLoader(getClass().getResource("adminNewsletter.fxml"));
            Parent root = loader.load();

            Stage stage = new Stage();
            stage.setScene(new Scene(root, 600, 400));
            stage.setTitle("Admin View");
            stage.show();

        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
