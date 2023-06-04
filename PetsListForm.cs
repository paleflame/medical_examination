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
    public partial class PetsListForm : Form
    {
        public PetsListForm()
        {
            InitializeComponent();
        }

        private void DeleteRow()
        {
            string pet = dataGridView1.CurrentCell.Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
    }
}
