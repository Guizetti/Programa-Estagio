namespace ProgramaEstagio
{
    partial class Form3
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
            txtCNPJ = new TextBox();
            label4 = new Label();
            txtRS = new TextBox();
            label3 = new Label();
            btn1 = new Button();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            btn3 = new Button();
            btn4 = new Button();
            SuspendLayout();
            // 
            // lv1
            // 
            lv1.Location = new Point(374, 119);
            lv1.Name = "lv1";
            lv1.Size = new Size(505, 244);
            lv1.TabIndex = 26;
            lv1.UseCompatibleStateImageBehavior = false;
            // 
            // btn2
            // 
            btn2.Location = new Point(588, 369);
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
            label5.Location = new Point(564, 100);
            label5.Name = "label5";
            label5.Size = new Size(135, 16);
            label5.TabIndex = 24;
            label5.Text = "Lista de fornecedores:";
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(102, 252);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(166, 23);
            txtCNPJ.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 259);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 22;
            label4.Text = "CNPJ:";
            // 
            // txtRS
            // 
            txtRS.Location = new Point(102, 199);
            txtRS.Name = "txtRS";
            txtRS.Size = new Size(253, 23);
            txtRS.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 206);
            label3.Name = "label3";
            label3.Size = new Size(86, 16);
            label3.TabIndex = 20;
            label3.Text = "Razão social:";
            // 
            // btn1
            // 
            btn1.Location = new Point(102, 316);
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
            label2.Location = new Point(73, 147);
            label2.Name = "label2";
            label2.Size = new Size(23, 16);
            label2.TabIndex = 18;
            label2.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(102, 145);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 17;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(354, 17);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 16;
            label1.Text = "Fornecedores";
            // 
            // btn3
            // 
            btn3.Location = new Point(374, 369);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 30;
            btn3.Text = "Voltar tela";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(788, 369);
            btn4.Name = "btn4";
            btn4.Size = new Size(91, 23);
            btn4.TabIndex = 29;
            btn4.Text = "Próxima tela";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 405);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(lv1);
            Controls.Add(btn2);
            Controls.Add(label5);
            Controls.Add(txtCNPJ);
            Controls.Add(label4);
            Controls.Add(txtRS);
            Controls.Add(label3);
            Controls.Add(btn1);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Fornecedores";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv1;
        private Button btn2;
        private Label label5;
        private TextBox txtCNPJ;
        private Label label4;
        private TextBox txtRS;
        private Label label3;
        private Button btn1;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Button btn3;
        private Button btn4;
    }
}