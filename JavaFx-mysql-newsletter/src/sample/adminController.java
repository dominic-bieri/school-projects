package sample;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.MapValueFactory;

import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.Map;

public class adminController {
    @FXML
    private TableView tbvUser;

    public void initialize() throws SQLException {
        Connection DbConnection = SQLConnection.getDBConnection();
        ResultSet result = DbConnection.createStatement().executeQuery("SELECT email, userName FROM usernewsletter");

        TableColumn<Map, String> email = new TableColumn<Map, String>("Email");
        email.setCellValueFactory(new MapValueFactory<>("Email"));
        TableColumn<Map, String> name = new TableColumn<Map, String>("Name");
        name.setCellValueFactory(new MapValueFactory<>("Name"));

        tbvUser.getColumns().add(email);
        tbvUser.getColumns().add(name);

        ObservableList<Map<String, Object>> items = FXCollections.<Map<String, Object>>observableArrayList();

        while (result.next()) {
            Map<String, Object> entry = new HashMap<>();
            entry.put("Email", result.getString(1));
            entry.put("Name", result.getString(2));

            items.add(entry);
        }
        tbvUser.getItems().addAll(items);
    }
}
