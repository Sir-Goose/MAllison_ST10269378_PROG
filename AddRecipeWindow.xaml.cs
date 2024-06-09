using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MAllison_ST10269378_PROG
{
    /// <summary>
    /// Interaction logic for AddRecipeWindow.xaml
    /// The 'back end' of the add recipe window
    /// has all the logic for button clicks 
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        public delegate void RecipeAddedHandler(Recipe newRecipe);
        public event RecipeAddedHandler RecipeAdded;

        private Recipe _newRecipe; // Create new recipe object
        //------------------------------------------------------------------------------------------------------------//
        
        // Constructor
        public AddRecipeWindow()
        {
            InitializeComponent();
            _newRecipe = new Recipe(); //
        }
        //------------------------------------------------------------------------------------------------------------//

        // Add all the relavent ui elements on click of the add ingredients button
        private void AddIngredientsButton_Click(object sender, RoutedEventArgs e)
        {
            int numIngredients; // Keep track of number of ingredients for a given recipe
            if (int.TryParse(NumIngredientsTextBox.Text, out numIngredients))
            {
                // Clear any existing ingredients left over from previous recipe
                _newRecipe.Ingredients.Clear();
                IngredientsListBox.Items.Clear();

                // Add the specified number of ingredient input controls for the number of ingredients chosen by the user
                for (var i = 0; i < numIngredients; i++)
                {
                    // StackPanel to hold the ingredient input controls
                    var ingredientPanel = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(5) };

                    // Ingredient name input box
                    ingredientPanel.Children.Add(new Label { Content = $"Ingredient {i + 1} Name:" });
                    ingredientPanel.Children.Add(new TextBox { Name = $"IngredientName{i}", Width = 100 });

                    // Quantity input box
                    ingredientPanel.Children.Add(new Label { Content = "Quantity:" });
                    ingredientPanel.Children.Add(new TextBox { Name = $"IngredientQuantity{i}", Width = 50 });

                    // Unit input combo box
                    ingredientPanel.Children.Add(new Label { Content = "Unit:" });
                    var unitComboBox = new ComboBox
                    {
                        Name = $"IngredientUnit{i}", Width = 80,
                        ItemsSource = Enum.GetValues(typeof(Recipe.CookingMeasurement))
                    };
                    ingredientPanel.Children.Add(unitComboBox);

                    // Calories input box
                    ingredientPanel.Children.Add(new Label { Content = "Calories:" });
                    ingredientPanel.Children.Add(new TextBox { Name = $"IngredientCalories{i}", Width = 50 });

                    // Food group combobox
                    ingredientPanel.Children.Add(new Label { Content = "Food Group:" });
                    var foodGroupComboBox = new ComboBox
                    {
                        Name = $"IngredientFoodGroup{i}", Width = 80,
                        ItemsSource = Enum.GetValues(typeof(Recipe.FoodGroup))
                    };
                    ingredientPanel.Children.Add(foodGroupComboBox);

                    // Ingredient panel 
                    IngredientsListBox.Items.Add(ingredientPanel);
                }
            }
            else
            {   // Give error to user if parsing as an integer failed
                MessageBox.Show("Please enter a valid number of ingredients.");
            }
        }
        //------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Add relavent UI elements upon click of the add steps button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStepsButton_Click(object sender, RoutedEventArgs e)
        {
            int numSteps; // stores the number of steps input by the user
            if (int.TryParse(NumStepsTextBox.Text, out numSteps))
            {
                // Clear any existing steps from previous recipes
                _newRecipe.Steps.Clear();

                // Add the specified number of step input controls for what the number of steps entered by the user was
                for (var i = 0; i < numSteps; i++)
                {
                    // Create a StackPanel to hold the step input controls
                    var stepPanel = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(5) };

                    // Step description input box
                    stepPanel.Children.Add(new Label { Content = $"Step {i + 1} Description:" });
                    stepPanel.Children.Add(new TextBox { Name = $"StepDescription{i}", Width = 200 });

                    // Add the step panel to the ListBox
                    IngredientsListBox.Items.Add(stepPanel);
                }
            }
            else
            {
                // Display an error message to the user if the number of steps could not be parsed as an integer
                MessageBox.Show("Please enter a valid number of steps.");
            }
        }
        //------------------------------------------------------------------------------------------------------------//

        // The logic to be executed upon click of the save recipe button
        private void SaveRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            _newRecipe.Name = RecipeNameTextBox.Text; // Get the name of the recipe and assign it to the recipe object

            Console.WriteLine(IngredientsListBox.Items.Count); // debug
            // Retrieve the ingredients 
            for (var i = 0; i < IngredientsListBox.Items.Count - 1; i++)
            {
                var ingredientPanel = (StackPanel)IngredientsListBox.Items[i];

                // Get the data from the various data fields from the panel
                var ingredientNameTextBox = ingredientPanel.Children.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"IngredientName{i}"); // Name
                var ingredientQuantityTextBox = ingredientPanel.Children.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"IngredientQuantity{i}"); // Quantity
                var ingredientUnitComboBox = ingredientPanel.Children.OfType<ComboBox>().FirstOrDefault(cb => cb.Name == $"IngredientUnit{i}"); // Unit
                var ingredientCaloriesTextBox = ingredientPanel.Children.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"IngredientCalories{i}"); // Calories
                var ingredientFoodGroupComboBox = ingredientPanel.Children.OfType<ComboBox>().FirstOrDefault(tb => tb.Name == $"IngredientFoodGroup{i}"); // Food Group

                // Check that all the fields were filled in
                if (ingredientNameTextBox != null && ingredientQuantityTextBox != null && ingredientUnitComboBox != null && ingredientCaloriesTextBox != null && ingredientFoodGroupComboBox != null)
                {
                    var ingredientName = ingredientNameTextBox.Text;
                    var ingredientQuantity = int.Parse(ingredientQuantityTextBox.Text);
                    var ingredientUnit = (Recipe.CookingMeasurement)Enum.Parse(typeof(Recipe.CookingMeasurement), ingredientUnitComboBox.SelectedItem.ToString());
                    var ingredientCalories = int.Parse(ingredientCaloriesTextBox.Text);
                    var foodGroup = ingredientFoodGroupComboBox.Text;

                    // Create a new Ingredient object with all the captured data and add it to the recipes ingredients list
                    _newRecipe.Ingredients.Add(new Recipe.Ingredient
                    {
                        Name = ingredientName,
                        Quantity = ingredientQuantity,
                        Unit = ingredientUnit,
                        Calories = ingredientCalories,
                        FoodGroup = foodGroup
                    });
                }
                else
                {   // If not all fields were filled in display an error to the user
                    MessageBox.Show($"Error retrieving ingredient data for ingredient {i + 1}.");
                }

            }

            // Retrieve steps from the ListBox
            foreach (StackPanel stepPanel in IngredientsListBox.Items)
            {
                // Access step description directly from the TextBox within the StackPanel
                var stepDescriptionTextBox = stepPanel.Children[1] as TextBox;

                if (stepDescriptionTextBox != null)
                {
                    var stepDescription = stepDescriptionTextBox.Text;

                    // Create a new Step object and add it to the recipe's steps list
                    _newRecipe.Steps.Add(new Recipe.Step
                    {
                        Position = _newRecipe.Steps.Count + 1, // Determine position of current step from last step
                        Description = stepDescription
                    });
                }
                else
                {
                    // If description not provided display error to the user
                    MessageBox.Show($"Error retrieving step description for step {_newRecipe.Steps.Count + 1}.");
                }
            }

            // Raise the RecipeAdded event to update the main window
            RecipeAdded?.Invoke(_newRecipe);

            // Close the window 
            Close();
        }
        //------------------------------------------------------------------------------------------------------------//

    }
}
//------------------------------------------------END-OF-FILE---------------------------------------------------------//

