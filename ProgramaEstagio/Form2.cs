using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramaEstagio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lv1.View = View.Details;
            lv1.FullRowSelect = true;
            lv1.GridLines = true;
            lv1.LabelEdit = true;
            lv1.Columns.Add("ID", 200, HorizontalAlignment.Left);
            lv1.Columns.Add("Data", 100, HorizontalAlignment.Left);
            lv1.Columns.Add("ID dos fornecedores", 200, HorizontalAlignment.Left);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtData.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a data.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtFornec.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID dos fornecedores.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lista1 = new ListViewItem(txtID.Text.Trim());
            lista1.SubItems.Add(txtData.Text.Trim());
            lista1.SubItems.Add(txtFornec.Text.Trim());

            lv1.Items.Add(lista1);

            txtID.Text = string.Empty;
            txtData.Text = string.Empty;
            txtFornec.Text = string.Empty;
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

        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtFornec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtFornec_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form3 ProxForm = new Form3();
            ProxForm.ShowDialog();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form1 ProxForm = new Form1();
            ProxForm.ShowDialog();
            this.Close();
        }
    }
}
