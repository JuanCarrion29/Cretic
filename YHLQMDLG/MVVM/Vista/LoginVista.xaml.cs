﻿using System;
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

namespace YHLQMDLG.MVVM.Vista
{
    /// <summary>
    /// Lógica de interacción para LoginVista.xaml
    /// </summary>
    public partial class LoginVista : Window
    {
        public LoginVista()
        {
            InitializeComponent();
        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void btnMinimize_Dandole(object sender, RoutedEventArgs e)
        {


            WindowState = WindowState.Minimized;
        }

        private void btnCerra_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }



        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnLogin.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                e.Handled = true;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
