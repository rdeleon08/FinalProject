namespace FinalProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----CIDM2315 Final Project: Richard Deleon-----");
        Console.WriteLine("-----Welcome to Buff Kitchen-----");

        string username = "Alice";
        string password = "123";

        Console.WriteLine("Please input username");
        string input_username = Console.ReadLine();

        Console.WriteLine("Please input password");
        string input_password = Console.ReadLine();

        if(input_username == username && input_password == password)
        {
            Console.WriteLine("Login Successfully!");

            while(true)
            {
            
                Console.WriteLine("** Hello Cashier: Alice**");
                Console.WriteLine("******************");
                Console.WriteLine("Please select:");

                Console.WriteLine("1. Start New Order");
                Console.WriteLine("2. Check Submitted Orders");
                Console.WriteLine("3. Remove Finished Orders");
                Console.WriteLine("4. Log Out System");

                Console.WriteLine("*******************");

                 Console.WriteLine("Please input an option");
                    string Choice = Console.ReadLine();
            
                    if(Choice == "1")
                {
                string entree, drink, side;
                double entree_price, drink_price, side_price;
                int entree_Choice, drink_Choice, side_Choice;
            
                Console.WriteLine("-->Customer Name: ");
                string customer_name=Console.ReadLine();

                Console.WriteLine("--:>Select Entree");
                Console.WriteLine("0) 0 - Food: Chicken Sandwhich Price: 5.99");
                Console.WriteLine("1) 1 - Food: Chicken Nuggests Price: 8.99");
                Console.WriteLine("2) 2 - Food: Chicken Strips Price: 9.99");
                Console.WriteLine("3) 3 - Food: Beef Burger Price: 6.99");
                entree_Choice = Convert.ToInt16(Console.ReadLine());
                if(entree_Choice == 0){
                    entree = "Chicken Sandwhich";
                    entree_price = 5.99;
                }
                else if(entree_Choice == 1){
                    entree = "Chicken Nuggets";
                    entree_price = 8.99;
                }
                else if(entree_Choice == 2){
                    entree = "Chicken Strips";
                    entree_price = 9.99;
                }
                else{
                    entree = "Beef Burger";
                    entree_price = 6.99;
                }

                Console.WriteLine("-->Select Drink");
                Console.WriteLine("0) 0 - Food: Ice Tea Price: ");
                Console.WriteLine("1) 1 - Food: Soda Price: 1.99");
                Console.WriteLine("2) 2 - Food: Lemonade Price: 2.99");
                Console.WriteLine("3) 3 - Food: Coffee Price: 3.99");
                drink_Choice = Convert.ToInt16(Console.ReadLine());
                if(drink_Choice == 0){
                    drink = "Ice Tea";
                    drink_price = 2.99;
                }
                else if(drink_Choice == 1){
                    drink = "Soda";
                    drink_price = 1.99;
                }
                else if(drink_Choice == 2){
                    drink = "Lemonade";
                    drink_price = 2.99;
                }
                else{
                    drink = "Cofee";
                    drink_price = 3.99;
                }

                Console.WriteLine("-->Select Side");
                Console.WriteLine("0) 0 - Food: Potato Fries Price 3.99");
                Console.WriteLine("1) 1 - Food: Salad Price 4.99");
                Console.WriteLine("2) 2 - Food: Fruit Cup Price: 9.99");
                Console.WriteLine("3) 3 - Food: Potato Chips Price: 2.99");
                side_Choice = Convert.ToInt16(Console.ReadLine());
                if(side_Choice == 0){
                    side = "Potato Fries";
                    side_price = 3.99;
                }
                else if(side_Choice == 1){
                    side = "Salad";
                    side_price = 4.99;
                }
                else if(side_Choice == 2){
                    side = "Fruit Cup";
                    side_price = 9.99;
                }
                else{
                    side = "Potato chips";
                    side_price = 2.99;
                }

                Console.WriteLine("-----Order Summary -----");
                Console.WriteLine("Food: {0}\t Price: {1}", entree, entree_price);
                Console.WriteLine("Food: {0}\t Price: {1}", drink, drink_price);
                Console.WriteLine("Food: {0}\t Price: {1}", side, side_price);
                double total = entree_price + drink_price + side_price;
                Console.WriteLine("-----Total: {0}-----", total);
                }

                if(Choice=="2"){
                    Console.WriteLine("-----Number of Orders: 2-----");
                    Console.WriteLine("-> 0 - Customer: Bob Total: 15.97");
                    Console.WriteLine("-> 1 - Customer: Cathy Total: 22.97");
                    Console.WriteLine("------------------");
                }
                if(Choice=="3"){
                Console.WriteLine("-----Number of Order: 2-----");
                Console.WriteLine("-> 0 - Customer: Bob Total: 15.97");
                Console.WriteLine("-> 1 - Customer: Cathy Total: 22.97");
                Console.WriteLine("-----Input order ID to remove a finsihed order: -----");
                int orderID = Convert.ToInt16(Console.ReadLine);
                Console.WriteLine("-----Number of Order: 1-----");
                Console.WriteLine("---------------------");
                }

                if(Choice=="4"){
                    Console.WriteLine("->Log Out System");
                    break;
                }
            }
        }
            else{
                Console.WriteLine("Login Failed");
            }
    }
}
    
           
    

        
    





        


           



            























        
          