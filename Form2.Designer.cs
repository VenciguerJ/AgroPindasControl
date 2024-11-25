namespace AgroPindasControl
{
    partial class Form2
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
            GridPedidos = new DataGridView();
            GerarRelatorioPedidos = new Button();
            ((System.ComponentModel.ISupportInitialize)GridPedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(388, 48);
            label1.TabIndex = 1;
            label1.Text = "Relatório de Pedidos";
            // 
            // GridPedidos
            // 
            GridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPedidos.Location = new Point(44, 172);
            GridPedidos.Name = "GridPedidos";
            GridPedidos.RowHeadersWidth = 62;
            GridPedidos.Size = new Size(702, 225);
            GridPedidos.TabIndex = 2;
            // 
            // GerarRelatorioPedidos
            // 
            GerarRelatorioPedidos.Location = new Point(560, 60);
            GerarRelatorioPedidos.Name = "GerarRelatorioPedidos";
            GerarRelatorioPedidos.Size = new Size(160, 34);
            GerarRelatorioPedidos.TabIndex = 3;
            GerarRelatorioPedidos.Text = "Gerar Relatório";
            GerarRelatorioPedidos.UseVisualStyleBackColor = true;
            GerarRelatorioPedidos.Click += GerarRelatorioPedidos_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GerarRelatorioPedidos);
            Controls.Add(GridPedidos);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Pedidos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)GridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GridPedidos;
        private Button GerarRelatorioPedidos;
    }
}