﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DataAccessLayerFakes;
using LogicLayer;
using DataObjects;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerTest
{
    /// <summary>
    /// Summary description for AnimalManagerTests
    /// </summary>
    [TestClass]
    public class AnimalManagerTests
    {
        private AnimalManager _animalManager = null;
      
        [TestInitialize]
        public void TestSetup()
        {
            //_animalManager = new AnimalManager();
            _animalManager = new AnimalManager(new AnimalAccessorFakes());
        }

      
        [TestMethod]
        public void TestRetrieveAllAnimals()
        {
            int expectedCount = 1;
            int actualCount = 0;
            string animal = "Rufus";

            var animals = _animalManager.RetrieveAllAnimals(animal);
            actualCount = animals.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void TestRetrieveAnimalByAnimalIdReturnsCorrectAnimal()
        {
            // Arrange
            const int animalId = 999998;
            const string expectedAnimalName = "Test name 2";
            string actualAnimalName = "";

            // Act
            Animal animal = _animalManager.RetrieveAnimalByAnimalId(animalId);
            actualAnimalName = animal.AnimalName;

            // Assert
            Assert.AreEqual(expectedAnimalName, actualAnimalName);
        }

        [TestMethod]
        public void TestRetrieveAllAnimalsReturnsCorrectList()
        {
            // arrange
            const int expectedCount = 6;
            int actualcount = 0;

            // act
            actualcount = _animalManager.RetrieveAllAnimals().Count;

            // assert 
            Assert.AreEqual(expectedCount, actualcount);
        }

        [TestMethod]
        public void TestRetrieveAnimalMedicalProfileByAnimalId()
        {
            //arrange 
            int animalId = 100000;
            string expectedAnimalName = "Chip";
            string actualName;

            // act
            var animal = _animalManager.RetrieveAnimalMedicalProfileByAnimalId(animalId);
            actualName = animal.AnimalName;

            // assert
            Assert.AreEqual(expectedAnimalName, actualName);

        }

    }
}
