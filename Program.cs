using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {

        MenuOption userSelection;
        Stock1 test = new Stock1(" Available stock item", 100); // Creating stock object for the item and setting the initial stock item to 100
       

        

        do
        {
             userSelection = ReadUserOption();

             // perform the switch operations to perform the special operations
             switch(userSelection)
            {
                case MenuOption.BuyStock:
                Console.WriteLine(" ");
                PerformBuyStock1(test);       // perform the buy stock
                Console.WriteLine(" ");
                break;

                case MenuOption.SellStock:
                Console.WriteLine(" ");
                PerformSellStock1(test);     // perform the sell stock
                Console.WriteLine(" ");
                break;

                case MenuOption.QueryStock:
                Console.WriteLine(" ");
                PerformQueryStock1(test);  // It display the available stock
                Console.WriteLine(" ");
                break;

                case MenuOption.Quit:
                Console.WriteLine(" ");
                Console.WriteLine("Quit ... ");
                Console.WriteLine(" ");
                break;
            }
        }while (userSelection != MenuOption.Quit);
                Console.WriteLine(userSelection);
    }

    private static void PerformBuyStock1(Stock1 stock)  // buy stock function
    {
        int addStockAmount;
        Console.WriteLine("Enter amount of new stock");
        addStockAmount = Convert.ToInt32(Console.ReadLine());
        if(stock.AddStock1(addStockAmount))                          // performing the boolian function to check whether the stock added is successful or not
        {
            Console.WriteLine(" " +addStockAmount + " New stock added");
        }
        else
        {
            Console.WriteLine(" Stock cant be negative, Hence it is failed");
        }
    }

     private static void PerformSellStock1(Stock1 stock)          // sell stock function
    {
        int sellStockAmount;
        Console.WriteLine("Enter the stock amount need to sell");
        sellStockAmount = Convert.ToInt32(Console.ReadLine());
        if(stock.RemoveStock1(sellStockAmount))
        {
            Console.WriteLine(" " +sellStockAmount + " stock removed successfully");
        }
        else
        {
              Console.WriteLine("stock not removed successfully");

        
        }
    }

    private static void PerformQueryStock1(Stock1 stock)
    {
        stock.PrintSummary();                           // print the available stock
    }
    private static MenuOption ReadUserOption ()
    { 
        int option; 
        Console.WriteLine(" 1. Buy new stock ");
        Console.WriteLine(" 2. Sell stock ");
        Console.WriteLine(" 3. Display the available stock");
        Console.WriteLine("4. Quit");
        do 
        {    
        try                 // try and catch block perform the exception handling
        {
            Console.WriteLine("Choose any option (1/2/3/4): " );
            option = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter the number");
            option = -1;

        }
    } while (option<1 || option >4); 
    return (MenuOption) (option - 1); 
    }
 }
    
    public enum MenuOption          
{
    BuyStock, 
    SellStock, 
    QueryStock, 
    Quit
}


      
      

        
    

   
