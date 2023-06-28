using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUrok1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При нажатии на кнопку(Click me),появилось это окно");
        }

        private void openWindowBtn_Click(object sender, EventArgs e)
        {
            //Создаем объект который будет вызываться при клике
            Form2 form2 = new Form2(this);
            form2.Show();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato;
        }
    }
}
