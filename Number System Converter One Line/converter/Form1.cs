using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try { textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text.Contains('.') ? textBox1.Text.Substring(0, textBox1.Text.IndexOf('.')) : textBox1.Text, Int32.Parse(comboBox1.SelectedItem.ToString().Substring(comboBox1.SelectedItem.ToString().Length - 2))), Int32.Parse(comboBox2.SelectedItem.ToString().Substring(comboBox2.SelectedItem.ToString().Length - 2))).ToUpper() + (textBox1.Text.Contains('.') ? "." + (Convert.ToString((Convert.ToInt32( Convert.ToInt32(textBox1.Text.Substring(textBox1.Text.IndexOf('.') + 1), (Int32.Parse(comboBox1.SelectedItem.ToString().Substring(comboBox1.SelectedItem.ToString().Length - 2)))).ToString() ) * Convert.ToInt32(Math.Pow((double)(Int32.Parse(comboBox2.SelectedItem.ToString().Substring(comboBox2.SelectedItem.ToString().Length - 2))), (textBox1.Text.Contains('.') ? Convert.ToInt32(textBox1.Text.Substring(textBox1.Text.IndexOf('.') + 1), (Int32.Parse(comboBox1.SelectedItem.ToString().Substring(comboBox1.SelectedItem.ToString().Length - 2)))).ToString() : "0").Length)) / Convert.ToInt32(Math.Pow((double)(Int32.Parse(comboBox1.SelectedItem.ToString().Substring(comboBox1.SelectedItem.ToString().Length - 2))), (textBox1.Text.Contains('.') ? Convert.ToInt32(textBox1.Text.Substring(textBox1.Text.IndexOf('.') + 1), (Int32.Parse(comboBox1.SelectedItem.ToString().Substring(comboBox1.SelectedItem.ToString().Length - 2)))).ToString() : "0").Length))), (Int32.Parse(comboBox2.SelectedItem.ToString().Substring(comboBox2.SelectedItem.ToString().Length - 2)))).ToUpper()) : ""); } catch { MessageBox.Show("Error"); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
