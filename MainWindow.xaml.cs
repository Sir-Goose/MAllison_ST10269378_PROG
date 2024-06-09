using LiveCharts.Wpf;
using LiveCharts;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace MAllison_ST10269378_PROG
{
    /// <summary>
    /// The 'back end' for the main window
    /// contains a few buttons and the pie chart
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Recipe> SelectedRecipes { get; set; } = new List<Recipe>(); // List of user selected recipes

        // Default constructor
        public MainWindow()
        {
            InitializeComponent();
        }   
        //------------------------------------------------------------------------------------------------------------//
        
        // Logic to run upon clicking the add recipe button
        private void AddRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new window to add a recipe
            var addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.RecipeAdded += OnRecipeAdded;
            addRecipeWindow.ShowDialog();
        }
        //------------------------------------------------------------------------------------------------------------//

        private void OnRecipeAdded(Recipe newRecipe)
        {
            // Add the new recipe to the recipe object collection in the state class
            State.Recipes.Add(newRecipe);

            // Update the recipe list
            UpdateRecipeList();
        }
        //------------------------------------------------------------------------------------------------------------//

        // Update the list of recipes displayed in the UI
        private void UpdateRecipeList()
        {
            RecipeListBox.ItemsSource = null;
            RecipeListBox.ItemsSource = State.Recipes;
        }
        //------------------------------------------------------------------------------------------------------------//

        // Logic to run upon clicking the view recipe button
        private void ViewRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Check if any recipe is selected
            if (RecipeListBox.SelectedItem is Recipe selectedRecipe)
            {
                // Create and show the view recipe window
                var viewRecipeWindow = new ViewRecipeWindow(selectedRecipe);
                viewRecipeWindow.ShowDialog();
            }
            else
            {
                // Display an error message to the user if they did not select a recipe
                MessageBox.Show("Please select a recipe to view.");
            }
        }
        //-----------------------------------------------------------------------------------------------------------=//

        // Logic for when the generate menu button is clicked
        private void GenerateMenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve the selected recipes from the ListBox
            SelectedRecipes = RecipeListBox.SelectedItems.Cast<Recipe>().ToList();

            if (SelectedRecipes.Count > 0)
            {
                // Calculate and display the food group percentages for the pie chart
                CalculateAndDisplayFoodGroupPercentages();
            }
            else
            {
                // Display an error message to the user if they did not select any recipes
                MessageBox.Show("Please select at least one recipe to generate a menu.");
            }
        }
        //------------------------------------------------------------------------------------------------------------//

        // Method to create the food group pie chart
        private void CalculateAndDisplayFoodGroupPercentages()
        {
            // Create a dictionary to store food group quantities
            var foodGroupQuantities = new Dictionary<string, int>();

            // Loop through the selected recipes and their ingredients
            foreach (var recipe in SelectedRecipes)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    if (foodGroupQuantities.ContainsKey(ingredient.FoodGroup))
                    {
                        foodGroupQuantities[ingredient.FoodGroup] += ingredient.Quantity;
                    }
                    else
                    {
                        foodGroupQuantities[ingredient.FoodGroup] = ingredient.Quantity;
                    }
                }
            }

            // Calculate the total quantity of all food groups
            var totalQuantity = foodGroupQuantities.Values.Sum();

            // Create a chartValues list for the pie chart
            var chartValues = new SeriesCollection();

            // Populate the chartValues with food group percentages
            foreach (var keyValuePair in foodGroupQuantities)
            {
                var percentage = (double)keyValuePair.Value / totalQuantity * 100;
                chartValues.Add(new PieSeries
                {
                    Title = keyValuePair.Key,
                    Values = new ChartValues<double> { percentage },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y:F2}%" // Display percentages with two decimal places
                });
            }

            // Update the pie chart
            FoodGroupPieChart.Series = chartValues;
        }
        //------------------------------------------------------------------------------------------------------------//
    }
}
//-------------------------------------------------------END-OF-FILE--------------------------------------------------//

