using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Number
{
    public partial class Luck_Number : Form
    {
        public Luck_Number()
        {
            InitializeComponent();
        }

        private void Luck_Number_Load(object sender, EventArgs e)
        {
            ComboBox Month = new ComboBox();

            // creates, populates, and loads Combo box programically

            Month.Items.Add("January");
            Month.Items.Add("February");
            Month.Items.Add("March");
            Month.Items.Add("April");
            Month.Items.Add("May");
            Month.Items.Add("June");
            Month.Items.Add("July");
            Month.Items.Add("August");
            Month.Items.Add("September");
            Month.Items.Add("October");
            Month.Items.Add("November");
            Month.Items.Add("December");

            this.Controls.Add(Month);

           if (Month.Items.Contains("July")) // Populates Days combo box based on another combo box
            {
                Days.Items.Add(1);
                Days.Items.Add(2);
                Days.Items.Add(3);
                Days.Items.Add(4);
                Days.Items.Add(5);
                Days.Items.Add(6);
                Days.Items.Add(7);
                Days.Items.Add(8);
                Days.Items.Add(9);
                Days.Items.Add(10);
                Days.Items.Add(11);
                Days.Items.Add(12);
                Days.Items.Add(13);
                Days.Items.Add(14);
                Days.Items.Add(15);
                Days.Items.Add(16);
                Days.Items.Add(17);
                Days.Items.Add(18);
                Days.Items.Add(19);
                Days.Items.Add(20);
                Days.Items.Add(21);
                Days.Items.Add(22);
                Days.Items.Add(23);
                Days.Items.Add(24);
                Days.Items.Add(25);
                Days.Items.Add(26);
                Days.Items.Add(27);
                Days.Items.Add(28);
                Days.Items.Add(29);
                Days.Items.Add(30);
                Days.Items.Add(31);
            }
        }

        private void Lucky_Num_Button_Click(object sender, EventArgs e)
        {
            Result result = new Result();

            result.Show(); // allows for switching between forms.
        }

     
    }
}
