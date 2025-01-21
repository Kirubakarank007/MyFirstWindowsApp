using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp
{
    public partial class login_form : Form
    {
        bool check_username = true;
        bool check_choose_day;
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTime_Picker.Value = DateTime.Now;

        }

        private void login_Button(object sender, EventArgs e)
        {
            string userName = userName_Input.Text;
            string password = password_Input.Text;
            if (!check_choose_day)
            {
                MessageBox.Show("Choossee your day");

            }
            else if (loginday_Combobox.Text == "Sunday" || loginday_Combobox.Text == "Saturday")
            {
                MessageBox.Show("You login in holidays");
            }
            else if (userName == "" && password == "")
            {
                MessageBox.Show("please enter username and password");
            }
            else if (userName == "" || password == "")
            {
                if (password == "")
                {
                    MessageBox.Show("Please enter password");
                }
                else
                {
                    MessageBox.Show("Please enter username");
                }
            }
            else if (!termsCheck.Checked)
            {
                MessageBox.Show("Check the terms and condition", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show(userName + password, "confirmation", buttons, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    Home_Form home_Form = new Home_Form();
                    home_Form.welcome_label.Text += userName_Input.Text;
                    home_Form.Show();
                }
                else
                {
                    //do nothing
                }
            }


        }

        private void phone_number_Key_press(object sender, KeyPressEventArgs e)
        {
            if (!check_username)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf(".") > -1)
                {
                    e.Handled = true;
                }
            }
        }



        private void username_check(object sender, EventArgs e)
        {
            MessageBox.Show("only you can enter username", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            check_username = true;
            userName_Input.Text = "";
        }

        private void phoneNumber_check(object sender, EventArgs e)
        {
            MessageBox.Show("only you can enter phoneNumber", "confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            check_username = false;
            userName_Input.Text = "";
        }

        private void day_choose(object sender, EventArgs e)
        {
            check_choose_day = true;
        }

        private void calculate_Dob(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int d = dateTime_Picker.Value.Year;
            int res = (currentYear - d);
            MessageBox.Show("Your age is " + res);
        }
    }
}
