using System;
using System.Collections.Generic;


public class MenuItem
{
    public string Appitizer (get; set;)
     public string MainCourse (get; set;)
      public string Dessert (get; set;)
      public bool New {get; set; } = true
}
public class program
{
    public static void Main(string[] args)
    {
        MenuItem order = new MenuItem();
       
       
        order.Appitizer = "Burnt Ends";
        order.MainCourse = "Grilled Salmon and Rice";
        order.Dessert = "The Heartbreak";
        


       Console.WriteLine("Appitizer\n" + order.Appitizer + ": $5.99\n   Enjoy these burnt ends that will have you question if you turned the oven off at home!");
       Console.WriteLine("\nMainCourse\n" + order.MainCourse + " : $15.99   NEW\n         Fresh salmon sourced locally with a seasoned rice with kickin' flavor it makes you savor the flavor! \n");
       Console.WriteLine("\nDessert\n" + order.Dessert + " :$18.90\n    The Heartbreak is a house special that is made with goat milk that will have you sound like a New York Native, Forgetta bout her.");
    }
}





