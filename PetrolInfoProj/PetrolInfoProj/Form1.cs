using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace PetrolInfoProj
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private HtmlNodeCollection getData()
        {
            var webGet = new HtmlWeb();
            var document = webGet.Load(@"C:\Users\Bocian\Documents\Visual Studio 2013\Projects\Xpath first proj\bookshop.html");
            var metaTags = document.DocumentNode.SelectNodes("/html/body/div/div/div/div/div/ul/li/span");

            return metaTags;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlNodeCollection dane = getData();
            if (comboBox1.Text == "ON")
            {
                textBox1.Text = Convert.ToString(dane[0].InnerHtml);
                page_label.Text = "Pobrano z www.money.pl";
                time_label.Text = DateTime.Now.ToString();
            }
               
            else if (comboBox1.Text == "PB 95")
            {
                textBox1.Text = Convert.ToString(dane[1].InnerHtml);
                page_label.Text = "Pobrano z www.money.pl";
                time_label.Text = DateTime.Now.ToString();
            }
                
            else if (comboBox1.Text == "PB 98")
            {
                textBox1.Text = Convert.ToString(dane[2].InnerHtml);
                page_label.Text = "Pobrano z www.money.pl";
                time_label.Text = DateTime.Now.ToString();
            }
            else if (comboBox1.Text == "LPG")
            {
                textBox1.Text = Convert.ToString(dane[3].InnerHtml);
                page_label.Text = "Pobrano z www.money.pl";
                time_label.Text = DateTime.Now.ToString();
            }
                

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void time_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
