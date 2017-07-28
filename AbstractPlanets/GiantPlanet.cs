using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rahul Bhalla
 * Date: July 28, 2017
 * Description: This is the GiantPlanet sub class derived from Planet base Class 
 */
namespace AbstractPlanet
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //Private Instance Variables
        private string _type;


        //CONSTRUCTOR----------------------------------------------------
        /// <summary>
        /// This is a GiantPlanet constructor that takes 4 arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }
        //Public Methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}