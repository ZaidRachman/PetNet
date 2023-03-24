﻿using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerInterfaces
{
    public interface IDonationManager
    {
        /// <summary>
        /// Author: Gwen Arman
        /// Date: 2023/03/02
        /// Description: Retrieves donations by ShelterId
        /// </summary>
        /// <param name="ShelterId"></param>
        /// <returns></returns>
        List<DonationVM> RetrieveDonationsByShelterId(int ShelterId);
        /// <summary>
        /// Author: Gwen Arman
        /// Date: 2023/03/02
        /// Description: Retrieves all donations
        /// </summary>
        /// <returns></returns>
        List<DonationVM> RetrieveAllDonations();
        /// <summary>
        /// Author: Gwen Arman
        /// Date: 2023/03/02
        /// Description: Retrieves inkinds by donationsId
        /// </summary>
        /// <param name="donationId"></param>
        /// <returns></returns>
        List<InKind> RetrieveInKindsByDonationId(int donationId);
        /// <summary>
        /// Author: Gwen Arman
        /// Date: 2023/03/02
        /// Description: Retrieves donation by donationsId
        /// </summary>
        /// <param name="donationId"></param>
        /// <returns></returns>
        DonationVM RetrieveDonationByDonationId(int donationId);
        /// <summary>
        /// Barry Mikulas
        /// Created: 2023/03/17
        /// Retrieves donations by fundraising eventId
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        List<DonationVM> RetrieveDonationsByEventId(int eventId);
        /// <summary>
        /// Barry Mikulas
        /// Created: 2023/03/17
        /// Retrieves a sum of the donation amounts by fundraising eventId
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        decimal RetrieveSumDonationsByEventId(int eventId);
    }
}
