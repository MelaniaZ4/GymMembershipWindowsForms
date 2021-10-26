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
    public partial class filterButton : Form
    {
        public filterButton()
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

        private void MemberSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membershipDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.membershipDataSet.Member);

        }  // end of method

        public void SearchMemberButton_Click(object sender, EventArgs e)
        {
            //Filter datagrid view for specific members

            //Creating a dataview 
            DataView memberDataView = new DataView(membershipDataSet.Member);

            //A filter over first and last name
            // create the filter string
            string filter = "";

            filter = "[FirstName] LIKE '" + SearchInput.Text + "*'";
            filter += " OR[LastName] LIKE '" + SearchInput.Text + "*'";
            filter += " OR[FirstName] + ' ' + [LastName] LIKE '" + SearchInput.Text + "*'";

            // apply filter 
            memberDataView.RowFilter = filter;

            //Use DataView as the DataSource for the GridView
            memberDataGridView.DataSource = memberDataView;
        }  // end of method

        private void ClearGridButton_Click(object sender, EventArgs e)
        {
            //Set the DataSource for the GridView to the full Student dataset.
            memberDataGridView.DataSource = membershipDataSet.Member;
            SearchInput.Text = "";
            basicFilter.Checked = false;
            regularFilter.Checked = false;
            premiumFilter.Checked = false;
        }  // end of method

        private void button1_Click(object sender, EventArgs e)
        {

            if (basicFilter.Checked == true) //user filters for 'Basic'
            {
                //Creating a dataview 
                DataView membershipDataView = new DataView(membershipDataSet.Member);

                //A filter over membershiptype
                // create the filter string
                string membershipFilter = "[MembershipType] LIKE '" + basicFilter.Text + "*'";

                // apply filter 
                membershipDataView.RowFilter = membershipFilter;

                //Use DataView as the DataSource for the GridView
                memberDataGridView.DataSource = membershipDataView;
            }
            else
            {
                if (regularFilter.Checked == true) //user filters for 'Regular'
                {
                    //Creating a dataview 
                    DataView membershipDataView = new DataView(membershipDataSet.Member);

                    //A filter over membershiptype
                    // create the filter string
                    string membershipFilter = "[MembershipType] LIKE '" + regularFilter.Text + "*'";
                    // apply filter 
                    membershipDataView.RowFilter = membershipFilter;

                    //Use DataView as the DataSource for the GridView
                    memberDataGridView.DataSource = membershipDataView;
                }
                else
                {
                    if (premiumFilter.Checked == true) //user filters for 'Premium'
                    {
                        //Creating a dataview 
                        DataView membershipDataView = new DataView(membershipDataSet.Member);

                        //A filter over membershiptype
                        // create the filter string
                        string membershipFilter = "[MembershipType] LIKE '" + premiumFilter.Text + "*'";
                        // apply filter 
                        membershipDataView.RowFilter = membershipFilter;

                        //Use DataView as the DataSource for the GridView
                        memberDataGridView.DataSource = membershipDataView;
                    }
                }

            }  // end of if-else statement
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

