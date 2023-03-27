﻿using DataAccessLayerInterfaces;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VolunteerAccessor : IVolunteerAccessor
    {
        public List<VolunteerVM> SelectVolunteersbyFundraisingEventId(int fundraisingEventId)
        {
            List<VolunteerVM> volunteers = new List<VolunteerVM>();

            var conn = new DBConnection().GetConnection();

            var cmdtext = "sp_select_volunteers_by_fundraising_event_id";

            var cmd = new SqlCommand(cmdtext, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FundraisingEventId", SqlDbType.Int);
            cmd.Parameters["@FundraisingEventId"].Value = fundraisingEventId;

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        VolunteerVM volunteer = new VolunteerVM();
                        volunteer.FundraisingEventId = reader.GetInt32(0);
                        volunteer.UsersId = reader.GetInt32(1);
                        volunteer.GivenName = reader.GetString(2);
                        volunteer.FamilyName = reader.GetString(3);

                        volunteers.Add(volunteer);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return volunteers;
        }
    }
}