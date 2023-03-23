namespace ProgramaEstagio
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lv1 = new ListView();
            btn2 = new Button();
            label5 = new Label();
            txtProdutos = new TextBox();
            label4 = new Label();
            txtPedidos = new TextBox();
            label3 = new Label();
            btn1 = new Button();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtQtd = new TextBox();
            txtValor = new TextBox();
            label7 = new Label();
            btn3 = new Button();
            SuspendLayout();
            // 
            // lv1
            // 
            lv1.Location = new Point(249, 113);
            lv1.Name = "lv1";
            lv1.Size = new Size(651, 244);
            lv1.TabIndex = 26;
            lv1.UseCompatibleStateImageBehavior = false;
            // 
            // btn2
            // 
            btn2.Location = new Point(647, 363);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 25;
            btn2.Text = "Excluir";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(519, 94);
            label5.Name = "label5";
            label5.Size = new Size(106, 16);
            label5.TabIndex = 24;
            label5.Text = "Lista de pedidos:";
            // 
            // txtProdutos
            // 
            txtProdutos.Location = new Point(120, 214);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(100, 23);
            txtProdutos.TabIndex = 23;
            txtProdutos.KeyPress += txtProdutos_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(102, 16);
            label4.TabIndex = 22;
            label4.Text = "ID dos produtos:";
            // 
            // txtPedidos
            // 
            txtPedidos.Location = new Point(120, 166);
            txtPedidos.Name = "txtPedidos";
            txtPedidos.Size = new Size(100, 23);
            txtPedidos.TabIndex = 21;
            txtPedidos.KeyPress += txtPedidos_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 173);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 20;
            label3.Text = "ID dos pedidos:";
            // 
            // btn1
            // 
            btn1.Location = new Point(120, 370);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 23);
            btn1.TabIndex = 19;
            btn1.Text = "Enviar";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 120);
            label2.Name = "label2";
            label2.Size = new Size(23, 16);
            label2.TabIndex = 18;
            label2.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 118);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 17;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(352, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 28);
            label1.TabIndex = 16;
            label1.Text = "Pedidos - itens";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 271);
            label6.Name = "label6";
            label6.Size = new Size(77, 16);
            label6.TabIndex = 27;
            label6.Text = "Quantidade:";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(120, 264);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(100, 23);
            txtQtd.TabIndex = 28;
            txtQtd.KeyPress += txtQtd_KeyPress;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(120, 309);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 29;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(74, 316);
            label7.Name = "label7";
            label7.Size = new Size(40, 16);
            label7.TabIndex = 30;
            label7.Text = "Valor:";
            // 
            // btn3
            // 
            btn3.Location = new Point(439, 363);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 31;
            btn3.Text = "Voltar tela";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 405);
            Controls.Add(btn3);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(txtQtd);
            Controls.Add(label6);
            Controls.Add(lv1);
            Controls.Add(btn2);
            Controls.Add(label5);
            Controls.Add(txtProdutos);
            Controls.Add(label4);
            Controls.Add(txtPedidos);
            Controls.Add(label3);
            Controls.Add(btn1);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Pedidos - itens";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv1;
        private Button btn2;
        private Label label5;
        private TextBox txtProdutos;
        private Label label4;
        private TextBox txtPedidos;
        private Label label3;
        private Button btn1;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Label label6;
        private TextBox txtQtd;
        private TextBox txtValor;
        private Label label7;
        private Button btn3;
    }
}