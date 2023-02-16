﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayerInterfaces;

namespace DataAccessLayerFakes
{
    public class RoleAccessorFake : IRoleAccessor
    {

        private List<Role> _fakeRoles = new List<Role>();

        /// <summary>
        /// This is the list of roles to popluate combo box
        /// </summary>
        public RoleAccessorFake()
        {
            _fakeRoles.Add(new Role()
            {
                RoleId = "Admin",
                Description = "Underpaid serf."
            });
            _fakeRoles.Add(new Role()
            {
                RoleId = "Volunteer",
                Description = "Work for free."
            });
        }

        public int InsertRoleByUsersId(Role role, int usersId)
        {
            //throw new NotImplementedException();

            int result = _fakeRoles.Count;

            try
            {
                _fakeRoles.Add(new Role()
                {
                    RoleId = role.RoleId,
                    Description = usersId.ToString()
                });
                result = _fakeRoles.Count - result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public List<Role> SelectAllRoles()
        {
            // red test
            //throw new NotImplementedException();
            // green test
            return _fakeRoles;
        }

        public List<Role> SelectAllRolesByUserId(int userID)
        {
            //red test
            //throw new NotImplementedException();
            return _fakeRoles;
        }

    }
}
