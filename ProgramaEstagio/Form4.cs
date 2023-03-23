using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaEstagio
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lv1.View = View.Details;
            lv1.FullRowSelect = true;
            lv1.GridLines = true;
            lv1.LabelEdit = true;
            lv1.Columns.Add("ID", 130, HorizontalAlignment.Left);
            lv1.Columns.Add("ID dos pedidos", 130, HorizontalAlignment.Left);
            lv1.Columns.Add("ID dos produtos", 130, HorizontalAlignment.Left);
            lv1.Columns.Add("Quantidade", 130, HorizontalAlignment.Left);
            lv1.Columns.Add("Valor", 130, HorizontalAlignment.Left);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtPedidos.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID dos pedidos.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtProdutos.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID dos produtos.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtQtd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a quantidade.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtValor.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o valor.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lista1 = new ListViewItem(txtID.Text.Trim());
            lista1.SubItems.Add(txtPedidos.Text.Trim());
            lista1.SubItems.Add(txtProdutos.Text.Trim());
            lista1.SubItems.Add(txtQtd.Text.Trim());
            lista1.SubItems.Add(txtValor.Text.Trim());

            lv1.Items.Add(lista1);

            txtID.Text = string.Empty;
            txtPedidos.Text = string.Empty;
            txtProdutos.Text = string.Empty;
            txtQtd.Text = string.Empty;
            txtValor.Text = string.Empty;
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

        private void txtPedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form3 ProxForm = new Form3();
            ProxForm.ShowDialog();
            this.Close();
        }
    }
}
