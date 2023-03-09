﻿using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerInterfaces
{
    public interface IAnimalManager
    {
        /// <summary>
        /// John
        /// Created: N/A
        /// 
        /// Adds animal profile record to the database
        /// </summary>
        ///
        /// <remarks>
        /// Andrew Schneider
        /// Updated: 2023/02/18
        /// Added shelter Id
        /// </remarks>
        /// <param name="animal">The animal VM object to be added</param>
        /// <exception cref="ApplicationException">Add Fails</exception>
        /// <returns>Boolean representing success or failure</returns>
        bool AddAnimal(AnimalVM animal);
        List<Animal> RetrieveAllAnimals(String animalName);
        /// <summary>
        /// Andrew Schneider
        /// Created: 2023/02/02
        /// 
        /// Retrieves an animal VM by animal Id and shelter Id
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example:  Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param name="animalId">The animal Id of the animal VM to be returned</param>
        /// <param name="shelterId">The shelter Id of the animal VM to be returned</param>
        /// <exception cref="ApplicationException">Retrieval Fails</exception>
        /// <returns>AnimalVM</returns>
        AnimalVM RetrieveAnimalByAnimalId(int animalId, int shelterId);

        // For populating edit animal profile combo boxes 
        /// <summary>
        /// Andrew Schneider
        /// Created: 2023/02/08
        /// 
        /// Retrieves all animal breeds and their associated animal types to
        /// populate add/edit animal profile combo boxes
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example:  Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param>No parameters</param>
        /// <exception cref="ApplicationException">Retrieval Fails</exception>
        /// <returns>A dictionary of two strings, the breed and the type</returns>
        Dictionary<string, List<string>> RetrieveAllAnimalBreeds();
        /// <summary>
        /// Andrew Schneider
        /// Created: 2023/02/08
        /// 
        /// Retrieves all animal genders to populate add/edit animal profile combo boxes
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example:  Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param>No parameters</param>
        /// <exception cref="ApplicationException">Retrieval Fails</exception>
        /// <returns>A  list of all animal genders</returns>
        List<string> RetrieveAllAnimalGenders();
        /// <summary>
        /// Andrew Schneider
        /// Created: 2023/02/08
        /// 
        /// Retrieves all animal statuses to populate add/edit animal profile combo boxes
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example:  Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param>No parameters</param>
        /// <exception cref="ApplicationException">Retrieval Fails</exception>
        /// <returns>A  list of all animal statuses</returns>
        List<string> RetrieveAllAnimalStatuses();
        /// <summary>
        /// Andrew Schneider
        /// Created: 2023/02/08
        /// 
        /// Retrieves all animal types to populate add/edit animal profile combo boxes
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example:  Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param>No parameters</param>
        /// <exception cref="ApplicationException">Retrieval Fails</exception>
        /// <returns>A  list of all animal types</returns>
        List<string> RetrieveAllAnimalTypes();

        /// <summary>
        /// Andrew Schneider
        /// Created: 2023/02/09
        /// 
        /// Edits an animal profile record using an "old" animal VM
        /// object and a "new" edited animal VM object
        /// </summary>
        ///
        /// <remarks>
        /// Updater Name
        /// Updated: yyyy/mm/dd
        /// example:  Fixed a problem when user inputs bad data
        /// </remarks>
        /// <param name="oldAnimal">AnimalVM object holding old data</param>
        /// <param name="newAnimal">AnimalVM object holding new edited data</param>
        /// <exception cref="ApplicationException">Update Fails</exception>
        /// <returns>Boolean representing success or failure</returns>
        bool EditAnimal(AnimalVM oldAnimal, AnimalVM newAnimal);
        List<Animal> RetrieveAllAnimals(int shelterId);
        AnimalVM RetrieveAnimalMedicalProfileByAnimalId(int AnimalId);

        AnimalVM RetriveAnimalAdoptableProfile(int animalId);

        List<AnimalVM> RetriveAdoptedAnimalByUserId(int userId);
        FosterPlacementRecord RetriveFosterPlacementRecordNotes(int animalId);
    }
}
