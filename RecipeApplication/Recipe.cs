using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication
{
    //Start of Worker Class
    class Recipe
    {
        //Variable Declarations
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;

        public Recipe()
        {
            // Declares The ingredients, Quantitities, Units, and Steps as empty arrays
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }

        public void RecipeDetails()
        {
            // Gets the user to enter the number of ingredients for their recipe
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            // Initialize the arrays
            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];

            // Prompt the user to enter the details for each ingredient
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient #{i + 1}: ");
                Console.Write("Name: ");
                ingredients[i] = Console.ReadLine();
                Console.Write("Quantity: ");
                quantities[i] = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                units[i] = Console.ReadLine();
            }

            // Prompt the user to enter the number of steps
            Console.Write("Enter the number of steps for your recipe: ");
            int numSteps = int.Parse(Console.ReadLine());

            // Initialize the steps array with the correct size
            steps = new string[numSteps];

            // Prompt the user to enter the details for each step
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step number{i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            // Display the ingredients and quantities of the recipe 
            Console.WriteLine("The Ingredients and Steps for your recipe: ");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($"- {quantities[i]} {units[i]} of {ingredients[i]}");
            }

            // Display the steps
            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"- {steps[i]}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            // Multiplies all the quantities by the users desired scaling factor
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] *= factor;
            }
        }

        public void ResetQuantities()
        {
            // Resets the Quantites to allow the user to re-do the recipe
            for (int i = 0; i < quantities.Length; i++)
            {
                quantities[i] /= 2;
            }
        }

        public void ClearRecipe()
        {
            // Clears the recipe and arrays
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        //End of Worker Class
    }
}
//-------------------------------------------------fin.-------------------------------------------------//
//--------------------------------------------------CDC-------------------------------------------------//
