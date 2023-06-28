using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int balls = 0;
            if (checkBox1.Checked) ; else balls += 2;
            if (checkBox2.Checked) balls += 2;
            if (checkBox3.Checked) balls += 2;
            if (checkBox4.Checked) balls += 2;
            if (checkBox5.Checked) balls += 2;
            if (checkBox6.Checked) balls += 2; else balls += 1;
            if (checkBox7.Checked) ; else balls += 2;

            label9.Text = $"Количество баллов : {balls.ToString()}";

            if (balls >= 1 && balls <= 6)
                label8.Text = "Если в сумме набрано от 1 до 6 баллов, то это означает, что вы человек рассудительный,осторожный,стремящийся максимально сохранить свой душевный покой. Вы не любите 'копаться в себе' и чаще всего успешно гоните от себя различного рода тревожные мысли и страхи";
            if (balls >= 7 && balls <= 13)
                label8.Text = "Если в сумме набрано от 7 до 13 баллов, то это говорит о том , что вы человек уравновешенный, порой решительный, но не слишком гибкий, а это иногда мешает вам в жизни";
            if (balls >= 14)
                label8.Text = "Если же сумма набранных баллов более 14(а тем более приближена к 20), то это уже свидетельствует, что вы принимаете все близко к сердцу";
        }

    }

       
    }

