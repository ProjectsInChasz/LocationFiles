using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            if (textBox2.Text != "" && Directory.Exists(@textBox2.Text))
            {
                textBox1.Clear();
                string[] pliki = Directory.GetFileSystemEntries(@textBox2.Text);
                foreach (string elo in pliki)
                {
                    textBox1.AppendText(elo + System.Environment.NewLine);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "A, Control")
            {
                textBox1.SelectAll();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif",comboBox1.SelectedIndex, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Dziękuję za użycia mojego prototypu ... Boksycka Team :D");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Open(@textBox1.SelectedText,System.IO.FileMode.Open);
        }
    }
}
