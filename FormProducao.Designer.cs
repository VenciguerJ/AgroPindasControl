namespace AgroPindasControl
{
    partial class FormProducao
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
            Imprimir = new Button();
            Tittle = new Label();
            GridProd = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridProd).BeginInit();
            SuspendLayout();
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(495, 42);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(176, 34);
            Imprimir.TabIndex = 5;
            Imprimir.Text = "Gerar Relatório";
            Imprimir.UseVisualStyleBackColor = true;
            Imprimir.Click += Imprimir_Click;
            // 
            // Tittle
            // 
            Tittle.AutoSize = true;
            Tittle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tittle.Location = new Point(12, 28);
            Tittle.Name = "Tittle";
            Tittle.Size = new Size(395, 48);
            Tittle.TabIndex = 4;
            Tittle.Text = "Relatório De produções";
            // 
            // GridProd
            // 
            GridProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProd.Location = new Point(3, 143);
            GridProd.Name = "GridProd";
            GridProd.RowHeadersWidth = 62;
            GridProd.Size = new Size(876, 285);
            GridProd.TabIndex = 3;
            // 
            // FormProducao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(Imprimir);
            Controls.Add(Tittle);
            Controls.Add(GridProd);
            Name = "FormProducao";
            Text = "FormProducao";
            Load += FormProducao_Load;
            ((System.ComponentModel.ISupportInitialize)GridProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Imprimir;
        private Label Tittle;
        private DataGridView GridProd;
    }
}