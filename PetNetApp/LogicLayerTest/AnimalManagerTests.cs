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

        [TestCleanup]
        public void testTearDown()
        {
            _animalManager = null;
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
        public void TestRetrieveAllAnimalBreeds()
        {
            // Arrange
            int expectedCount = 2;
            int actualCount = 0;

            // Act
            var animals = _animalManager.RetrieveAllAnimalBreeds();
            actualCount = animals.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void TestRetrieveAllAnimalGenders()
        {
            // Arrange
            int expectedCount = 2;
            int actualCount = 0;

            // Act
            var animals = _animalManager.RetrieveAllAnimalGenders();
            actualCount = animals.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void TestRetrieveAllAnimalTypes()
        {
            // Arrange
            int expectedCount = 2;
            int actualCount = 0;

            // Act
            var animals = _animalManager.RetrieveAllAnimalTypes();
            actualCount = animals.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void TestRetrieveAllAnimalStatuses()
        {
            // Arrange
            int expectedCount = 2;
            int actualCount = 0;

            // Act
            var animals = _animalManager.RetrieveAllAnimalStatuses();
            actualCount = animals.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void TestUpdateAnimalWorksWithCorrectData()
        {
            // Arrange
            AnimalVM oldAnimal = _animalManager.RetrieveAnimalByAnimalId(999997);
            AnimalVM newAnimal = new AnimalVM
            {
                AnimalId = 999997,
                AnimalName = "Test name 3",
                AnimalGender = "Test gender 3",
                AnimalTypeId = "Test type 3",
                AnimalBreedId = "Test breed 3",
                KennelName = "Test kennel 1",
                Personality = "Test personality 3",
                Description = "Test description 3",
                AnimalStatusId = "Test status 3",
                AnimalStatusDescription = "Test status description 3",
                BroughtIn = DateTime.Parse("2023-06-03"),
                MicrochipNumber = "Test SN",
                Aggressive = false,
                AggressiveDescription = "Not aggressive",
                ChildFriendly = true,
                NeuterStatus = true,
                Notes = "new notes"
            };

            // Act
            bool actualResult = _animalManager.EditAnimal(oldAnimal, newAnimal);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestUpdateAnimalFailsWithBadData()
        {
            // Arrange
            AnimalVM badAnimal = new AnimalVM
            {
                AnimalId = 899997,
                AnimalName = "Test name 3",
                AnimalGender = "Test gender 3",
                AnimalTypeId = "Test type 3",
                AnimalBreedId = "Test breed 3",
                KennelName = "Test kennel 1",
                Personality = "Test personality 3",
                Description = "Test description 3",
                AnimalStatusId = "Test status 3",
                AnimalStatusDescription = "Test status description 3",
                BroughtIn = DateTime.Parse("2023-06-03"),
                MicrochipNumber = "Test SN",
                Aggressive = false,
                AggressiveDescription = "Not aggressive",
                ChildFriendly = true,
                NeuterStatus = true,
                Notes = "new notes"
            };
            AnimalVM newAnimal = badAnimal;

            // Act
            bool actualResult = _animalManager.EditAnimal(badAnimal, newAnimal);

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}