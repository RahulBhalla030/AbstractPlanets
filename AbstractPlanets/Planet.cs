using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rahul Bhalla
 * Date: July 28, 2017
 * Description: This is the abstract class Planet which other subclasses will
 * derive from.
 */
namespace AbstractPlanet
{
    /// <summary>
    /// This is the abstract Class
    /// </summary>
    public abstract class Planet
    {
        //Private Fields(Instance Variables)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //Public Properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }

        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }

        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructors
        /// <summary>
        /// This is the constructor for the Planet abstract class. 
        /// It requires three parameter - name(string), diameter(double) and mass(double).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;

        }
        //Public Methods
        /// <summary>
        /// Overridden the built-in ToString Method
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
        public override string ToString()
        {
            return string.Format(" Name of the planet : {0} ~ Diameter : {1}kms ~ Mass : {2}kgs", Name, Diameter, Mass);
        }

    }
}