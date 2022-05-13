﻿using nikita.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace nikita.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(textName.Text == "111" && textPassword.Text == "111")
            {
                Window window = new DataWindow();
                window.Show();
                this.Close();
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Window window = new RegistrationWindow();
            window.Show();
            this.Close();
        }
    }
}
