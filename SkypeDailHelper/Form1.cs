using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDailHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSkypePhone.Text = convertToSkypePhone(textBoxOrigPhone.Text);
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            textBoxSkypePhone.Text = convertToSkypePhone(textBoxOrigPhone.Text);
            //LInk that starts with 'TEL:<phonenumber>' will open default prgram that makes phone calls 
            // In must cases default is SKype
            System.Diagnostics.Process.Start("TEL:"+textBoxSkypePhone.Text);

        }
        /// <summary>
        /// Remove leading 0 and add +972 prefix
        /// </summary>
        /// <param name="text">the original phone number</param>
        /// <returns>modified phone number</returns>
        private string convertToSkypePhone(string text)
        {
            String result=text.TrimStart('0');
            result = "+972" + result;
            return result;
        }

        private void textBoxOrigPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConvert_Click(sender, e);

            }
        }
    }
}
