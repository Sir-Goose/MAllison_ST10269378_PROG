using System.Windows;

namespace MAllison_ST10269378_PROG
{
    /// <summary>
    /// Interaction logic for ViewRecipeWindow.xaml
    /// The 'back end' of the view recipe window.
    /// Contains the name,
    /// list of ingredients and their data,
    /// and all the steps
    /// </summary>
    public partial class ViewRecipeWindow : Window
    {
        // Constructor
        public ViewRecipeWindow(Recipe recipe)
        {
            InitializeComponent();

            // Display recipe details
            RecipeNameTextBlock.Text = recipe.Name; // Recipe Name
            IngredientsListBox.ItemsSource = recipe.Ingredients; // Ingredient List
            StepsListBox.ItemsSource = recipe.Steps; // Step List
        }
        //------------------------------------------------------------------------------------------------------------//
        
        // Close the window
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //------------------------------------------------------------------------------------------------------------//
    }
}
//----------------------------------------------------END-OF-FILE-----------------------------------------------------//
