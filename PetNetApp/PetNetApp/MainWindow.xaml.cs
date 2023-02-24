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
using WpfPresentation.Shelters;
using LogicLayer;
using System.Diagnostics;
using WpfPresentation.Misc;
using WpfPresentation.Fundraising;
using DataObjects;

namespace PetNetApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button[] _mainTabButtons;
        private MasterManager _manager = MasterManager.GetMasterManager();

        public MainWindow()
        {
            InitializeComponent();
            // Remove navigation shortcuts
            NavigationCommands.BrowseBack.InputGestures.Clear();
            NavigationCommands.BrowseForward.InputGestures.Clear();

            // things to do when someone logs in
            _manager.UserLogin += () =>
            {
                ShowButtonsByRole();
                mnuUser.Header = "Hello, " + _manager.User.GivenName;
                mnuLogout.Header = "Log Out";
                frameMain.Navigate(null);
            };
            // things to do when someone logs out
            _manager.UserLogout += () =>
            {
                HideAllButtons();
                mnuUser.Header = "Hello, Guest";
                mnuLogout.Header = "Log In";
            };
            _mainTabButtons = new Button[] { btnAnimals, btnCommunity/*, btnDonate*/, btnEvents, btnShelters, btnFundraising, btnManagement };
            if (_manager.User == null)
            {
                mnuLogout.Header = "Log In";
            }
            else
            {
                mnuLogout.Header = "Log Out";
            }
            ShowButtonsByRole();
        }

        private void btnDonate_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            // replace with page name and then delete comment
            frameMain.Navigate(null);
        }

        private void ChangeSelectedButton(Button selectedButton)
        {
            UnselectAllButtons();
            selectedButton.Style = (Style)Resources["rsrcSelectedTabButton"];
        }

        private void UnselectAllButtons()
        {
            foreach (Button button in _mainTabButtons)
            {
                button.Style = (Style)Resources["rsrcUnselectedTabButton"];
            }
        }

        private void btnShelters_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(ShelterPage.GetShelterPage(_manager));
        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            // replace with page name and then delete comment
            frameMain.Navigate(null);
        }

        private void btnCommunity_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(CommunityPage.GetCommunityPage());
        }

        private void btnAnimals_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(AnimalsPage.GetAnimalsPage());
        }

        private void btnManagement_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(ManagementPage.GetManagementPage());
        }

        private void btnProfile_Click(object sender, RoutedEventArgs e)
        {
            UnselectAllButtons();
            if (_manager.User == null)
            {
                frameMain.Navigate(LogInPage.GetLogInPage());
            }
            else
            {
                frameMain.Navigate(UserProfilePage.GetUserProfilePage(this));
            }
        }

        private void btnNotification_Click(object sender, RoutedEventArgs e)
        {
            UnselectAllButtons();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollviewer = sender as ScrollViewer;
            if (e.Delta > 0)
            {
                scrollviewer.LineLeft();
            }
            else
            {
                scrollviewer.LineRight();
            }
            e.Handled = true;
        }

        private void UpdateScrollButtons()
        {
            if (svMainTabs.HorizontalOffset > svMainTabs.ScrollableWidth - 0.05)
            {
                btnScrollRight.Visibility = Visibility.Hidden;
            }
            else
            {
                btnScrollRight.Visibility = Visibility.Visible;
            }

            if (svMainTabs.HorizontalOffset < 0.05)
            {
                btnScrollLeft.Visibility = Visibility.Hidden;
            }
            else
            {
                btnScrollLeft.Visibility = Visibility.Visible;
            }
        }

        private void btnScrollRight_Click(object sender, RoutedEventArgs e)
        {
            svMainTabs.ScrollToHorizontalOffset(svMainTabs.HorizontalOffset + 160);
        }

        private void btnScrollLeft_Click(object sender, RoutedEventArgs e)
        {
            svMainTabs.ScrollToHorizontalOffset(svMainTabs.HorizontalOffset - 160);
        }

        private void svMainTabs_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            UpdateScrollButtons();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            btnMenu.ContextMenu.IsOpen = true;
        }

        private void mnuLogout_Click(object sender, RoutedEventArgs e)
        {
            if (_manager.User == null)
            {
                //frameMain.Navigate(LogInPage.GetLogInPage());
                _manager.User = new UsersVM()
                {
                    UsersId = 100000,
                    ShelterId = 100000,
                    FamilyName = "Jaurigue",
                    GivenName = "Stephen",
                    CreationDate = DateTime.Now,
                    Active = true,
                    Address = "Somewhere over the rainbow",
                    Roles = new List<string>() { "Admin" },
                    AddressTwo = "",
                    Email = "awesome@awesome.com",
                    GenderId = "Male",
                    PronounId = "He/Him",
                    Phone = "1234567890",
                    Zipcode = "50246"
                };
            }
            else
            {
                frameMain.Navigate(LandingPage.GetLandingPage(this));

                _manager.User = null;
            }
        }

        public void ShowButtonsByRole()
        {
            HideAllButtons();
            if (_manager.User != null)
            {
                ShowAnimalsButtonByRoles();
                ShowCommunityButtonByRoles();
                //ShowDonateButtonByRoles();
                ShowEventsButtonByRoles();
                ShowFundraisingButtonByRoles();
                ShowManagementButtonByRoles();
                ShowSheltersButtonByRoles();
            }
        }
        private void ShowAnimalsButtonByRoles()
        {
            string[] allowedRoles = { "Admin", "Manager", "Employee", "Vet" };
            if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
            {
                btnAnimals.Visibility = Visibility.Visible;
            }
        }
        private void ShowCommunityButtonByRoles()
        {
            string[] allowedRoles = {"Admin", "Manager", "Moderator", "Helpdesk" };
            if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
            {
                btnCommunity.Visibility = Visibility.Visible;
            }
        }
        //private void ShowDonateButtonByRoles() // Not a desktop thing?
        //{
        //    string[] allowedRoles = { "Admin", "Manager", "Marketting" };
        //    if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
        //    {
        //        btnDonate.Visibility = Visibility.Visible;
        //    }
        //}
        private void ShowEventsButtonByRoles()
        {
            string[] allowedRoles = { "Admin", "Manager", "Marketing", "Marketing"};
            if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
            {
                btnEvents.Visibility = Visibility.Visible;
            }
        }
        private void ShowSheltersButtonByRoles()
        {
            string[] allowedRoles = { "Admin", "Manager" };
            if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
            {
                btnShelters.Visibility = Visibility.Visible;
            }
        }
        private void ShowFundraisingButtonByRoles()
        {
            string[] allowedRoles = { "Admin", "Manager","Marketing" };
            if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
            {
                btnFundraising.Visibility = Visibility.Visible;
            }
        }
        private void ShowManagementButtonByRoles()
        {
            string[] allowedRoles = { "Admin", "Manager", "Helpdesk", "Employee", "Maintenance" };
            if (_manager.User.Roles.Exists(role => allowedRoles.Contains(role)))
            {
                btnManagement.Visibility = Visibility.Visible;
            }
        }

        private void mnuAccountSettings_Click(object sender, RoutedEventArgs e)
        {
            UnselectAllButtons();
            if (_manager.User == null)
            {
                frameMain.Navigate(LogInPage.GetLogInPage());
            }
            else
            {
                frameMain.Navigate(AccountSettingsPage.GetAccountSettingsPage(this));
            }
        }

        private void btnPetNetLogo_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(LandingPage.GetLandingPage(this));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(LandingPage.GetLandingPage(this));
        }
        private void HideAllButtons()
        {
            UnselectAllButtons();
            foreach (var tab in _mainTabButtons)
            {
                tab.Visibility = Visibility.Collapsed;
            }
        }
        private void btnFundraising_Click(object sender, RoutedEventArgs e)
        {
            ChangeSelectedButton((Button)sender);
            frameMain.Navigate(FundraisingPage.GetFundraisingPage(_manager));
        }
    }
}
