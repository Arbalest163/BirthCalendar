using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_Day_TextChanged(object sender, EventArgs e)
        {
            setData();
        }

        private void textBox_Month_TextChanged(object sender, EventArgs e)
        {
            setData();
        }

        private void textBox_year_TextChanged(object sender, EventArgs e)
        {
            setData();
        }

        private void setData()
        {
            try
            {
                int d = int.Parse(textBox_Day.Text);
                int m = int.Parse(textBox_Month.Text);
                int y = int.Parse(textBox_year.Text);

                monthCalendar1.SetDate(new DateTime(y, m, d));
            }
            catch (Exception)
            {
                MessageBox.Show("Не верная дата");
                textBox_Day.Text = "1";
                textBox_Month.Text = "1";
                textBox_year.Text = "1999";
            }
        }
    }
}
