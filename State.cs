using System.Collections.Generic;

namespace MAllison_ST10269378_PROG
{
    /// <summary>
    /// A very simple class 
    /// Currently contains a list of all the recipes to be globally accessed
    /// without having to pass data between functions. This greatly simplifies things.
    /// </summary>
    public static class State
    {
        public static List<Recipe> Recipes = new List<Recipe>();
    }
}
//----------------------------------------------END-OF-FILE-------------------------------------------------------------
