   M S B A M L   `   `   `  ����  MAllison_ST10269378_PROG/    )MAllison_ST10269378_PROG.ViewRecipeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  View Recipe��5   	   $	��450��6   $	��800��6*   .��5      � $��10q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Recipe Name:��6-   �� 5   
   -   5         ��Name$ RecipeNameTextBlock��5      $��0��61   $��1��6>   $��3q�6N   �� 5   
   $��1��6   $��0��6   $��Ingredients:��6-   �� 5   
   -   5         ��Name$ IngredientsListBox��5      $��2��6.   $��0��6;   $��2��6K   $��3q�6_   �� 5   
   $��3��6   $��0��6   $��Steps:��6-   �� 5   
   -   5        $ StepsListBox��5      $��4��6(   $��0��65   $��2��6E   $��3q�6Y   �� 5   
   -   5         ��Name$ CloseButton��5      $��5��6&   $��0��63   $��2��6C   $��Close��6W   $��3q�6g   6r   5       5"      