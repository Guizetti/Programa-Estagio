namespace ProgramaEstagio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Descrição", 250, HorizontalAlignment.Left);
            listView1.Columns.Add("Unidade", 150, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira o ID.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBox2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a descrição.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (textBox3.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Insira a unidade.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem lista = new ListViewItem(textBox1.Text.Trim());
            lista.SubItems.Add(textBox2.Text.Trim());
            lista.SubItems.Add(textBox3.Text.Trim());

            listView1.Items.Add(lista);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ProxForm = new Form2();
            ProxForm.ShowDialog();
            this.Close();
        }
    }
}