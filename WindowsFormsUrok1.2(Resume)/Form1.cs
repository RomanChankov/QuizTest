using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUrok1._2_Resume_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonMale.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"ФИО: {surNameBox.Text} {firsNameBox.Text} {secondNameBox.Text}\n";
            if(radioButtonMale.Checked == true)
            {
                message += $"Пол: Мужской\n";

            }
                else { message += $"Пол: Женский\n"; }
            message += $"Место проживания: {countryBox.Text},город {cityBox.Text}\n";
            message += $"Телефон: {phoneBox.Text}\nЭл.почта {mailBox.Text}\n";
            message += $"Дата рождения: {dateTimePicker1.Value.ToShortDateString()}\n";
            message += $"Язык программирования : {comboBox1.SelectedItem}";
            MessageBox.Show(message,"Анкетные данные");
        }
    }
}
