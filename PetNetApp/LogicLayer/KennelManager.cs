﻿using DataAccessLayer;
using DataAccessLayerInterfaces;
using DataObjects;
using LogicLayerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerFakes;

namespace LogicLayer
{
    public class KennelManager : IKennelManager
    {
        private IKennelAccessor kennelAccessor = null;

        public KennelManager()
        {
            kennelAccessor = new KennelAccessor();
        }

        public KennelManager(IKennelAccessor ka)
        {
            kennelAccessor = ka;
        }

        /// <summary>
        /// Gwen Arman
        /// Created: 2023/02/01
        /// 
        /// Methods rewraps SelectKennels method
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example: Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param name="ShelterId">A description of the parameter that this method takes</param>
        /// <exception cref="ApplicationException"></exception>
        /// <returns>List<KennelVM></returns>
        public List<KennelVM> RetrieveKennels(int ShelterId)
        {
            try
            {
                return kennelAccessor.SelectKennels(ShelterId);
            }
            catch (Exception e)
            {
                throw new ApplicationException("Failed to retrieve kennels", e);
            }
                      
        }

        public Kennel RetrieveKennelIdByAnimalId(int AnimalId)
        {
            try
            {
                return kennelAccessor.SelectKennelIdByAnimalId(AnimalId);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to retrieve kennel", ex);
            }
        }

        public bool AddAnimalIntoKennelByAnimalId(int KennelId, int AnimalId)
        {
            try
            {
                return 0 < kennelAccessor.InsertAnimalIntoKennelByAnimalId(KennelId, AnimalId);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Failed to insert animal into kennel", ex);
            }
        }

        public List<Animal> RetrieveAllAnimalsForKennel()
        {
            try
            {
                return kennelAccessor.SelectAllAnimalsForKennel();
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Failed to retrieve animals.", ex);
            }
        }
    }
}
