using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDS_RSA_SHA384
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void VerifySign_Click(object sender, EventArgs e)
        {
            var signBytes = Encoding.Unicode.GetBytes(SignInput.Text);
            var verified = EDSService.CheckSignature(signBytes);
            if (verified)
            {
                SignVerificationLabel.Text = "Correct";
                SignVerificationLabel.ForeColor = Color.Green;
            } else
            {
                SignVerificationLabel.Text = "Incorrect";
                SignVerificationLabel.ForeColor = Color.Red;
            }
        }

        private void CreateSignButton_Click(object sender, EventArgs e)
        {
            var text = TextInput.Text;
            EDSService.CreateSignature(text);
            SignInfo.Clear();
            SignInfo.Text = EDSService.GetInfo();
        }
    }
}
