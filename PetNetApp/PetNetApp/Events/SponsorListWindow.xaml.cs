﻿using DataObjects;
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

namespace WpfPresentation.Events
{
    /// <summary>
    /// Interaction logic for SponsorListWindow.xaml
    /// </summary>
    public partial class SponsorListWindow : Window
    {
        private List<InstitutionalEntity> _sponsors;
        public InstitutionalEntity returnValue;
        private List<InstitutionalEntity> sponsorSearch;
        public SponsorListWindow(List<InstitutionalEntity> sponsors)
        {
            InitializeComponent();
            _sponsors = sponsors;
            returnValue = null;
        }

        private void btnCanle_Click(object sender, RoutedEventArgs e)
        {
            returnValue = null;
            this.DialogResult = false;
        }

        private void SponsorSearching()
        {
            sponsorSearch = new List<InstitutionalEntity>();
            if (txtSearchSponsor.Text.ToLower() == "")
            {
                foreach (InstitutionalEntity sponsor in _sponsors)
                {
                    sponsorSearch.Add(sponsor);
                }
            }
            else
            {
                foreach (InstitutionalEntity sponsor in _sponsors)
                {
                    if (sponsor.CompanyName.ToLower().Contains(txtSearchSponsor.Text.ToLower()))
                    {
                        sponsorSearch.Add(sponsor);
                    }
                }
            }
            PopulateSponsors();
        }

        private void DisplaySponsors(InstitutionalEntity sponsor)
        {
            UCEventSponsor ucEventSponsor = new UCEventSponsor();
            ucEventSponsor.lblSponsorName.Content = sponsor.CompanyName;
            ucEventSponsor.btnView.Click += (obj, arg) => BtnView_Click(sponsor);
            ucEventSponsor.btnAdd.Click += (obj, arg) => BtnAdd_Click(sponsor);
            ucEventSponsor.Margin = new Thickness(0, 0, 10, 0);
            stpEventSponsors.Children.Add(ucEventSponsor);
        }

        private void BtnAdd_Click(InstitutionalEntity sponsor)
        {
            returnValue = sponsor;
            this.DialogResult = false;
        }

        private void BtnView_Click(InstitutionalEntity sponsor)
        {
            PromptWindow.ShowPrompt("Sponsor Detail", "Name: " + sponsor.CompanyName + "\n\n" 
                + "Email: " + sponsor.Email + "\n\n" + "Phone Number: " + sponsor.Phone);
        }

        private void PopulateSponsors()
        {
            stpEventSponsors.Children.Clear();
            foreach (InstitutionalEntity sponsor in sponsorSearch)
            {
                DisplaySponsors(sponsor);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SponsorSearching();
        }

        public InstitutionalEntity GetReturnValue()
        {
            return returnValue;
        }

        private void txtSearchSponsor_TextChanged(object sender, TextChangedEventArgs e)
        {
            SponsorSearching();
        }
    }
}
