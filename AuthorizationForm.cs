using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_examination
{
    public partial class AuthorizationForm : Form
    {

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = AuthorisationService.Login(textBox1.Text,textBox2.Text);
            if (user != null) {
                
            }
            else {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
