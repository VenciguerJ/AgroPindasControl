namespace AgroPindasControl
{
    partial class FormProd
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
            DridProd = new DataGridView();
            Tittle = new Label();
            Imprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)DridProd).BeginInit();
            SuspendLayout();
            // 
            // DridProd
            // 
            DridProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DridProd.Location = new Point(25, 136);
            DridProd.Name = "DridProd";
            DridProd.RowHeadersWidth = 62;
            DridProd.Size = new Size(876, 285);
            DridProd.TabIndex = 0;
            DridProd.CellContentClick += DridProd_CellContentClick;
            // 
            // Tittle
            // 
            Tittle.AutoSize = true;
            Tittle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tittle.Location = new Point(47, 27);
            Tittle.Name = "Tittle";
            Tittle.Size = new Size(370, 48);
            Tittle.TabIndex = 1;
            Tittle.Text = "Relatório De Produtos";
            Tittle.Click += Tittle_Click;
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(558, 41);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(112, 34);
            Imprimir.TabIndex = 2;
            Imprimir.Text = "Imprimir";
            Imprimir.UseVisualStyleBackColor = true;
            Imprimir.Click += button1_Click;
            // 
            // FormProd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 450);
            Controls.Add(Imprimir);
            Controls.Add(Tittle);
            Controls.Add(DridProd);
            Name = "FormProd";
            Text = "FormProd";
            Load += FormProd_Load;
            ((System.ComponentModel.ISupportInitialize)DridProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DridProd;
        private Label Tittle;
        private Button Imprimir;
    }
}