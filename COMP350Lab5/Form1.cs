namespace COMP350Lab5
{
    using System.IO;

    public partial class Form1 : Form
    {

        string fileName = @"employees.csv";

        public Form1()
        {
            InitializeComponent();

            //initialize .csv file
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine("FirstName" + "," + "LastName" + "," + "DateOfBirth" + "," + "HomeAddress" + "," + "PayRate" + "," + "Hours");
            sw.Close();

        }

        //method to validate data entry before I make an object
        private bool validateData(string firstName, string lastName, string dob, string homeAddr, string payRate, string hours)
        {
            //Checking if the data is null
            if (firstName == "")
            {
                MessageBox.Show("The first name field cannot be empty");
                return false;
            }
            if (lastName == "")
            {
                MessageBox.Show("The last name field cannot be empty");
                return false;
            }
            if (dob == "")
            {
                MessageBox.Show("The date of birth field cannot be empty");
                return false;
            }
            if (homeAddr == "")
            {
                MessageBox.Show("The home address field cannot be empty");
                return false;
            }
            if (payRate == "")
            {
                MessageBox.Show("The pay rate field cannot be empty");
                return false;
            }
            if (hours == "")
            {
                MessageBox.Show("The hours worked field cannot be empty");
                return false;
            }

            //checking to make sure the string only contains letters
            foreach (char c in firstName)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("The first name field must contain only letters");
                    return false;
                }
            }
            foreach (char c in lastName)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("The last name field must contain only letters");
                    return false;
                }
            }

            //checking the date of birth for the correct format
            string[] strings = dob.Split('/');
            if (strings.Length == 3)
            {
                int intYear;
                int intMonth;
                int intDay;

                if (!int.TryParse(strings[0], out intMonth))
                {
                    MessageBox.Show("The month value must be an integer");
                    return false;
                }
                else
                {
                    if (intMonth > 12 || intMonth < 1)
                    {
                        MessageBox.Show("The month's value must be a value between 1 and 12");
                        return false;
                    }
                }
                if (!int.TryParse(strings[1], out intDay))
                {
                    MessageBox.Show("The day value must be an integer");
                    return false;
                }
                else
                {
                    if (intDay > 31 || intDay < 1)
                    {
                        MessageBox.Show("The day value must be a value between 1 and 31");
                        return false;
                    }
                }
                if (!int.TryParse(strings[2], out intYear))
                {
                    MessageBox.Show("The year value must be an integer");
                    return false;
                }
                else
                {
                    if (intYear > 99 || intYear < 0)
                    {
                        MessageBox.Show("The year value must be an integer between 00 and 99");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("the date of birth format must be mm/dd/yy");
                return false;
            }

            if (!float.TryParse(payRate, out float floatPayRate))
            {
                MessageBox.Show("The pay rate field must be an integer or a decimal number");
                return false;
            }
            if (!float.TryParse(hours, out float floatHours))
            {
                MessageBox.Show("The hours worked field must be an integer or a floating number");
                return false;
            }

            return true;
        }

        //submit button, runs validation and creates an object
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string dob = txtDob.Text;
            string homeAddr = txtHomeAddr.Text;
            string payRate = txtPayRate.Text;
            string hours = txtHours.Text;

            if (validateData(firstName, lastName, dob, homeAddr, payRate, hours))
            {
                Employee man = new Employee(firstName, lastName, dob, homeAddr, payRate, hours);
                MessageBox.Show("Successfully submitted!\n\nSaved to employees.csv");
                man.writeFile();

                txtFirstName.Clear();
                txtLastName.Clear();
                txtDob.Clear();
                txtHomeAddr.Clear();
                txtPayRate.Clear();
                txtHours.Clear();
            }


        }

        //I created a reset method to reset the .csv file
        public void resetFile()
        {
            string fileName = @"employees.csv";
            StreamWriter sz = new StreamWriter(fileName);
            sz.WriteLine("FirstName" + "," + "LastName" + "," + "DateOfBirth" + "," + "HomeAddress" + "," + "PayRate" + "," + "Hours");
            sz.Close();
        }

        //view button to show new form with the results
        private void btnView_Click(object sender, EventArgs e)
        {
            resultsForm res = new resultsForm(fileName);
            res.Show();
        }

        //reset button to reset the form and the .csv file
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetFile();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDob.Clear();
            txtHomeAddr.Clear();
            txtPayRate.Clear();
            txtHours.Clear();
            MessageBox.Show("Successfully reset");
        }
    }
}