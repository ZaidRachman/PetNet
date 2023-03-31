﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    /// <summary>
    /// Stephen Jaurigue
    /// Created: 2023/03/03
    /// 
    /// This is a class containing fake data to be used inside of fake Accessors that need to affect the same data for unit tests
    /// </summary>
    public static class FundraisingFakeData
    {
        public static List<FundraisingCampaignVM> FundraisingCampaigns { get; set; }
        public static List<InstitutionalEntity> InstitutionalEntities { get; set; }
        public static List<Tuple<int, int>> FundraisingCampaignEntities { get; set; }
        //public static List<FundraisingEventVM> FundraisingEvents { get; set; }
        public static List<Tuple<int, int>> FundraisingEventEntities { get; set; }
 
        static FundraisingFakeData()
        {
            ResetFakeFundraisingCampaignData();
        }

        /// <summary>
        /// Stephen Jaurigue
        /// Created: 2023/03/04
        /// 
        /// This method resets the data stored inside the properties to their initial values,
        /// this is needed when using performing unit test cleanup so the data resets in between
        /// </summary>
        public static void ResetFakeFundraisingCampaignData()
        {
            Random rand = new Random();
            int fundraisingCampaignId = 100000;
            FundraisingCampaigns = new List<FundraisingCampaignVM>()
            {
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Consistent Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = 110000, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Consistent Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = 110001, Description="Garble Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Consistent Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = 110002, Description="Awesome sauce", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=null, FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Goop", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Grearble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Grearble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Grearble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wreow", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wreow", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wow", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wow", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wow", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wow", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Wow", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = false, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100002,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100003,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100001,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=true},
                new FundraisingCampaignVM(){Active = true, Sponsors = new List<InstitutionalEntity>(), ShelterId = 100000,Title="Fundraising Event " + rand.Next(100),StartDate=DateTime.Today + TimeSpan.FromDays(rand.Next(10)), FundraisingCampaignId = fundraisingCampaignId++, Description="Garble", Complete=false}
            };

            InstitutionalEntities = new List<InstitutionalEntity>()
            {
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 10,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Sponsor",
                    Email = "awesome@gmail.com",
                    FamilyName = "Money",
                    GivenName = "Made of",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 11,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 2",
                    CompanyName = "Awesome Business",
                    ContactType = "Sponsor",
                    Email = "awesome2@gmail.com",
                    FamilyName = "Money",
                    GivenName = "Made of2",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 12,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Sponsor",
                    Email = "awesome3@gmail.com",
                    FamilyName = "Money3",
                    GivenName = "Made of",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 13,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Sponsor",
                    Email = "awesome4@gmail.com",
                    FamilyName = "Money",
                    GivenName = "Made of4",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 14,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Host",
                    Email = "awesome@gmail.com",
                    FamilyName = "Meltzner",
                    GivenName = "Euguene",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 15,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Contact",
                    Email = "awesome@gmail.com",
                    FamilyName = "Energy",
                    GivenName = "Made of",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 16,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Contact",
                    Email = "awesome@gmail.com",
                    FamilyName = "Water",
                    GivenName = "Made of",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 17,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Host",
                    Email = "awesome@gmail.com",
                    FamilyName = "Honey",
                    GivenName = "Made of",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 18,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Sponsor",
                    Email = "awesome@gmail.com",
                    FamilyName = "Dirt",
                    GivenName = "Made of",
                    Phone = "1234567890"
                },
                new InstitutionalEntity()
                {
                    InstitutionalEntityId = 19,
                    Address = "123 ave. Cedar Rapids",
                    Zipcode = "52001",
                    Address2 = "Apt 1",
                    CompanyName = "Awesome Business",
                    ContactType = "Sponsor",
                    Email = "awesome@gmail.com",
                    FamilyName = "Awesomeness",
                    GivenName = "Made of",
                    Phone = "1234567890"
                }
            };

            FundraisingCampaignEntities = new List<Tuple<int, int>>()
            {
                new Tuple<int,int>(100000,10),
                new Tuple<int,int>(100000,11),
                new Tuple<int,int>(100000,13),
                new Tuple<int,int>(100000,15),
                new Tuple<int,int>(100000,14),
                new Tuple<int,int>(100000,17),
                new Tuple<int,int>(100000,18),
                new Tuple<int,int>(100000,19),
                new Tuple<int,int>(100003,10),
                new Tuple<int,int>(100003,16),
                new Tuple<int,int>(100003,12),
                new Tuple<int,int>(100004,13),
                new Tuple<int,int>(100004,12),
                new Tuple<int,int>(100004,10),
                new Tuple<int,int>(100004,17),
                new Tuple<int,int>(100005,18),
                new Tuple<int,int>(100005,10),
                new Tuple<int,int>(100005,11),
                new Tuple<int,int>(100005,12),
                new Tuple<int,int>(100005,16),
                new Tuple<int,int>(110000,10),
                new Tuple<int,int>(110000,11),
                new Tuple<int,int>(110000,13),
                new Tuple<int,int>(110000,15),
                new Tuple<int,int>(110000,14),
                new Tuple<int,int>(110000,17),
                new Tuple<int,int>(110000,18),
                new Tuple<int,int>(110000,19)
            };

            FundraisingEventEntities = new List<Tuple<int, int>>()
            {
                new Tuple<int,int>(100000,10),
                new Tuple<int,int>(100000,11),
                new Tuple<int,int>(100000,13),
                new Tuple<int,int>(100000,15),
                new Tuple<int,int>(100000,14),
                new Tuple<int,int>(100000,17),
                new Tuple<int,int>(100000,18),
                new Tuple<int,int>(100000,19),
                new Tuple<int,int>(100001,10),
                new Tuple<int,int>(100001,16),
                new Tuple<int,int>(100001,15),
                new Tuple<int,int>(100001,13),
                new Tuple<int,int>(100002,12),
                new Tuple<int,int>(100002,10),
                new Tuple<int,int>(100002,15),
                new Tuple<int,int>(100002,17),
                new Tuple<int,int>(100002,18),
                new Tuple<int,int>(100003,10),
                new Tuple<int,int>(100003,11),
                new Tuple<int,int>(100003,12),
                new Tuple<int,int>(100003,16),
                new Tuple<int,int>(100004,10),
                new Tuple<int,int>(100004,11),
                new Tuple<int,int>(100004,13),
                new Tuple<int,int>(100004,14),
                new Tuple<int,int>(100004,17),
                new Tuple<int,int>(100004,18),
                new Tuple<int,int>(100004,19)
            };
        }
    }


}
