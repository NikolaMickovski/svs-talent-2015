using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace DogLovers
{
    /// <summary>
    /// Klasa koja ke opisuva DOG:
    /// Ime i Prezime na sopstvenik
    /// Broj na Microchip na kuceto
    /// Mesec i godina na raganje
    /// rasa
    /// </summary>
    [DataContract(Name="DOG ID")]
    public class DogID
    {
        private string name;        
        public string ownerName;
        public string ownerLastName;
        public long microChip;
        public DateTime born;
        public string breed;

        #region DATA MEMBERS

        [DataMember(IsRequired=true,Name="DogBreed")]
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        [DataMember(IsRequired = true, Name = "Month/Year of Birth")]
        public DateTime Born
        {
            get { return born; }
            set { born = value; }
        }
        [DataMember(IsRequired = true, Name = "Microchip Number")]
        public long MicroChip
        {
            get { return microChip; }
            set { microChip = value; }
        }
        [DataMember(IsRequired = true, Name = "Owner's lastname")]
        public string OwnerLastName
        {
            get { return ownerLastName; }
            set { ownerLastName = value; }
        }
        [DataMember(IsRequired = true, Name = "Owner's firstname")]
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

    }
}
