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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPresentation.Animals;
using WpfPresentation.Community;
using WpfPresentation.Management;
using LogicLayer;

namespace PetNetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[] _mainTabButtons;
        private MasterManager _manager = null;
        public MainWindow()
        {
            InitializeComponent();
            _manager = new MasterManager();
            _mainTabButtons = new Button[] { btnAnimals, btnCommunity, btnDonate, btnEvents, btnShelters, btnDonations, btnManagement };
        }

        private void btnDonate_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
        }

        private void ChangeSelectedButton(Button selectedButton)
        {
            UnselectAllButtons();
            selectedButton.Style = (Style)Resources["rsrcSelectedButton"];
        }

        private void UnselectAllButtons()
        {
            foreach (Button button in _mainTabButtons)
            {
                button.Style = (Style)Resources["rsrcUnselectedButton"];
            }
        }

        private void btnShelters_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
        }

        private void btnCommunity_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(CommunityPage.GetCommunityPage(_manager));
        }

        private void btnAnimals_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(AnimalsPage.GetAnimalsPage(_manager));
        }

        private void btnManagement_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(ManagementPage.GetManagementPage(_manager));
        }

        private void btnDonations_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            UnselectAllButtons();
        }

        private void btnNotification_Click(object sender, RoutedEventArgs e)
        {
            UnselectAllButtons();
        }
    }
}
