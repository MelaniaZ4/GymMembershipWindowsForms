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
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.membershipDataSet);

        }

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
            //int selectedrowcount = this.fitnessclassdatagridview.selectedrows.count;

            //// get the current student
            //datarowview currentmemberrecord = memberbindingsource.current as datarowview;
            //// get the id of the current student
            //int currentmemberid = (int)currentmemberrecord[0];

            //for (int i = 0; i < selectedrowcount; i++)
            //{
            //    // getting the data from the selected class
            //    datarowview classdrv = fitnessclassdatagridview.selectedrows[i].databounditem as datarowview;
            //    // getting the courseid
            //    int classid = (int)classdrv[0];

            //    // create row object 
            //    membershipdataset.classbookingrow newclassbookingrow = membershipdataset.classbooking.newclassbookingrow();
            //    // assign values for studentid and courseid
            //    // the studentcourse primary key will autoincrement.
            //    newclassbookingrow.memberid = currentmemberid;
            //    newclassbookingrow.classid = classid;
            //    // insert into dataset
            //    membershipdataset.classbooking.rows.add(newclassbookingrow);
            //} // end of our loop

            //// commit to db using the table adapter manager
            //this.validate();
            //this.tableadaptermanager.updateall(membershipdataset);

            ////refresh member classes  to update the datagridview for the user.
            //this.memberclassestableadapter.fill(this.membershipdataset.memberclasses);
        }
    }
}
