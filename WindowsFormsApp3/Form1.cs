using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == " Hot Chocolate")
            {
                txt_Price.Text = "50";
            }
            else if (cmb_items.SelectedItem.ToString() == " Hot Moccha ")
            {
                txt_Price.Text = "45";
            }
            else if (cmb_items.SelectedItem.ToString() == " Caffe Latte  ")
            {
                txt_Price.Text = "55";
            }
            else if (cmb_items.SelectedItem.ToString() == " Espresso ")
            {
                txt_Price.Text = "35";
            }

            else if (cmb_items.SelectedItem.ToString() == " MilkShake")
            {
                txt_Price.Text = "70";
            }
            else if (cmb_items.SelectedItem.ToString() == " Cafe Afogato  ")
            {
                txt_Price.Text = "75";
            }
            else if (cmb_items.SelectedItem.ToString() == " Iced Moccha ")
            {
                txt_Price.Text = "40";
            }
            else if (cmb_items.SelectedItem.ToString() == " Latte Macchiato  ")
            {
                txt_Price.Text = "50";
            }

            else if (cmb_items.SelectedItem.ToString() == " Chocolate ")
            {
                txt_Price.Text = "25";
            }
            else if (cmb_items.SelectedItem.ToString() == " Vanillia   ")
            {
                txt_Price.Text = "25";
            }
            else if (cmb_items.SelectedItem.ToString() == " Bananas  ")
            {
                txt_Price.Text = "30";
            }
            else if (cmb_items.SelectedItem.ToString() == " Pineapple  ")
            {
                txt_Price.Text = "35";
            }

            else if (cmb_items.SelectedItem.ToString() == " Moltin Chocolate ")
            {
                txt_Price.Text = "50";
            }
            else if (cmb_items.SelectedItem.ToString() == " Red Velvet    ")
            {
                txt_Price.Text = "60";
            }
            else if (cmb_items.SelectedItem.ToString() == " Butter Cake  ")
            {
                txt_Price.Text = "45";
            }
            else if (cmb_items.SelectedItem.ToString() == " Pound Cake   ")
            {
                txt_Price.Text = "40";
            }
            else
            {
                txt_Price.Text = "0";
            }

            txt_total.Text = "";
            txt_quantity.Text = "";


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add(" Hot Chocolate");
            cmb_items.Items.Add(" Hot Moccha ");
            cmb_items.Items.Add(" Caffe Latte  ");
            cmb_items.Items.Add(" Espresso ");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add(" MilkShake");
            cmb_items.Items.Add(" Cafe Afogato  ");
            cmb_items.Items.Add(" Iced Moccha ");
            cmb_items.Items.Add(" Latte Macchiato  ");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Green;
            radioButton4.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add(" Chocolate ");
            cmb_items.Items.Add(" Vanillia   ");
            cmb_items.Items.Add(" Bananas  ");
            cmb_items.Items.Add(" Pineapple  ");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Red;
            radioButton3.ForeColor = System.Drawing.Color.Red;
            radioButton4.ForeColor = System.Drawing.Color.Green;

            cmb_items.Items.Clear();
            cmb_items.Items.Add(" Moltin Chocolate ");
            cmb_items.Items.Add(" Red Velvet    ");
            cmb_items.Items.Add(" Butter Cake  ");
            cmb_items.Items.Add(" Pound Cake   ");
        }






        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.Text.Length > 0)
            {

                txt_total.Text = (Convert.ToInt32(txt_Price.Text) * Convert.ToInt32(txt_quantity.Text)).ToString();
                

            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_Price.Text;
            arr[2] = txt_quantity.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi  = new ListViewItem(arr);

            listView1.Items.Add(lvi);

            txt_subtotal.Text = (Convert.ToInt32(txt_subtotal.Text) + Convert.ToInt32(txt_total.Text)).ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            { 
              txt_net.Text = (Convert.ToInt32(txt_subtotal.Text) -  Convert.ToInt32(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)

                txt_balance.Text = (Convert.ToInt32(txt_paid.Text) - Convert.ToInt32(txt_net.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3_click(); 
        }

        
        void button3_click ()
        {
            txt_Price.Clear();
            txt_Price.Text = ""; 

            txt_quantity.Clear();
            txt_quantity.Text = ""; 

            txt_total.Clear();
            txt_total.Text = ""; 

            txt_subtotal.Clear();
            txt_subtotal.Text = ""; 

            txt_discount.Clear();
            txt_discount.Text = ""; 
       
            txt_net.Clear();
            txt_net.Text = ""; 

            txt_balance.Clear();
            txt_balance.Text = ""; 

            txt_paid.Clear();
            txt_paid.Text = "";

            cmb_items.Items.Clear();
            cmb_items.Text = "";

            listView1.Items.Clear();
            listView1.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
    }

