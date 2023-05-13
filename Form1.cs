using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Account[] ACC_ARR = new Account[100];
        public int N;
        public Form1()
        {
            InitializeComponent();
        }

        public void Acc_Sort()
        {
            Account Temp = new Account();
            int i, j;

            for (i = 1; i < N; N++)
                for (j = 0; j < N - i; j++)
                    if (ACC_ARR[j].Acc_No < ACC_ARR[j + 1].Acc_No)
                    {
                        Temp = ACC_ARR[j];
                        ACC_ARR[j] = ACC_ARR[j + 1];
                        ACC_ARR[j + 1] = Temp;
                    }
        }

        public void AVG_MAX(ref double AVG, ref double MAX)
        {
            int i;
            AVG = 0;
            for (i = 0; i < N; i++)
                AVG = AVG + ACC_ARR[i].Acc_Balance;

            AVG = AVG / N;

            MAX = ACC_ARR[0].Acc_Balance;
            for (i = 1; i < N; i++)
                if (ACC_ARR[i].Acc_Balance > MAX) MAX = ACC_ARR[i].Acc_Balance;
        }

        public int Acc_no_Search(int Acc_No_to_Search_for)
        {
            int ret = -1;
            for (int i = 0; i < N; i++)
                if (ACC_ARR[i].Acc_No == Acc_No_to_Search_for)
                    ret = i;
            return ret;
        }
        private void ADD_button_Click(object sender, EventArgs e)
        {
            int Acc_No;
            int.TryParse(Acc_No_textBox.Text, out Acc_No);

            ACC_ARR[N] = new Account(Acc_Name_textBox.Text, Acc_No);
            N++;
        }
    }

    public class Account
    {
        public string Acc_Name { get; set; }
        public int Acc_No { get; set; }
        public DateTime Acc_Date { get; set; }
        public double Acc_Balance { get; set; }

        public Account()
        {
            Acc_Name = "";
            Acc_No = -1;
            Acc_Date = DateTime.Now;
            Acc_Balance = 0;
        }

        public Account(string Name, int No)
        {
            Acc_Name = Name;
            Acc_No = No;
            Acc_Date = new DateTime();
            Acc_Balance = 0;
        }
    }
}