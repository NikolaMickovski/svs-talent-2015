using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOCP.TheBad
{
    /// <summary>
    /// Real-life problem that Vets meet when deworming and tick/flea control is performed on dogs
    /// </summary>
    public class Dog
    {
        float _weight;

        public float Weight
        {
            get { return _weight; }
            private set { _weight = value; }
        }
        /// <summary>
        /// Method that checks the dog's weight and selects right medicine
        /// BUT, what if CANIDON ever makes a medicine that can be applied
        /// to dogs that weight 15-20kg (let's say CANIDONE 13mg)?
        /// Then we have to add more IF-checks and still make sure that the previous IF-s
        /// work just fine
        /// </summary>
        public void Deworm()
        {
            if ( _weight < 5 )
            {
               //use CANIDON_type1 (5mg)
            }
            if ((_weight > 5) && (_weight < 10))
            {
                //use CANIDON_type2 (10mg)
            }
            if ((_weight > 10) && (_weight < 20))
            {
                //use CANIDON_type3 (15mg)
            }
            if ( _weight > 20 )
            {
                //use CANIDON_type4 (20mg)
            }
        }
        /// <summary>
        /// Same problem goes here
        /// </summary>
        public void FleaTickControl ()
        {
            if (_weight < 5)
            {
                //use FRONTLINE Basic (5mg)
            }
            if ((_weight > 5) && (_weight < 10))
            {
                //use FRONTLINE PLUS (10mg)
            }
            if ((_weight > 10) && (_weight < 20))
            {
                //use FRONTLINE COMBO (15mg)
            }
            if (_weight > 20)
            {
                //use FRONTLINE MAX (20mg)
            }
        }

    }
}
