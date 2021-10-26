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
    public partial class ClassBooking : Form
    {
        public ClassBooking()
        {
            InitializeComponent();
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }  // end of method

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.membershipDataSet);

        }  // end of method

        private void ClassBooking_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'membershipDataSet.FitnessClass' table. You can move, or remove it, as needed.
            this.fitnessClassTableAdapter.Fill(this.membershipDataSet.FitnessClass);
            // TODO: This line of code loads data into the 'membershipDataSet.MemberClasses' table. You can move, or remove it, as needed.
            this.memberClassesTableAdapter.Fill(this.membershipDataSet.MemberClasses);
            // TODO: This line of code loads data into the 'membershipDataSet.ClassBooking' table. You can move, or remove it, as needed.
            this.classBookingTableAdapter.Fill(this.membershipDataSet.ClassBooking);
            // TODO: This line of code loads data into the 'membershipDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.membershipDataSet.Member);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Show dialog box when user clicks 'Help'
            if (MessageBox.Show("Call 0800 888 888 to talk to an Assistant.", "Help", MessageBoxButtons.OK) == DialogResult.OK)
            {

            }
        }   // end of method
    }
    }

