﻿using System.Windows;
using System.Windows.Controls;

namespace PZ_26_Petashvili_2pk2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewFileMenuItemClick(object sender, RoutedEventArgs e)
        {
            string name;
            CreateFileWindow createFileWindow = new();
            if (createFileWindow.ShowDialog() == true)
                name = createFileWindow.FileName;
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextField_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
        }

        private void TextField_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }

        private void Button_Trash(object sender, RoutedEventArgs e)
        {
            mainRTB.Document.Blocks.Clear();
        }

        private void Button_Italic(object sender, RoutedEventArgs e)
        {
            
        }
    }
}