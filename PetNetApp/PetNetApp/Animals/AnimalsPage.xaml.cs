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
using LogicLayer;

namespace WpfPresentation.Animals
{
    /// <summary>
    /// Interaction logic for AnimalsPage.xaml
    /// </summary>
    public partial class AnimalsPage : Page
    {
        private static AnimalsPage _existingAnimalsPage = null;

        private MasterManager _manager = null;
        private Button[] _animalsTabButtons;

        private AnimalsPage(MasterManager manager)
        {
            InitializeComponent();
            _manager = manager;
            _animalsTabButtons = new Button[] { btnAdopt, btnFoster, btnSurrender, btnAnimalList, btnMedical };
        }

        public static AnimalsPage GetAnimalsPage(MasterManager manager)
        {
            if (_existingAnimalsPage == null)
            {
                _existingAnimalsPage = new AnimalsPage(manager);
            }
            return _existingAnimalsPage;
        }

        private void ChangeSelectedButton(Button selectedButton)
        {
            UnselectAllButtons();
            selectedButton.Style = (Style)Resources["rsrcSelectedButton"];
        }

        private void UnselectAllButtons()
        {
            foreach (Button button in _animalsTabButtons)
            {
                button.Style = (Style)Resources["rsrcUnselectedButton"];
            }
        }

        private void btnAdopt_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameAnimals.Navigate(new AdoptPage());
        }

        private void btnFoster_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameAnimals.Navigate(new FosterPage());
        }

        private void btnSurrender_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
        }

        private void btnAnimalList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMedical_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
