import java.util.ArrayList;

public class App {
    public static void main(String[] args) {
        System.out.println("Welcome to PetSmart!");

        // Create DAO
        PetStoreDataAccessObject DAO = new PetStoreDataAccessObject();

        // Fetch Pets
        ArrayList<Pet> pets = DAO.getAllPets();
        System.out.println("----- Show All Pets ------");
        for (Pet pet : pets) {
            System.out.println(pet);
        }

        // Fetch Pets by ID = 1
        pets = DAO.getByID(1);
        System.out.println("------ Show By Pet ID ------");
        for (Pet pet : pets) {
            System.out.println(pet);
        }

        // Fetch Pets With 'e'
        pets = DAO.searchForMany("e");
        System.out.println("----- Show Contain 'e' ------");
        for (Pet pet : pets) {
            System.out.println(pet);
        }

        // Add new Pet
        Pet pet = new Pet();
        pet.setID(3);
        pet.setName("Billy the Cat");
        pet.setDesc("likes to purr");
        pet.setPrice(499.99);
        pet.setCatID(1);
        int updates = DAO.addOne(pet);
        pets = DAO.getAllPets();
        System.out.println("------ Insert New Pet ------");
        for (Pet p : pets) {
            System.out.println(p);
        }

        // Update Pet
        Pet p = new Pet();
        p.setID(3);
        p.setName("Fido the Dog");
        p.setDesc("yes");
        p.setPrice(99.99);
        p.setCatID(1);
        updates = DAO.updateOne(p);
        pets = DAO.getAllPets();
        System.out.println("----- Update Pet -------");
        for (Pet pett : pets) {
            System.out.println(pett);
        }

        // Delete Pet
        p = new Pet();
        p.setID(3);
        updates = DAO.deleteOne(p);
        pets = DAO.getAllPets();
        System.out.println("------ Delete Pet ------");
        for (Pet pe : pets) {
            System.out.println(pe);
        }
    }
}
