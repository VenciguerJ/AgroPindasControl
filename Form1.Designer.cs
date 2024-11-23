namespace AgroPindasControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRelProdutos = new Button();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            btnRelFornecedores = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(117, 55);
            label1.Name = "label1";
            label1.Size = new Size(528, 30);
            label1.TabIndex = 1;
            label1.Text = "AgroPindas Control - Gerenciamento da sua fazenda\r\n";
            // 
            // btnRelProdutos
            // 
            btnRelProdutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelProdutos.Image = (Image)resources.GetObject("btnRelProdutos.Image");
            btnRelProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelProdutos.Location = new Point(117, 193);
            btnRelProdutos.Name = "btnRelProdutos";
            btnRelProdutos.Size = new Size(216, 111);
            btnRelProdutos.TabIndex = 2;
            btnRelProdutos.Text = "Produtos";
            btnRelProdutos.TextAlign = ContentAlignment.MiddleRight;
            btnRelProdutos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 117);
            label2.Name = "label2";
            label2.Size = new Size(352, 32);
            label2.TabIndex = 3;
            label2.Text = "Escolha o relatório a ser exibido";
            // 
            // btnRelFornecedores
            // 
            btnRelFornecedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelFornecedores.Image = (Image)resources.GetObject("btnRelFornecedores.Image");
            btnRelFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelFornecedores.Location = new Point(391, 193);
            btnRelFornecedores.Name = "btnRelFornecedores";
            btnRelFornecedores.Size = new Size(254, 111);
            btnRelFornecedores.TabIndex = 4;
            btnRelFornecedores.Text = "Fornecedores";
            btnRelFornecedores.TextAlign = ContentAlignment.MiddleRight;
            btnRelFornecedores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 564);
            Controls.Add(btnRelFornecedores);
            Controls.Add(label2);
            Controls.Add(btnRelProdutos);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRelProdutos;
        private Label label2;
        private ColorDialog colorDialog1;
        private Button btnRelFornecedores;
    }
}
