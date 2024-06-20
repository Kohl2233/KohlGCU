import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class PetStoreDataAccessObject {
    // Connection Vars
    static final String DATABASE_URL = "";
    static final String USERNAME = "root";
    static final String PASSWORD = "root";

    public ArrayList<Pet> getAllPets() {
        ArrayList<Pet> results = new ArrayList<Pet>();
        try {
            // Setup Connection
            Connection connection = DriverManager.getConnection(DATABASE_URL, USERNAME, PASSWORD);
            
            // Setup Statement and Execute
            Statement statement = connection.createStatement();
            ResultSet resultSet = statement.executeQuery("SELECT ID, NAME, PRICE, DESCRIPTION, PET_CATEGORIES_ID FROM PETS");
            
            // Results
            while(resultSet.next()) {
                Pet pet = new Pet();
                pet.setID(resultSet.getInt("ID"));
                pet.setName(resultSet.getString("NAME"));
                pet.setPrice(resultSet.getDouble("PRICE"));
                pet.setDesc(resultSet.getString("DESCRIPTION"));
                pet.setCatID(resultSet.getInt("PET_CATEGORIES_ID"));
                results.add(pet);
            }
        } catch (SQLException err) {
            System.out.println(err.getMessage());
        }
        return results;
    }

    public ArrayList<Pet> getByID(int id) {
        ArrayList<Pet> results = new ArrayList<Pet>();
        try {
            // Setup Connection
            Connection connection = DriverManager.getConnection(DATABASE_URL, USERNAME, PASSWORD);
            
            // Setup Statement and Execute
            String sqlString = "SELECT ID, NAME, PRICE, DESCRIPTION, PET_CATEGORIES_ID FROM PETS WHERE ID = ?";
            PreparedStatement statement = connection.prepareStatement(sqlString);
            statement.setInt(1, id);
            ResultSet resultSet = statement.executeQuery();
            
            // Results
            while(resultSet.next()) {
                Pet pet = new Pet();
                pet.setID(resultSet.getInt("ID"));
                pet.setName(resultSet.getString("NAME"));
                pet.setPrice(resultSet.getDouble("PRICE"));
                pet.setDesc(resultSet.getString("DESCRIPTION"));
                pet.setCatID(resultSet.getInt("PET_CATEGORIES_ID"));
                results.add(pet);
            }
        } catch (SQLException err) {
            System.out.println(err.getMessage());
        }
        return results;
    }

    public ArrayList<Pet> searchForMany(String searchTerm) {
        ArrayList<Pet> results = new ArrayList<Pet>();
        try {
            // Setup Connection
            Connection connection = DriverManager.getConnection(DATABASE_URL, USERNAME, PASSWORD);
            
            // Setup Statement and Execute
            String sqlString = "SELECT ID, NAME, PRICE, DESCRIPTION, PET_CATEGORIES_ID FROM PETS WHERE NAME LIKE ?";
            PreparedStatement statement = connection.prepareStatement(sqlString);
            statement.setString(1, searchTerm);
            ResultSet resultSet = statement.executeQuery();
            
            // Results
            while(resultSet.next()) {
                Pet pet = new Pet();
                pet.setID(resultSet.getInt("ID"));
                pet.setName(resultSet.getString("NAME"));
                pet.setPrice(resultSet.getDouble("PRICE"));
                pet.setDesc(resultSet.getString("DESCRIPTION"));
                pet.setCatID(resultSet.getInt("PET_CATEGORIES_ID"));
                results.add(pet);
            }
        } catch (SQLException err) {
            System.out.println(err.getMessage());
        }
        return results;
    }

    public int addOne(Pet pet) {
        try {
            Connection connection = DriverManager.getConnection(DATABASE_URL, USERNAME, PASSWORD);

            connection.createStatement();
            String sqlString = "INSERT INTO PETS (ID, NAME, DESCRIPTION, PRICE, PET_CATEGORIES_ID) "
            + "VALUES(?, ?, ?, ?, ?)";
            PreparedStatement statement = connection.prepareStatement(sqlString);
            statement.setInt(1, pet.getId());
            statement.setString(2, pet.getName());
            statement.setString(3, pet.getDescription());
            statement.setDouble(4, pet.getPrice());
            statement.setInt(5, pet.getCatID());

            int updates = statement.executeUpdate();
            return updates;
        } catch (SQLException err) {
            System.out.println(err.getMessage());
        }
        return 0;
    }

    public int updateOne(Pet pet) {
        try {
            Connection connection = DriverManager.getConnection(DATABASE_URL, USERNAME, PASSWORD);

            connection.createStatement();
            String sqlString = "UPDATE PETS SET NAME = ?, DESCRIPTION = ?, PRICE = ?, PET_CATEGORIES_ID = ? WHERE ID = ?";
            PreparedStatement statement = connection.prepareStatement(sqlString);
            statement.setString(1, pet.getName());
            statement.setString(2, pet.getDescription());
            statement.setDouble(3, pet.getPrice());
            statement.setInt(4, pet.getCatID());
            statement.setInt(5, pet.getId());

            int updates = statement.executeUpdate();
            return updates;
        } catch (SQLException err) {
            System.out.println(err.getMessage());
        }
        return 0;
    }

    public int deleteOne(Pet pet) {
        try {
            Connection connection = DriverManager.getConnection(DATABASE_URL, USERNAME, PASSWORD);

            connection.createStatement();
            String sqlString = "DELETE FROM PETS WHERE ID = ?";
            PreparedStatement statement = connection.prepareStatement(sqlString);
            statement.setInt(1, pet.getId());
            int deletes = statement.executeUpdate();
            return deletes;
        } catch (SQLException err) {
            System.out.println(err.getMessage());
        }
        return 0;
    }
}
