﻿/// <summary>
/// Chris Dreismeier
/// Created: 2023/02/09
/// 
/// 
/// Class for interation bewtween Accessor Layer and Presentaion Layer
/// </summary>
///
/// <remarks>
/// Updater Name
/// Updated: yyyy/mm/dd
/// </remarks>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using LogicLayerInterfaces;
using DataAccessLayerInterfaces;
using DataAccessLayer;
using DataAccessLayerFakes;


namespace LogicLayer
{
    public class ScheduleManager : IScheduleManager
    {
        private IScheduleAccessor _scheduleAccessor = null;
        public ScheduleManager()
        {
            _scheduleAccessor = new ScheduleAccessor();
        }

        public ScheduleManager(IScheduleAccessor scheduleAccessor)
        {
            _scheduleAccessor = scheduleAccessor;
        }



        /// <summary>
        /// Chris Dreismeier
        /// Created: 2023/02/09
        /// 
        /// Retrieves all people schedule on passed day from the accessor
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example: Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param name="selectedDate">A description of the parameter that this method takes</param>
        /// <exception cref="SQLException">Data failed to be retrieved</exception>
        /// <returns>List of Schedules</returns>	
        public List<ScheduleVM> RetrieveScheduleByDate(DateTime selectedDate)
        {
            List<ScheduleVM> schedules = null;
            try
            {
                schedules = _scheduleAccessor.SelectScheduleByDate(selectedDate);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error Retrieving schedule data.", ex);
            }
            return schedules;
        }
    }
}