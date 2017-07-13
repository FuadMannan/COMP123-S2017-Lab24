using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Fuad Mannan
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which inherits from the SuperHuman class
 * Version: 0.2 - Added private instance variables, public properties, and constructor
 */

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperVillain class
    /// </summary>
    class SuperVillain : SuperHuman, IHasMalice
    {
        //PRIVATE INSTANCE VARIABLES
        private int _malice;

        //PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }

        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - karma (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice) : base(name)
        {
            this.Malice = malice;
        }
    }
}
