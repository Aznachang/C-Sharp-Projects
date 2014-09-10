using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3
{
    class Vehicle
    {
        //Fields - can only be used by class 'Vehicle'
        private float m_mpg;
        private float m_tankCapacity;

        private float m_odometer;             //vehicle mileage since last mileage reset
        private float m_gasRemaining;
        private float m_MilesTotal;           //total accumulated miles of the vehicle

        //Default Constructor - not used in this program
        public Vehicle()
        {
            m_mpg = 30;
            m_tankCapacity = 16;

            m_odometer = 0;
            m_gasRemaining = m_tankCapacity;
        }
        
        //Overloaded Pass by Value Constructor
        public Vehicle(float mpg, float tankCapacity)           //Vehicle(40 mpg, 12 gallon tank)
        {
            m_mpg = mpg;                        //40
            m_tankCapacity = tankCapacity;      //12 - full tank
            
            m_odometer = 0;                     //'Miles Driven' label
            m_gasRemaining = m_tankCapacity;    //Initially IT IS FULL TANK
            m_MilesTotal = 0;
        }

        //Properties - to return private member variables INTO BOTH Textboxes
        public float Odometer               //miles driven = intially 0 (odometer)
        {
            get { return m_odometer; }
            set { m_odometer = value; }
        }

        public float mpg
        {
            get { return m_mpg; }
            set { m_mpg = value; }
        }

        public float GasRemaining           //gallons of gas - tankCapacity
        {
            get { return m_gasRemaining;  }
            set { m_gasRemaining = value; }
        }
        
        public float MilesTotal
        {
            get { return m_MilesTotal; }
            set { m_MilesTotal = value; }
        }

        /*Method -takes as input the number of miles to be driven and then
        increments the m_odometer and decrements the m_gasRemaining variables accordingly.
        Hint: If a vehicle with a mileage of 40 mpg drives 10 miles,
        its gas remaining will decrease by a quarter gallon (10 miles / 40 mpg = 0.25 gallons).
        Its odometer will increase by 10 miles.
         */ 

        public void Drive(float milesToDrive)
        {
           m_gasRemaining -= (milesToDrive/m_mpg);
           m_odometer += milesToDrive;
           m_MilesTotal += milesToDrive;
        }

        //Fill Up Gas - Gas left to Full
        public void FillGas()
        {    
            m_gasRemaining = m_tankCapacity;    //12 - from constructor
        }

        //Reset Miles Driven Textbox
        public void ResetMilesDriven()
        {
            m_odometer = 0;
        }
    }
}
