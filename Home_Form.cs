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
    public partial class Home_Form : Form
    {
        bool twoDimentionClick = false;

        public Home_Form()
        {
            InitializeComponent();
            loading.Visible = false;
        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void single_Click(object sender, EventArgs e)
        {
            string[] arr = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thuresday", "Friday", "Saturday" };
            for (int i = 0; i < arr.Length; i++)
            {
                dayGridView.Rows.Add(arr[i]);
            }
        }

       
        private void twodimension_Click(object sender, EventArgs e)
        {
            loading.Visible = true;
            loading.Value=100;
            //loading.Visible = false;
          if (!twoDimentionClick)
            {
                string[,] arr = {
                {"1","Sunday" },
                {"2","Monday" },
                {"3","Tuesday" },
                {"4","Wednesday" },
                {"5","Thursday" },
                {"6", "Friday"},
                {"7","Sunday" }
            };

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    string[] row = new string[arr.GetLength(1)];
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        row[j] = arr[i, j];
                    }
                    noDayGridView.Rows.Add(row);
                }
                twoDimentionClick = true;
                loading.Visible=false;
            }
            else
            {
                count_lbl.Text = "Already loaded";
            }
        }

        private void loading_Click(object sender, EventArgs e)
        {

        }
    }
}
