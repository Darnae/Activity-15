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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            int lucky_num = 7 + 7 + 5;
            Lucky_Num_Text.Text = "Congradulations! Your Lucky Number is:" + lucky_num;
        }

 

       
    }
}
