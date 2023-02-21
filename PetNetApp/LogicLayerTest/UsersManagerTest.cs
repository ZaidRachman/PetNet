﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataAccessLayer;
using DataObjects;
using LogicLayer;
using DataAccessLayerInterfaces;
using DataAccessLayerFakes;
using System.Collections.Generic;
using LogicLayerInterfaces;


namespace LogicLayerTest
{
    [TestClass]
    public class UsersManagerTest
    {
        private IUsersManager _userManager = null;


        [TestInitialize]
        public void TestSetup()
        {
            _userManager = new UsersManager(new UsersAccessorFakes()); // Fake Data
            // _userManager = new UsersManager(new UsersAccessor()); // Actual Data
        }

        [TestCleanup]
        public void TestTearDown()
        {
            _userManager = null;
        }


        [TestMethod]
        public void TestRetrieveUserByRole()
        {
            // arrange
            const int expectedCount = 3;
            string role = "Volunteer";
            int shelterId = 1;
            int actualCount = 0;

            // act
            actualCount = _userManager.RetrieveUserByRole(role,shelterId).Count;

            // assert
            Assert.AreEqual(expectedCount, actualCount);


        }

        [TestMethod]
        public void TestSelectAllEmployee()
        {
            List<UsersVM> listUser = null;
            listUser = _userManager.RetriveAllEmployees();

            int actualResult = listUser.Count;
            int expectedResult = 4;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestDeactivateAccount()
        {
            //arrage 
            int userId = 1000;
            bool expectedResult = true;
            bool actualResult = false;

            //act 
            actualResult = _userManager.DeactivateUserAccount(userId);

            //assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestCreateUser() 
        {
            //arrage 
            bool actualResult = false;

            //act 
            actualResult = _userManager.AddUser(new Users(), "fakePassword");

            //assert
            Assert.IsTrue(actualResult); 

        }

    }
}
