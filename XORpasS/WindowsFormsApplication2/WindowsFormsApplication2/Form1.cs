using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
   

    public partial class Form1 : Form
    {
        
        string key;
        string word;
        string pass;
        int i;
        int roof;
        char result;
      
        int flag;
        string flagger;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(textBox2.Text.Length == 0 || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Wrong data"); 
            }
            else
            {
                textBox3.Clear(); 
                word = textBox1.Text;
                key = textBox2.Text;
                if (word.Length >= key.Length) { roof = key.Length; flagger = key; }
                else { roof = word.Length; flagger = word; }
                for (i = 0; i < roof; i++)
                {
                   flag = flagger[i];
                    if (flag % 3 == 0)
                        result = (char)((word[i] ^ key[i]) % 26 + 'a');
                    else if(flag%3 == 1)
                        result = (char)((word[i] ^ key[i])%9 + '0');
                    else result = (char)((word[i] ^ key[i])%26 + 'A');
                    pass += result;
                }
                textBox3.Text = pass;
                pass = "";
            }
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox1.Focus();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') button1_Click(null, null);
        }
    }
}
