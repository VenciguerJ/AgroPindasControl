namespace AgroPindasControl
{
    partial class FormFornecedores
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
            label1 = new Label();
            GridFornecedores = new DataGridView();
            BTNGerarFornecedores = new Button();
            ((System.ComponentModel.ISupportInitialize)GridFornecedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(445, 48);
            label1.TabIndex = 0;
            label1.Text = "Relatório de fornecedor";
            // 
            // GridFornecedores
            // 
            GridFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridFornecedores.Location = new Point(22, 132);
            GridFornecedores.Name = "GridFornecedores";
            GridFornecedores.RowHeadersWidth = 62;
            GridFornecedores.Size = new Size(898, 293);
            GridFornecedores.TabIndex = 1;
            GridFornecedores.CellContentClick += GridFornecedores_CellContentClick;
            // 
            // BTNGerarFornecedores
            // 
            BTNGerarFornecedores.Location = new Point(593, 40);
            BTNGerarFornecedores.Name = "BTNGerarFornecedores";
            BTNGerarFornecedores.Size = new Size(144, 41);
            BTNGerarFornecedores.TabIndex = 2;
            BTNGerarFornecedores.Text = "GerarRelatório";
            BTNGerarFornecedores.UseVisualStyleBackColor = true;
            BTNGerarFornecedores.Click += BTNGerarFornecedores_Click;
            // 
            // FormFornecedores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(BTNGerarFornecedores);
            Controls.Add(GridFornecedores);
            Controls.Add(label1);
            Name = "FormFornecedores";
            Text = "FormFornecedores";
            Load += FormFornecedores_Load;
            ((System.ComponentModel.ISupportInitialize)GridFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GridFornecedores;
        private Button BTNGerarFornecedores;
    }
}