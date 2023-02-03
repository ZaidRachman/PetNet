﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using LogicLayerInterfaces;
using DataAccessLayerInterfaces;
using DataAccessLayer;
using DataAccessLayerFakes;
using System.Security.Cryptography;

namespace LogicLayer
{
    public class UsersManager : IUsersManager
    {
        
        IUsersAccessor _userAccessor;

        public UsersManager()
        {
            _userAccessor = new UsersAccessor();
        }

        public UsersManager(IUsersAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }


        /// <summary>
        /// Chris Dreismeier
        /// Created: 2023/03/02
        /// 
        /// 
        /// </summary>
        /// Retrieves all users with a certain role
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd 
        /// example: Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param name="RoleId"></param>
        public List<UsersVM> RetrieveUserByRole(string RoleId)
        {
            List<UsersVM> users = new List<UsersVM>();

            try
            {
                users = _userAccessor.SelectUserByRole(RoleId);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return users;
        }
    }
}