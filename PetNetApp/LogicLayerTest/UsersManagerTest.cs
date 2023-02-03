﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicLayer;
using DataAccessLayerFakes;
using DataObjects;
using DataAccessLayerInterfaces;
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
            _userManager = new UsersManager(new UsersAccessorFakes());
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
            int actualCount = 0;

            // act
            actualCount = _userManager.RetrieveUserByRole(role).Count;

            // assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}