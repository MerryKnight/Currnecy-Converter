using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            string url1 = "https://www.banki.ru/products/currency/usd/";
            string url2 = "https://www.banki.ru/products/currency/eur/";
            string url3 = "https://www.banki.ru/products/currency/gbp/";
            prog worker_show = new prog();
         
            string def = "RUB/USD" + " = " + (await worker_show.GetHtmlAsync(url1)).ToString() +
                            "\r\nRUB/EUR"+" = " + (await worker_show.GetHtmlAsync(url2)).ToString() +
                            "\r\nRUB/GBP" + " = " + (await worker_show.GetHtmlAsync(url3)).ToString();
            
            textBox4.Text = def;
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {


            string a = textBox1.Text;
            int selectedIndex = comboBox1.SelectedIndex;
            string url1 = "https://www.banki.ru/products/currency/usd/";
            string url2 = "https://www.banki.ru/products/currency/eur/";
            string url3 = "https://www.banki.ru/products/currency/gbp/";
            prog worker = new prog();
            float dollar = await worker.GetHtmlAsync(url1);
            float euro = await worker.GetHtmlAsync(url2);
            float funt = await worker.GetHtmlAsync(url3);
            string answer;
            float val;
            try
            {
                int currency_value = Convert.ToInt32(a);
                if (selectedIndex == 0 | selectedIndex == 3)
                {
                   if(selectedIndex == 0)
                   {
                        val = currency_value / (dollar);
                        answer = val.ToString("F2");
                        textBox2.Text = answer;
                   }
                   else 
                   {
                        val = currency_value * (dollar);
                        answer = val.ToString("F2");
                        textBox2.Text = answer;
                    }
                    
                }
                if (selectedIndex == 1 | selectedIndex == 4)
                {
                    if (selectedIndex == 1)
                    {
                        val = currency_value / (euro);
                        answer = val.ToString("F2");
                        textBox2.Text = answer;
                    }
                    else
                    {
                        val = currency_value * (euro);
                        answer = val.ToString("F2");
                        textBox2.Text = answer;
                    }

                }
                if (selectedIndex == 2 | selectedIndex == 5)
                {
                    if (selectedIndex == 2)
                    {
                        val = currency_value / (funt);
                        answer = val.ToString("F2");
                        textBox2.Text = answer;
                    }
                    else
                    {
                        val = currency_value * (funt);
                        answer = val.ToString("F2");
                        textBox2.Text = answer;
                    }

                }
           
            }
            catch(FormatException)
            {
                 MessageBox.Show("That was an error... Вы не ввели число!","Ошибка!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private async void textBox3_TextChanged(object sender, EventArgs e)
        {
          
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
