using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the form?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) // display dialog
            {
                this.Close();  // exit form
            }
        }   // end of method
       

        private void SearchMemberButton_Click(object sender, EventArgs e)
        {
            new filterButton().Show();
        }  // end of method

        private void BookClassButton_Click(object sender, EventArgs e)
        {
            new ClassBooking().Show();
        }  // end of method

        private void SignUpFormButton_Click(object sender, EventArgs e)
        {
            new MembershipForm().Show();
        }  // end of method

        private void button3_Click(object sender, EventArgs e)
        {
            //Show dialog box when user clicks 'Help'
            if (MessageBox.Show("Call 0800 888 888 to talk to an Assistant.", "Help", MessageBoxButtons.OK) == DialogResult.OK)
            {

            }
        }   // end of method
    }
    }
