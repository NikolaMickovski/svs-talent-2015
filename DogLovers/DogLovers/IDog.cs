using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DogLovers
{
    //Interface koj ima dva metodi i ja igra glavnata uloga na servis

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDog
    {
        // TODO: Add your service operations here
        /// <summary>
        /// Metod koj treba da vrati lista od kucinja od nekoja zamislena baza
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<DogID> GetListOfDogs();

        /// <summary>
        /// Metod koj proveruva kompatibilnost za parenje so
        /// vlezni argumenti objekti od klasata DogID
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [OperationContract]
        bool CompatibleMatch(DogID a, DogID b);

        /// <summary>
        /// Metod koj kompatibilnosta na kucinjata ja vrsi samo spored
        /// nivnata rasa i starost
        /// </summary>
        /// <param name="breed1">rasa na prvoto kuce</param>
        /// <param name="day1">rodenden na prvoto kuce</param>
        /// <param name="breed2">rasa na vtoroto kuce</param>
        /// <param name="day2">rodeden na vtoroto kuce</param>
        /// <returns></returns>
        [OperationContract]
        bool CompatibleMatchByBreedAndBirth(string breed1, DateTime day1, string breed2, DateTime day2);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "DogLovers.ContractType".
    
}
