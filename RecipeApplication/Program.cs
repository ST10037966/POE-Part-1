using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    //Start Of Application
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true)
            {
                //Menu for the user to make specific selections for the Recipe Application
                Console.WriteLine("\n*********************************************");
                Console.WriteLine("Type and input of '1' to enter recipe details");
                Console.WriteLine("Type and input of '2' to display recipe");
                Console.WriteLine("Type and input of '3' to scale recipe");
                Console.WriteLine("Type and input of '4' to reset quantities");
                Console.WriteLine("Type and input of '5' to clear recipe");
                Console.WriteLine("Type and input of '6' to exit");
                Console.WriteLine("*********************************************");

                // Functions of the Application menu
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        recipe.RecipeDetails();
                        break;
                    case "2":
                        recipe.DisplayRecipe();
                        break;
                    case "3":
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        break;
                    case "4":
                        recipe.ResetQuantities();
                        break;
                    case "5":
                        recipe.ClearRecipe();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid choice.");
                        break;

                        //End of Application
                }
            }
        }
    }
}
//-------------------------------------------------fin.-------------------------------------------------//
//--------------------------------------------------CDC-------------------------------------------------//
