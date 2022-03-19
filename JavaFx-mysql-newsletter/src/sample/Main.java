package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;


public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception {
        Parent register = FXMLLoader.load(getClass().getResource("userNewsletter.fxml"));
        primaryStage.setTitle("Newsletter");
        primaryStage.setScene(new Scene(register, 600, 400));
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
