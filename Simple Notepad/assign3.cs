using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assign3
{
    public partial class assign3 : Form
    {
        //Hold Instance of 'Vehicle' object
        private Vehicle m_myVehicle;

        public assign3()
        {
            InitializeComponent();
        }

        private void assign3_Load(object sender, EventArgs e)
        {
            m_myVehicle = new Vehicle(40, 12);          //non-default constructor: Vehicle(mpg, tank capacity - in gallons)

            //Call properties
            txtMiles.Text = m_myVehicle.Odometer.ToString();            //vehicle mileage since last mileage reset
            txtGas.Text = m_myVehicle.GasRemaining.ToString();          
            txtMilesTotal.Text = m_myVehicle.MilesTotal.ToString();     //Total accumulated miles of the vehicle
        } 

        private void btnDrive_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox();
            input.ShowDialog();                         //Opens up the 2nd Form
            float milesToDrive = input.InputValue;      //Miles Driven = 2nd Form Input Value  

            if (milesToDrive > (m_myVehicle.GasRemaining * m_myVehicle.mpg))
            {
                MessageBox.Show("You cannot drive " + milesToDrive + " miles for the remaining " + m_myVehicle.GasRemaining + " gallons of gas!");
            }

            else
            {
                m_myVehicle.Drive(milesToDrive);            //Method to calculate mileage driven and remaining gas (in gallons)
                //Call properties to set to Textboxes for display - Limit to 1 DECIMAL Point
                txtMiles.Text = String.Format("{0:#0.0}", m_myVehicle.Odometer);        
                txtGas.Text = String.Format("{0:#0.000}", m_myVehicle.GasRemaining);
                txtMilesTotal.Text = String.Format("{0:#0.0}", m_myVehicle.MilesTotal);
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            m_myVehicle.FillGas();
            //Call properties
            txtGas.Text = m_myVehicle.GasRemaining.ToString();
        }

        private void btnResetMiles_Click(object sender, EventArgs e)
        {
            m_myVehicle.ResetMilesDriven();
            txtMiles.Text = m_myVehicle.Odometer.ToString();
        }

    }
}
