﻿using DataObjects;
using LogicLayer;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPresentation.UserControls;

namespace WpfPresentation.Fundraising
{
    /// <summary>
    /// Interaction logic for ViewSpecificDonationPage.xaml
    /// </summary>
    public partial class ViewSpecificDonationPage : Page
    {
        public static Donation Donation { get; set; }
        private MasterManager masterManager = MasterManager.GetMasterManager();
        private List<InKind> inKinds;
        public ViewSpecificDonationPage(Donation donation)
        {
            Donation = donation;
            InitializeComponent();
        }

        private void this_Loaded(object sender, RoutedEventArgs e)
        {
            if(Donation.HasInKindDonation)
            {
                spInKindDonations.Children.Clear();
                try
                {
                    inKinds = masterManager.DonationManager.RetrieveInKindsByDonationId(Donation.DonationId);
                }
                catch (Exception ex)
                {
                    PromptWindow.ShowPrompt("Error", ex.Message);
                }
                foreach (var inKind in inKinds)
                {
                    InKindUserControl inKindUserControl = new InKindUserControl(inKind);
                    spInKindDonations.Children.Add(inKindUserControl);
                }
            } 
            else
            {
                HideInKindElements();
            }

        }

        public void HideInKindElements()
        {
            lblInKind.Visibility = Visibility.Hidden;
            lblDesc.Visibility = Visibility.Hidden;
            lblQuanity.Visibility = Visibility.Hidden;
            svInkind.Visibility = Visibility.Hidden;
            spInKindDonations.Visibility = Visibility.Hidden;
        }
    }
}
