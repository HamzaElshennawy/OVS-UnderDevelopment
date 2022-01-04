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

namespace Online_Voting
{
    /// <summary>
    /// Interaction logic for DashBoardScene.xaml
    /// </summary>
    public partial class DashBoardScene : Window
    {
        public DashBoardScene()
        {
            InitializeComponent();
        }
        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contacts.Visibility = Visibility.Collapsed;
                tt_messages.Visibility = Visibility.Collapsed;
                tt_signout.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contacts.Visibility = Visibility.Visible;
                tt_messages.Visibility = Visibility.Visible;
                tt_signout.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void Tg_Btn_Checked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListViewItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void homeBTN_Click(object sender, RoutedEventArgs e)
        {
            
            Leaderpn.Visibility = Visibility.Collapsed;
            Votepn.Visibility = Visibility.Collapsed;
            Homepn.Visibility = Visibility.Visible;
        }

        
        private void VoteBTN_Click(object sender, RoutedEventArgs e)
        {
            
            Leaderpn.Visibility = Visibility.Collapsed;
            Votepn.Visibility = Visibility.Visible;
            Homepn.Visibility = Visibility.Collapsed;
        }

        private void LeaderBTN_Click(object sender, RoutedEventArgs e)
        {
            
            Leaderpn.Visibility = Visibility.Visible;
            Votepn.Visibility = Visibility.Collapsed;
            Homepn.Visibility = Visibility.Collapsed;
        }

        private void signoutBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
