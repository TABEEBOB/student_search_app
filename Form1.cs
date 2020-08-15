

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassProject
{
    public partial class Form1 : Form
    {
        Student s1; //create s1 object.
        public Form1()
        {
            InitializeComponent();
        }
        
       
       public void fillbtn_Click(object sender, EventArgs e)
        { //create an instance of S1, using constructor with parameters.
         s1 = new Student(namebox.Text,addbox.Text,phonebox.Text,emailbox.Text, majorbox.Text , gpabox.Text);

            namebox.Text = " ";
            addbox.Text = " ";
            phonebox.Text = " ";
            gpabox.Text = " ";
            majorbox.Text = " ";
            emailbox.Text = " ";

        }

       
        private void displaybtn_Click(object sender, EventArgs e)
        {
         
            s1.Display(); //method call.

            namebox.Clear();
            addbox.Clear();
            phonebox.Clear();
            emailbox.Clear();
            majorbox.Clear();
            gpabox.Clear();

           
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close(); //exit appliaction
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namebox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void namebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
            char chr = e.KeyChar;
            if (char.IsDigit(chr) || char.IsPunctuation(chr) && chr != 8 && chr != 45 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void addbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (char.IsPunctuation(chr) && chr != 8 && chr != 45 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void phonebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (char.IsLetter(chr) || char.IsPunctuation(chr) && chr != 8 && chr != 45 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void emailbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (char.IsWhiteSpace(chr) && chr != 8 && chr != 45 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void majorbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (char.IsDigit(chr) || char.IsPunctuation(chr) && chr != 8 && chr != 45 && chr != 46)
            {
                e.Handled = true;
            }
        }

        private void gpabox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (char.IsLetter(chr) || char.IsPunctuation(chr) && chr != 8 && chr != 45 && chr != 46)
            {
                e.Handled = true;
            }
        }
    }
}
