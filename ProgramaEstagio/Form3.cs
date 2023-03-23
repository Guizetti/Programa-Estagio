using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProgramaEstagio
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lv1.View = View.Details;
            lv1.FullRowSelect = true;
            lv1.GridLines = true;
            lv1.LabelEdit = true;
            lv1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lv1.Columns.Add("Razão social", 250, HorizontalAlignment.Left);
            lv1.Columns.Add("CNPJ", 150, HorizontalAlignment.Left);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtRS.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a razão social.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtCNPJ.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o CNPJ.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lista1 = new ListViewItem(txtID.Text.Trim());
            lista1.SubItems.Add(txtRS.Text.Trim());
            lista1.SubItems.Add(txtCNPJ.Text.Trim());

            lv1.Items.Add(lista1);

            txtID.Text = string.Empty;
            txtRS.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lv1.Items.Clear();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form4 ProxForm = new Form4();
            ProxForm.ShowDialog();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form2 ProxForm = new Form2();
            ProxForm.ShowDialog();
            this.Close();
        }
    }
}
