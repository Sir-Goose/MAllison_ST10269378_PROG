﻿#pragma checksum "..\..\AddRecipeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A3494A1037028FE51C56215EFC37AB25BE2F7F9933266ADEC4EDA2CC88F35E54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MAllison_ST10269378_PROG {
    
    
    /// <summary>
    /// AddRecipeWindow
    /// </summary>
    public partial class AddRecipeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecipeNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumIngredientsTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddIngredientsButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumStepsTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStepsButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox IngredientsListBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddRecipeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveRecipeButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MAllison_ST10269378_PROG;component/addrecipewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddRecipeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RecipeNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NumIngredientsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AddIngredientsButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\AddRecipeWindow.xaml"
            this.AddIngredientsButton.Click += new System.Windows.RoutedEventHandler(this.AddIngredientsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NumStepsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AddStepsButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddRecipeWindow.xaml"
            this.AddStepsButton.Click += new System.Windows.RoutedEventHandler(this.AddStepsButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.IngredientsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.SaveRecipeButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\AddRecipeWindow.xaml"
            this.SaveRecipeButton.Click += new System.Windows.RoutedEventHandler(this.SaveRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
