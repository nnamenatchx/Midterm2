class Program {
    static void Main(string[] args) {
        Console.Write("1-7 :" );
        int DayofWeek = int.Parse(Console.ReadLine());

        Console.Write("8-10");
        int TimeofDay = int.Parse(Console.ReadLine());

        Console.Write("Menu");
        string MenuItem = Console.ReadLine();
        
        int breakfastsetCount = 5;
        int weekendsetCount = 2;
        int coffeeCount = 3;

        while (MenuItem != "End") {
            switch (MenuItem)

            case "breakfastsetCount";
            if(breakfastsetCount == 0) {
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
            elsa if(DayOfWeek == 7 || TimeofDay >= 11) {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            case "weekendsetCount";
            if(weekendsetCount == 0) {
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
            else if(DayofWeek == 7 || TimeofDay >= 11) {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            case "coffeeCount" ;
            if(coffeeCount == 0) {
                Console.WriteLine("Sorry your order is out of stock");
                break;
            }
            else if(DayOfWeek == 7 || TimeofDay >= 11) {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            default:
            Console.WriteLine("Please enter a valid menu")
        }        
    }
}