﻿using DataAccessLayer;
using DataAccessLayerInterfaces;
using DataObjects;
using LogicLayerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class TestManager : ITestManager
    {
        private ITestAccessor _testAccessor;
        public TestManager()
        {
            _testAccessor = new TestAccessor();
        }
        public TestManager(ITestAccessor testAccessor)
        {
            _testAccessor = testAccessor;
        }
        public List<Test> RetrieveTestsByAnimalId(int animalId)
        {
            try
            {
                return _testAccessor.SelectTestsByAnimalId(animalId);
            }
            catch (Exception up)
            {
                throw new ApplicationException("Failed to load Tests", up);
            }
        }
    }
}