using CarClassLibrary;
namespace CarShopConsoleApp
{
    internal class Program
    {
        static Store CarStore = new Store();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Store!");
            int action = chooseAction();
            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        // Choose Add Car
                        Console.Out.WriteLine("You chose to add a new car to store.");

                        // Get Three Prop Details
                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;
                        String carColor = "";
                        int carYear = 0;

                        try
                        {
                            Console.Out.WriteLine("What is the make? Ford, GM, Toyota, etc ");
                            carMake = Console.ReadLine();

                            Console.Out.WriteLine("What is the model? Corvette, Focus, Ranger, etc ");
                            carModel = Console.ReadLine();

                            Console.Out.WriteLine("What is the price? Only numbers please ");
                            carPrice = int.Parse(Console.ReadLine());

                            Console.Out.WriteLine("What is the color? ");
                            carColor = Console.ReadLine();

                            Console.Out.WriteLine("What is the year? ");
                            carYear = int.Parse(Console.ReadLine());

                            // Create New Car Object
                            Car newCar = new Car();
                            newCar.Make = carMake;
                            newCar.Model = carModel;
                            newCar.Price = carPrice;
                            newCar.Color = carColor;
                            newCar.Year = carYear;
                            CarStore.CarsList.Add(newCar);
                            printStoreInventory(CarStore);
                        } catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        // Buy Car
                        printStoreInventory(CarStore);
                        int choice = 0;
                        Console.Out.WriteLine("Which car to add to cart? (number) ");
                        choice = int.Parse(Console.ReadLine());
                        CarStore.ShoppingList.Add(CarStore.CarsList[choice]);
                        printShoppingCart(CarStore);
                        break;
                    case 3:
                        // Checkout
                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Grand Total: ${0}", CarStore.checkout());
                        break;
                    default:
                        break;
                }
                action = chooseAction();
            }
        }

        static public void printStoreInventory(Store carStore)
        {
            Console.Out.WriteLine("These are the Cars in Inventory:");
            int i = 0;
            foreach (var c in carStore.CarsList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1}", i, c.Display));
                i++;
            }
        }

        static public void printShoppingCart(Store carStore)
        {
            Console.Out.WriteLine("These are the Cars in Shoppin Cart: ");
            int i = 0;
            foreach (var c in carStore.ShoppingList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1}", i, c.Display));
                i++;
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.Out.Write("Choose an action (0) Quit (1) add car (2) add item to cart (3) checkout ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}