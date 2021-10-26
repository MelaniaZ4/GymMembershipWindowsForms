using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2
{
    public partial class MembershipForm : Form
    {
        public MembershipForm()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (lastName.ForeColor == Color.Firebrick)  // change font colour back to blue when user starts typing
            {
                lastName.ForeColor = Color.SteelBlue;
            }
        }   // end of method

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MembershipForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'membershipDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.membershipDataSet.Member);

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {
            firstName.Text = "";    // delete placeholder when user clicks

        }   // end of method

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            if (firstName.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                firstName.ForeColor = Color.SteelBlue;
            }

        }   // end of method


        private void address_TextChanged(object sender, EventArgs e)
        {
            if (address.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                address.ForeColor = Color.SteelBlue;
            }
        }   // end of method

        private void emailAddress_TextChanged(object sender, EventArgs e)
        {
            if (emailAddress.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                emailAddress.ForeColor = Color.SteelBlue;

            }
        }   // end of method

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (phoneNumber.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                phoneNumber.ForeColor = Color.SteelBlue;
            }
        }   // end of method

        private void lastName_Click(object sender, EventArgs e)
        {
            lastName.Text = ""; // delete placeholder when user clicks
        }   // end of method

        private void address_Click(object sender, EventArgs e)
        {
            address.Text = "";  // delete placeholder when user clicks
        }   // end of method

        private void emailAddress_Click(object sender, EventArgs e)
        {
            emailAddress.Text = ""; // delete placeholder when user clicks
        }   // end of method

        private void phoneNumber_Click(object sender, EventArgs e)
        {
            phoneNumber.Text = "";  // delete placeholder when user clicks
        }   // end of method

        private void infoInput_Click(object sender, EventArgs e)
        {
            infoInput.Text = "";    // delete placeholder when user clicks
        }   // end of method

        private void date_Click(object sender, EventArgs e)
        {
            date.Text = ""; // delete placeholder when user clicks
        }   // end of method

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (calculateButton.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                calculateButton.ForeColor = Color.SteelBlue;
            }   // end of if-statement

            // Setting variables for membership extras
            int basicNum = 0;
            int fullAccessNum = 0;
            int trainerNum = 0;
            int consultationNum = 0;
            int videosNum = 0;

            // when clicking the calculate button, check if extra boxes are checked and change value of integers(price)
            if (extrasAccess.Checked == true)
            {
                priceAccess.Text = "$1.00";    // display price
                fullAccessNum = 1;      // update full access value
            }
            else
            {
                priceAccess.Text = "$0.00"; // display price
                fullAccessNum = 0;  // update full access value
            } //end of if-statement

            if (extrasTrainer.Checked == true)
            {
                priceTrainer.Text = "$20.00"; // display price
                trainerNum = 20;    // update trainer price value
            }
            else
            {
                priceTrainer.Text = "$0.00"; // display price
                trainerNum = 0; // update trainer price value
            } //end of if-statement

            if (extrasDietConsultation.Checked == true)
            {
                priceConsultation.Text = "$20.00";  // display price
                consultationNum = 20;   // update consultation price value
            }
            else
            {
                priceConsultation.Text = "$0.00";   // display price
                consultationNum = 0;    // update consultation price value
            } //end of if-statement

            if (extrasVideos.Checked == true)
            {
                priceVideos.Text = "$20.00";    // display price
                videosNum = 20; // update video price value
            }
            else
            {
                priceVideos.Text = "$0.00"; // display price
                videosNum = 0;     // update video price value
            } //end of if-else statement

            // check for membership selection

            if (basic.Checked == true)
            {
                priceBasic.Text = "$10.00"; // display price
                basicNum = 10;  // update membership price value
                membershipType.Text = "Basic";  // display selected membership setting

            }
            else
            {
                if (regular.Checked == true)
                {
                    priceBasic.Text = "$15.00"; // display price
                    basicNum = 15;  // update membership price value
                    membershipType.Text = "Regular";    // display selected membership setting
                }
                else
                {
                    if (premium.Checked == true)
                    {
                        priceBasic.Text = "$25.00"; // display price
                        basicNum = 25;  // update membership price value
                        fullAccessNum = 0;  // update access price value
                        priceAccess.Text = "included";  // dispay instead of price
                        videosNum = 0;  // update video price value
                        priceVideos.Text = "included";  // display instead of price
                        membershipType.Text = "Premium";    // display selected membership setting
                    }
                    else
                    {
                        priceBasic.Text = "$0.00";  // display price
                    }
                }
            } // end of if-else statement

            int membershipFeeNum = fullAccessNum + trainerNum + consultationNum + videosNum + basicNum; // calculate membership fee
            membershipFee.Text = "$" + membershipFeeNum.ToString() + ".00"; // display membership fee

            // Check for membership duration 

            int discountNum = 0;

            // if membership setting has been selected, show total fee


            if (basicNum != 0)  // if membership price value is not 0, check further conditions
            {

                if (threeMonths.Checked == true)    // if three months is selected
                {
                    durationDiscount.Text = "-$0.00";   // display membership duration discount
                    discountNum = 0;    // update discount value
                    durationDiscountLabel.Text = "3-Months Membership";   // display selected membership duration
                }
                else
                {
                    if (oneYear.Checked == true)    // if 12 months is selected
                    {
                        durationDiscount.Text = "-$2.00";   // display membership duration discount
                        discountNum = -2;   // update discount value
                        durationDiscountLabel.Text = "12-Months Membership";    // display selected membership duration
                    }
                    else
                    {
                        if (twoYears.Checked == true)   // if 24 months is selected
                        {
                            durationDiscount.Text = "-$5.00";   // display membership duration discount
                            discountNum = -5;   // update discount value
                            durationDiscountLabel.Text = "24-Months Membership"; // display selected membership duration
                        }
                    }
                } // end of if-else statement

                double totalDiscountNum = discountNum; // create variable for total discount
                totalDiscount.Text = "$" + totalDiscountNum.ToString("0.00");
                double debitDiscountNum = 0;

                double membershipFeeTotalNum = discountNum + membershipFeeNum; // calculate total membership fee

                // direct debit discount calculation and display
                if (directDebit.Checked == true) //if direct debit is selected, calculate and display membership fee including discount
                {
                    debitDiscountNum = membershipFeeNum * 0.01; // calculate discount for direct debit
                    double doubleTotalFee = membershipFeeNum - debitDiscountNum;  // subtract debit discount from total fee
                    debitDiscount.Text = "-$" + debitDiscountNum.ToString("0.00");  // display discoun for direct debit
                    totalDiscountNum = debitDiscountNum - discountNum;      // calculate total discount
                    totalDiscount.Text = "-$" + totalDiscountNum.ToString("0.00");  // display total discount
                    membershipFeeTotal.Text = "$" + doubleTotalFee.ToString("0.00");    // display total membership fee
                    directDebitLabel.Text = "Direct debit (-1%)";
                }
                if (directDebit.Checked == false)   // if direct debit is not selected, re-set discount prices to 0
                {
                    debitDiscountNum = 0;   // re-set discount value
                    directDebitLabel.Text = "Credit Card";  // display payment selection
                    debitDiscount.Text = "-$0.00";     // display discount value

                }
                else // if credit card is selected, display membership total without direct debit discount
                {
                    membershipFeeTotal.Text = "$" + membershipFeeTotalNum.ToString("0.00"); // display total membership fee
                } //end of if-else statement

                // check if monthly or weekly paymentfrequency is marked. 
                if (monthlyPayment.Checked == true) //if monthly is marked, calculate monthly fee and display it
                {
                    
                    paymentFrequencyTotal.Text = "monthly"; // display payment frequency
                    double membershipTotalMonthly = (membershipFeeTotalNum * 52.1429 / 12) - debitDiscountNum;  // calculate monthly membership fee
                    membershipFeeTotal.Text = "$" + membershipTotalMonthly.ToString("0.00");    // display monthly membership fee
                }
                else  // if weekly is marked or none, display weekly fee
                {
                    paymentFrequency1.Text = "weekly";      // display payment frequency
                    paymentFrequencyTotal.Text = "weekly";  // display payment frequency
                    double membershipTotalWeekly = membershipFeeTotalNum - debitDiscountNum;    // calculate weekly membership fee
                    membershipFeeTotal.Text = "$" + membershipTotalWeekly.ToString("0.00");     // display weekly membership fee
                } //end of if-else statement
            } 

        }   // end of method

        private void extrasAccess_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e) // exit form through exit button
        {
            if (MessageBox.Show("Are you sure you want to exit the form?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) // display dialog
            {
                this.Close();  // exit form
            }
        }   // end of method

        private void clearButton_Click(object sender, EventArgs e) // clear all information
        {
            if (MessageBox.Show("This will clear your progress. Are you sure?", "Clear", MessageBoxButtons.OKCancel) == DialogResult.OK) // display dialog
            {
                // re-set all radio buttons and tickboxes
                extrasAccess.Checked = false;
                extrasTrainer.Checked = false;
                extrasDietConsultation.Checked = false;
                extrasVideos.Checked = false;
                basic.Checked = true;
                regular.Checked = false;
                premium.Checked = false;
                termsAndConditions.Checked = false;
                monthlyPayment.Checked = false;
                weeklyPayment.Checked = true;
                creditCard.Checked = true;
                directDebit.Checked = false;
                twoYears.Checked = false;
                oneYear.Checked = false;
                threeMonths.Checked = true;
                otherGoals.Checked = false;
                weightGoal.Checked = false;
                muscleMass.Checked = false;
                strength.Checked = false;
                endurance.Checked = false;
                health.Checked = false;

                // add placeholder to textboxes
                date.Text = " dd / mm / yyyy";  
                infoInput.Text = "Additional information (e.g. injuries, health conditions...)";
                firstName.Text = " First Name";
                lastName.Text = " Last Name";
                emailAddress.Text = " Email Address";
                address.Text = " Address";
                phoneNumber.Text = " Mobile Number";
                Warning.Text = "";

                // re-set colour of textbox placehodlers to blue
                date.ForeColor = Color.SteelBlue;
                firstName.ForeColor = Color.SteelBlue;
                lastName.ForeColor = Color.SteelBlue;
                emailAddress.ForeColor = Color.SteelBlue;
                address.ForeColor = Color.SteelBlue;
                phoneNumber.ForeColor = Color.SteelBlue;
                calculateButton.ForeColor = Color.SteelBlue;
                termsAndConditions.ForeColor = Color.Black;

                // re-set all prices and labels
                priceBasic.Text = "$0.00";
                priceAccess.Text = "$0.00";
                priceConsultation.Text = "$0.00";
                priceTrainer.Text = "$0.00";
                priceVideos.Text = "$0.00";
                membershipFee.Text = "$0.00";
                membershipFeeTotal.Text = "$0.00";
                directDebitLabel.Text = "Credit Card";
                debitDiscount.Text = "-$0.00";
                totalDiscount.Text = "-$0.00";
                durationDiscount.Text = "-$0.00";
                paymentFrequencyTotal.Text = "weekly";
                durationDiscountLabel.Text = "Duration Discount";
            }   // end of method
        }

        private void button3_Click(object sender, EventArgs e) // ask for help button
        {
            //Show dialog box when user clicks 'Help'
            if (MessageBox.Show("Call 0800 888 888 to talk to an Assistant.", "Help", MessageBoxButtons.OK) == DialogResult.OK)
            {

            }
        }   // end of method

        private void submitButton_Click(object sender, EventArgs e) // submit button
        {

            // check all conditions are met to submit membership form
                if (membershipFeeTotal.Text != "$0.00" && termsAndConditions.Checked == true && firstName.Text != " First Name" && lastName.Text != " Last Name" && address.Text != " Address" && emailAddress.Text != " Email Address" && phoneNumber.Text != " Mobile Number" && date.Text != " dd / mm / yyyy" && date.Text != "" && phoneNumber.Text != "" && emailAddress.Text != "" && firstName.Text != "" && lastName.Text != "" && address.Text != "")
                {
                    Warning.Text = "";  // re-set warning text to null
                    if (MessageBox.Show("Do you want to submit your membership form?", "Submit", MessageBoxButtons.OKCancel) == DialogResult.OK)    // display dialog
                    {

                        //convert string to integer
                        int mobile;
                        if (Int32.TryParse(phoneNumber.Text, out mobile))
                        {
                            //continue
                        }
                        else
                        {
                            if (MessageBox.Show("Invalid phone number. Please type in numbers only", "Invalid Number", MessageBoxButtons.OKCancel) == DialogResult.OK) // display dialog
                            {
                                phoneNumber.ForeColor = Color.Firebrick;
                            return;
                            }
                        }

                        //convert string to date
                        string dateInput = date.Text;
                        DateTime dateConverted;
                        

                        if (DateTime.TryParse(dateInput, out dateConverted))
                        {
                        
                             
                        }
                        else
                        {
                            if (MessageBox.Show("Invalid date. Please type in a date in a valid format", "Invalid Date", MessageBoxButtons.OKCancel) == DialogResult.OK) // display dialog
                            {
                                date.ForeColor = Color.Firebrick;
                            return;
                            }
                        }

                    DateTime expiryDate = dateConverted;

                    if (threeMonths.Checked == true)
                    {
                        expiryDate = dateConverted.AddMonths(3);
                    }
                    else if (oneYear.Checked == true)
                    {
                        expiryDate = dateConverted.AddYears(1);
                    }

                    else if (twoYears.Checked == true)
                    {
                        expiryDate = dateConverted.AddYears(2);
                    }


                    //create new row in member dataset
                    MembershipDataSet.MemberRow newRow = membershipDataSet.Member.NewMemberRow();

                        //insert information from form text boxes into dataview
                        newRow.FirstName = firstName.Text;
                        newRow.LastName = lastName.Text;
                        newRow.Address = address.Text;
                        newRow.Mobile = mobile;
                        newRow.MembershipExpiry = expiryDate;
                        newRow.PaymentFrequency = paymentFrequencyTotal.Text;
                        newRow.MembershipType = membershipType.Text;

                        // check for all possible 'Extras' combinations and add text accordningly
                        if (extrasAccess.Checked == true && extrasTrainer.Checked == false && extrasDietConsultation.Checked == false && extrasVideos.Checked == false)
                        { newRow.Extras = "24/7 Access"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == true && extrasDietConsultation.Checked == false && extrasVideos.Checked == false)
                    { newRow.Extras = "Trainer"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == false && extrasDietConsultation.Checked == false && extrasVideos.Checked == true)
                        { newRow.Extras = "Videos"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == false && extrasDietConsultation.Checked == true && extrasVideos.Checked == false)
                        { newRow.Extras = "Consultation"; }
                        else if (extrasAccess.Checked == true && extrasTrainer.Checked == true && extrasDietConsultation.Checked == false && extrasVideos.Checked == false)
                        { newRow.Extras = "24/7 Access, Trainer"; }
                        else if (extrasAccess.Checked == true && extrasTrainer.Checked == false && extrasDietConsultation.Checked == false && extrasVideos.Checked == true)
                    { newRow.Extras = "24/7 Access, Videos"; }
                        else if (extrasAccess.Checked == true && extrasTrainer.Checked == false && extrasDietConsultation.Checked == true && extrasVideos.Checked == false)
                    { newRow.Extras = "24/7 Access, Consultation"; }
                        else if (extrasAccess.Checked == true && extrasTrainer.Checked == true && extrasDietConsultation.Checked == false && extrasVideos.Checked == true)
                    { newRow.Extras = "24/7 Access, Trainer, Videos"; }
                        else if (extrasAccess.Checked == true && extrasTrainer.Checked == true && extrasDietConsultation.Checked == true && extrasVideos.Checked == false)
                    { newRow.Extras = "24/7 Access, Trainer, Consultation"; }
                        else if (extrasAccess.Checked == true && extrasTrainer.Checked == false && extrasDietConsultation.Checked == true && extrasVideos.Checked == true)
                    { newRow.Extras = "24/7 Access, Consultation, Videos"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == true && extrasDietConsultation.Checked == true && extrasVideos.Checked == false)
                    { newRow.Extras = "Trainer, Consultation"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == true && extrasDietConsultation.Checked == true && extrasVideos.Checked == true)
                    { newRow.Extras = "Trainer, Consultation, Videos"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == true && extrasDietConsultation.Checked == false && extrasVideos.Checked == true)
                    { newRow.Extras = "Trainer, Videos"; }
                        else if (extrasAccess.Checked == false && extrasTrainer.Checked == false && extrasDietConsultation.Checked == true && extrasVideos.Checked == true)
                    { newRow.Extras = "Consultation, Videos"; }
                        else if (extrasAccess.Checked == true && extrasVideos.Checked == true && extrasDietConsultation.Checked == true && extrasTrainer.Checked == true)
                        { newRow.Extras = "24/7 Access, Trainer, Consultation, Videos"; }
                        else
                        { newRow.Extras = "No Extras"; }
                        // end of if-else statement

                        membershipDataSet.Member.Rows.Add(newRow);
                        this.Validate();
                        memberTableAdapter.Update(membershipDataSet.Member);

                        //refresh the view
                        this.memberTableAdapter.Fill(this.membershipDataSet.Member);

                        if (MessageBox.Show("Your membership form submission was successful. Welcome to City Gym!", "Congratulations!", MessageBoxButtons.OK) == DialogResult.OK) // display dialog
                        {
                            //show dialog to confirm successful sign up 
                        }
                    // re-set all radio buttons and tickboxes
                    extrasAccess.Checked = false;
                    extrasTrainer.Checked = false;
                    extrasDietConsultation.Checked = false;
                    extrasVideos.Checked = false;
                    basic.Checked = true;
                    regular.Checked = false;
                    premium.Checked = false;
                    termsAndConditions.Checked = false;
                    monthlyPayment.Checked = false;
                    weeklyPayment.Checked = true;
                    creditCard.Checked = true;
                    directDebit.Checked = false;
                    twoYears.Checked = false;
                    oneYear.Checked = false;
                    threeMonths.Checked = true;
                    otherGoals.Checked = false;
                    weightGoal.Checked = false;
                    muscleMass.Checked = false;
                    strength.Checked = false;
                    endurance.Checked = false;
                    health.Checked = false;

                    // add placeholder to textboxes
                    date.Text = " dd / mm / yyyy";
                    infoInput.Text = "Additional information (e.g. injuries, health conditions...)";
                    firstName.Text = " First Name";
                    lastName.Text = " Last Name";
                    emailAddress.Text = " Email Address";
                    address.Text = " Address";
                    phoneNumber.Text = " Mobile Number";
                    Warning.Text = "";

                    // re-set colour of textbox placehodlers to blue
                    date.ForeColor = Color.SteelBlue;
                    firstName.ForeColor = Color.SteelBlue;
                    lastName.ForeColor = Color.SteelBlue;
                    emailAddress.ForeColor = Color.SteelBlue;
                    address.ForeColor = Color.SteelBlue;
                    phoneNumber.ForeColor = Color.SteelBlue;
                    calculateButton.ForeColor = Color.SteelBlue;
                    termsAndConditions.ForeColor = Color.Black;

                    // re-set all prices and labels
                    priceBasic.Text = "$0.00";
                    priceAccess.Text = "$0.00";
                    priceConsultation.Text = "$0.00";
                    priceTrainer.Text = "$0.00";
                    priceVideos.Text = "$0.00";
                    membershipFee.Text = "$0.00";
                    membershipFeeTotal.Text = "$0.00";
                    directDebitLabel.Text = "Credit Card";
                    debitDiscount.Text = "-$0.00";
                    totalDiscount.Text = "-$0.00";
                    durationDiscount.Text = "-$0.00";
                    paymentFrequencyTotal.Text = "weekly";
                    durationDiscountLabel.Text = "Duration Discount";
                }


                }
                else    // check for all conditions 
                        // if conditions are not met, display warning text and highlight not filled-in required text-boxes
                {
                    Warning.Text = ""; // re-set warning text to null
                    if (firstName.Text == " First Name" | firstName.Text == "")  // if placeholder shows or text box is empty 
                    {
                        firstName.Text = " First Name"; // re-set placeholder
                        firstName.ForeColor = Color.Firebrick;
                        Warning.Text = "Please fill in and check all required boxes*";
                    }


                    if (lastName.Text == " Last Name" | lastName.Text == "") // if placeholder shows or text box is empty 
                    {
                        lastName.Text = " Last Name";   // re-set placeholder
                        lastName.ForeColor = Color.Firebrick;   // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }


                    if (address.Text == " Address" | address.Text == "") // if placeholder shows or text box is empty 
                    {
                        address.Text = " Address";  // re-set placeholder
                        address.ForeColor = Color.Firebrick;    // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }

                    if (emailAddress.Text == " Email Address" | emailAddress.Text == "")    // if placeholder shows or text box is empty 
                    {
                        emailAddress.Text = " Email Address";   // re-set placeholder
                        emailAddress.ForeColor = Color.Firebrick;   // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }

                    if (phoneNumber.Text == " Mobile Number" | phoneNumber.Text == "")  // if placeholder shows or text box is empty 
                    {
                        phoneNumber.Text = " Mobile Number";    // re-set placeholder
                        phoneNumber.ForeColor = Color.Firebrick;    // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }

                    if (date.Text == " dd / mm / yyyy" | date.Text == "")   // if placeholder shows or text box is empty 
                    {
                        date.Text = " dd / mm / yyyy";  // re-set placeholder
                        date.ForeColor = Color.Firebrick;   // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }

                    if (termsAndConditions.Checked == false)    // if terms and conditions tickbox is not checked
                    {
                        termsAndConditions.ForeColor = Color.Firebrick; // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }

                    if (membershipFeeTotal.Text == "$0.00") // if user has not calculated their latest membership fee
                    {
                        calculateButton.ForeColor = Color.Firebrick;    // highlight testbox
                        Warning.Text = "Please fill in and check all required boxes*";  // show error message
                    }
                }   // end of if-else statement

        } // end of method

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            if (date.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                date.ForeColor = Color.SteelBlue;
            }

        }   // end of method

        private void termsAndConditions_CheckedChanged(object sender, EventArgs e)
        {
            if (termsAndConditions.ForeColor == Color.Firebrick) // change font colour back to blue when user starts typing
            {
                termsAndConditions.ForeColor = Color.Black;
            }
        }   // end of method

        private void premium_CheckedChanged(object sender, EventArgs e)
        {
            if (premium.Checked == true)  // check if premium is selected
            {
                extrasAccess.Checked = true;   // set Access to checked
                extrasVideos.Checked = true;   // set Videos to checked
            }
            else     // if premium is not checked...
            {
                extrasAccess.Checked = false;   // set Access to unchecked
                extrasVideos.Checked = false;   // set Videos to unchecked
            }
        }   // end of method

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.membershipDataSet);

        } 
    }
}
