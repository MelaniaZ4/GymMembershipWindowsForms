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
            this.Close();
        }

        private void SearchMemberButton_Click(object sender, EventArgs e)
        {
            new filterButton().Show();
        }

        private void BookClassButton_Click(object sender, EventArgs e)
        {
            new ClassBooking().Show();
        }

        private void SignUpFormButton_Click(object sender, EventArgs e)
        {
            new MembershipForm().Show();
        }
    }
}
