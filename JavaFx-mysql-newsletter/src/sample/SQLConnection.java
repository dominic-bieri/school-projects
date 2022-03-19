package sample;

import java.sql.Connection;
import java.sql.DriverManager;

public class SQLConnection {
    private static Connection DBConnection = null;

    private SQLConnection() {
    }

    public static Connection getDBConnection() {
        if (DBConnection == null) {
            try {
                Class.forName("com.mysql.cj.jdbc.Driver");
                Connection connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/IPT5_Newsletter_Dominic_Bieri", "root", "");
                DBConnection = connection;
            } catch (Exception e) {
                System.out.println(e);
            }
        }
        System.out.println("Connection successful");
        return DBConnection;
    }
}
