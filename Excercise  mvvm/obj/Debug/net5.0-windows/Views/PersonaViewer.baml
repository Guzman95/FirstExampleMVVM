   M S B A M L   `   `   `  ����J  FExcercise  mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Excercise__mvvm.ViewsExcercise__mvvm.Views  5   	   I)clr-namespace:Excercise__mvvm.ModelsViewsExcercise__mvvm.ModelsViews  5   	   )    #Excercise__mvvm.Views.PersonaViewer   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Excercise__mvvm.Views     5   	   8vm)clr-namespace:Excercise__mvvm.ModelsViews     5   	     � Title$  PersonaViewer��5	   	   $	��450��6   $	��800��6,    � 	Resources 5
      2   ,Excercise__mvvm.ModelsViews.PersonaViewModel   	PersonaVM��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��215* �6   �� 5      $
��209* �6   �� 5      $
��Auto �6   .+�5   
   �� $��2��6`   ��6   �� *ListaPersonas+ �� SelectedItem 68   �� *CurrentPersona+6`   �� 5   
   $��1��6   $
��Left=�6E   $��	0,209,0,0q�6`   $��2��6s   ��6   �� *ListaPersonas.Count+6s   �� 5   
   $��Cargar��6;   $��Right=�6L   $��	0,124,0,0q�6h   $��2��6{   $	��129��6�   $��1��6�   ��6   �� *ListarPersonasCommand+6�   �� 5   
   $��VerInfo��64   $��Right=�6F   $��0,124,317,0q�6b   $	��129��6w   $��1��6�   ��6   �� *VerInfoCommand+6�   5      5      