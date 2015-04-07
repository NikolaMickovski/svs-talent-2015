using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DogLovers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    /// <summary>
    /// Klasa koja go implentira interfejsot IDOG
    /// </summary>
    public class Dog : IDog
    {
        /// <summary>
        /// Metod koj vraka lista od DogID koj podocna ke bide prikazana vo GRIDVIEW
        /// </summary>
        /// <returns></returns>
        public List<DogID> GetListOfDogs()
        {
            List<DogID> ListOfDogs = new List<DogID> ()
            {
                new DogID{Name="Pance", OwnerName="Nikola", OwnerLastName="Mickovski",MicroChip=123423499,Born=new DateTime(2012,4,13),Breed="Pekinezer"},
                new DogID{Name="Kuce1-Ime", OwnerName="Ivana", OwnerLastName="Andonova",MicroChip=233444332,Born=new DateTime(2013,12,9),Breed="Terier"},
                new DogID{Name="Ava", OwnerName="Orce", OwnerLastName="Markovski",MicroChip=989798,Born=new DateTime(2014,9,12),Breed="Terier"}
            };

            return ListOfDogs;         
        }
        /// <summary>
        /// Compatible match is when dogs are of same breed and
        /// are +/- one year birth difference
        /// </summary>
        /// <param name="a">vlez - kuce 1</param>
        /// <param name="b">vlez - kuce 2</param>
        /// <returns></returns>
        public bool CompatibleMatch(DogID a, DogID b)
        {
            if (a.Breed.Equals(b.Breed) && Math.Abs((a.Born - b.Born).TotalDays)<365 )
                return true;
            else 
                return false;
        }

        /// <summary>
        /// Metod koj kompatibilnosta na kucinjata ja vrsi samo spored
        /// nivnata rasa i starost
        /// </summary>
        /// <param name="breed1">rasa na prvoto kuce</param>
        /// <param name="day1">rodenden na prvoto kuce</param>
        /// <param name="breed2">rasa na vtoroto kuce</param>
        /// <param name="day2">rodeden na vtoroto kuce</param>
        /// <returns></returns>
        public bool CompatibleMatchByBreedAndBirth(string breed1, DateTime day1, string breed2, DateTime day2)
        {
            if (breed1.Equals(breed2) && Math.Abs((day1 - day2).TotalDays) <= 365)
                return true;
            else
                return false;
        }
    }
}
