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
    public partial class InputBox : Form
    {
        private float m_theInput;

        //allow outside code to access private member 'm_theInput'
        public float InputValue
        {
            get { return m_theInput; }  //have access to the 'Input' variable
        }

        public InputBox()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            //check if input data type is valid - only numerical input allowed
            try 
            {
                m_theInput = float.Parse(txtInput.Text);        //Miles To Drive = User Input in TextBox 
            }

            catch (FormatException msg)
            {
                MessageBox.Show("Invalid Data Type: " + msg.Message);
            }
            
            //check if the user inputs BLANK miles
            if (txtInput.Text.Trim() == "")
            {
                MessageBox.Show("Must enter miles you will drive!");
                return;
            }
            
            else if (float.Parse(txtInput.Text) <=0.0)
            {
                 MessageBox.Show("Must enter positive number of miles!");
                 return;
            }

            else
            {
                 this.Close();
            }           
        }
    }
}
