using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCadastrarTela_Click(object sender, EventArgs e)
        {
            Form2 OutroForm = new Form2();
            OutroForm.ShowDialog();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Form3 OutroForm = new Form3();
            OutroForm.ShowDialog();
        }
    }
}
