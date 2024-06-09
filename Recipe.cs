using System.Collections.Generic;

namespace MAllison_ST10269378_PROG
{
    /// <summary>
    /// This is the recipe class. It contains all the data that needs to be kept track of for recipes.
    /// </summary>
    public class Recipe
    {
        /// <summary>
        /// This is the ingredient struct. It consists of Name, Quantity, Unit, Calories and Foodgroup.
        /// It is just a structed way to store ingredient information.
        /// </summary>
        public struct Ingredient
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public CookingMeasurement Unit { get; set; }
            public int Calories { get; set; }
            public string FoodGroup { get; set; }

            // Custom to string method to return the information about each ingredient in a nicelyy formatted way
            public override string ToString()
            {
                return $"{Quantity} {Unit} of {Name} ({Calories} calories, {FoodGroup})";
            }
        }
        //------------------------------------------------------------------------------------------------------------//
        
        /// <summary>
        /// Step struct. Contains position and description information that makes up each step in
        /// a recipe.
        /// </summary>
        public struct Step
        {
            public int Position { get; set; }
            public string Description { get; set; }

            // Custom to string method to return the information about each step in a nicely formatted way
            public override string ToString()
            {
                return $"{Position}. {Description}";
            }
        }
        //------------------------------------------------------------------------------------------------------------//
        
        /// <summary>
        /// Cooking measurement enums to ensure only sensible real measurement units
        /// are used by the user.
        /// </summary>
        public enum CookingMeasurement
        {
            Teaspoon,
            Tablespoon,
            Cup,
            Pint,
            Quart,
            Gallon,
            Milliliter,
            Liter,
            Gram,
            Kilogram,
            Ounce,
            Pound
        }
        //------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// The main food groups. Used in the drop down combobox menu in the recipe creation window
        /// </summary>
        public enum FoodGroup
        {
            Fruits,
            Vegetabkes,
            Protein,
            Dairy,
            Grains,
            Fats
        }
        //------------------------------------------------------------------------------------------------------------//
        public List<Ingredient> Ingredients = new List<Ingredient>(); // List to store the ingredients
        public List<Step> Steps = new List<Step>(); // List to store the steps

        private string name; // name of the recipe

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Calculate and return the total number of calories in the recipe
        /// </summary>
        /// <returns></returns>
        public int CalculateTotalCalories()
        {
            var totalCalories = 0;
            foreach (var ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }
        //------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Custom to string method to return the correct information to the UI
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }


    }
}
//----------------------------------------------END-OF-FILE-----------------------------------------------------------//
