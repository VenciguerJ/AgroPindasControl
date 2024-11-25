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
            btnRelPedidos = new Button();
            btnRelProd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 87);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
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
            label1.Location = new Point(167, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(806, 45);
            label1.TabIndex = 1;
            label1.Text = "AgroPindas Control - Gerenciamento da sua fazenda\r\n";
            // 
            // btnRelProdutos
            // 
            btnRelProdutos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelProdutos.Image = (Image)resources.GetObject("btnRelProdutos.Image");
            btnRelProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelProdutos.Location = new Point(167, 322);
            btnRelProdutos.Margin = new Padding(4, 5, 4, 5);
            btnRelProdutos.Name = "btnRelProdutos";
            btnRelProdutos.Size = new Size(309, 185);
            btnRelProdutos.TabIndex = 2;
            btnRelProdutos.Text = "Produtos";
            btnRelProdutos.TextAlign = ContentAlignment.MiddleRight;
            btnRelProdutos.UseVisualStyleBackColor = true;
            btnRelProdutos.Click += btnRelProdutos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(526, 48);
            label2.TabIndex = 3;
            label2.Text = "Escolha o relatório a ser exibido";
            // 
            // btnRelFornecedores
            // 
            btnRelFornecedores.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelFornecedores.Image = (Image)resources.GetObject("btnRelFornecedores.Image");
            btnRelFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelFornecedores.Location = new Point(559, 322);
            btnRelFornecedores.Margin = new Padding(4, 5, 4, 5);
            btnRelFornecedores.Name = "btnRelFornecedores";
            btnRelFornecedores.Size = new Size(363, 185);
            btnRelFornecedores.TabIndex = 4;
            btnRelFornecedores.Text = "Fornecedores";
            btnRelFornecedores.TextAlign = ContentAlignment.MiddleRight;
            btnRelFornecedores.UseVisualStyleBackColor = true;
            btnRelFornecedores.Click += btnRelFornecedores_Click;
            // 
            // btnRelPedidos
            // 
            btnRelPedidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelPedidos.Image = (Image)resources.GetObject("btnRelPedidos.Image");
            btnRelPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelPedidos.Location = new Point(180, 532);
            btnRelPedidos.Margin = new Padding(4, 5, 4, 5);
            btnRelPedidos.Name = "btnRelPedidos";
            btnRelPedidos.Size = new Size(296, 185);
            btnRelPedidos.TabIndex = 5;
            btnRelPedidos.Text = "Pedidos";
            btnRelPedidos.TextAlign = ContentAlignment.MiddleRight;
            btnRelPedidos.UseVisualStyleBackColor = true;
            btnRelPedidos.Click += btnRelPedidos_Click;
            // 
            // btnRelProd
            // 
            btnRelProd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelProd.Image = (Image)resources.GetObject("btnRelProd.Image");
            btnRelProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnRelProd.Location = new Point(559, 532);
            btnRelProd.Margin = new Padding(4, 5, 4, 5);
            btnRelProd.Name = "btnRelProd";
            btnRelProd.Size = new Size(363, 185);
            btnRelProd.TabIndex = 6;
            btnRelProd.Text = "Produções";
            btnRelProd.TextAlign = ContentAlignment.MiddleRight;
            btnRelProd.UseVisualStyleBackColor = true;
            btnRelProd.Click += btnRelProd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 940);
            Controls.Add(btnRelProd);
            Controls.Add(btnRelPedidos);
            Controls.Add(btnRelFornecedores);
            Controls.Add(label2);
            Controls.Add(btnRelProdutos);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnRelPedidos;
        private Button btnRelProd;
    }
}
