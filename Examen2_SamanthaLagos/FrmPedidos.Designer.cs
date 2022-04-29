namespace Examen2_SamanthaLagos
{
    partial class FrmPedidos
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
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_TotalP = new System.Windows.Forms.TextBox();
            this.Txt_Isv = new System.Windows.Forms.TextBox();
            this.Txt_Sub_Tot = new System.Windows.Forms.TextBox();
            this.dtp_Pedido = new System.Windows.Forms.DataGridView();
            this.dateTp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Gb_Producto = new System.Windows.Forms.GroupBox();
            this.Txt_Descr = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gb_Cliente = new System.Windows.Forms.GroupBox();
            this.TxtM_Identidad = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Pedido)).BeginInit();
            this.Gb_Producto.SuspendLayout();
            this.Gb_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(748, 254);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Txt_TotalP);
            this.groupBox1.Controls.Add(this.Txt_Isv);
            this.groupBox1.Controls.Add(this.Txt_Sub_Tot);
            this.groupBox1.Location = new System.Drawing.Point(39, 229);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(541, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total A Pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "ISV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sub Total";
            // 
            // Txt_TotalP
            // 
            this.Txt_TotalP.Location = new System.Drawing.Point(380, 53);
            this.Txt_TotalP.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_TotalP.Name = "Txt_TotalP";
            this.Txt_TotalP.Size = new System.Drawing.Size(132, 22);
            this.Txt_TotalP.TabIndex = 0;
            // 
            // Txt_Isv
            // 
            this.Txt_Isv.Location = new System.Drawing.Point(205, 53);
            this.Txt_Isv.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Isv.Name = "Txt_Isv";
            this.Txt_Isv.Size = new System.Drawing.Size(132, 22);
            this.Txt_Isv.TabIndex = 0;
            // 
            // Txt_Sub_Tot
            // 
            this.Txt_Sub_Tot.Location = new System.Drawing.Point(24, 53);
            this.Txt_Sub_Tot.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Sub_Tot.Name = "Txt_Sub_Tot";
            this.Txt_Sub_Tot.Size = new System.Drawing.Size(132, 22);
            this.Txt_Sub_Tot.TabIndex = 0;
            // 
            // dtp_Pedido
            // 
            this.dtp_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp_Pedido.Location = new System.Drawing.Point(39, 323);
            this.dtp_Pedido.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Pedido.Name = "dtp_Pedido";
            this.dtp_Pedido.RowHeadersWidth = 51;
            this.dtp_Pedido.Size = new System.Drawing.Size(1027, 198);
            this.dtp_Pedido.TabIndex = 9;
            // 
            // dateTp_Fecha
            // 
            this.dateTp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTp_Fecha.Location = new System.Drawing.Point(954, 291);
            this.dateTp_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dateTp_Fecha.Name = "dateTp_Fecha";
            this.dateTp_Fecha.Size = new System.Drawing.Size(119, 22);
            this.dateTp_Fecha.TabIndex = 8;
            // 
            // Gb_Producto
            // 
            this.Gb_Producto.Controls.Add(this.Txt_Descr);
            this.Gb_Producto.Controls.Add(this.Txt_Cantidad);
            this.Gb_Producto.Controls.Add(this.Txt_Codigo);
            this.Gb_Producto.Controls.Add(this.label3);
            this.Gb_Producto.Controls.Add(this.label5);
            this.Gb_Producto.Controls.Add(this.label4);
            this.Gb_Producto.Location = new System.Drawing.Point(39, 132);
            this.Gb_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.Gb_Producto.Name = "Gb_Producto";
            this.Gb_Producto.Padding = new System.Windows.Forms.Padding(4);
            this.Gb_Producto.Size = new System.Drawing.Size(1035, 90);
            this.Gb_Producto.TabIndex = 5;
            this.Gb_Producto.TabStop = false;
            this.Gb_Producto.Text = "Producto";
            // 
            // Txt_Descr
            // 
            this.Txt_Descr.Location = new System.Drawing.Point(608, 49);
            this.Txt_Descr.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descr.Name = "Txt_Descr";
            this.Txt_Descr.Size = new System.Drawing.Size(417, 22);
            this.Txt_Descr.TabIndex = 1;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(352, 53);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(127, 22);
            this.Txt_Cantidad.TabIndex = 1;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(112, 53);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(127, 22);
            this.Txt_Codigo.TabIndex = 1;
            this.Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Codigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo";
            // 
            // Gb_Cliente
            // 
            this.Gb_Cliente.Controls.Add(this.TxtM_Identidad);
            this.Gb_Cliente.Controls.Add(this.Txt_Nombre);
            this.Gb_Cliente.Controls.Add(this.label2);
            this.Gb_Cliente.Controls.Add(this.label1);
            this.Gb_Cliente.Location = new System.Drawing.Point(39, 13);
            this.Gb_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Gb_Cliente.Name = "Gb_Cliente";
            this.Gb_Cliente.Padding = new System.Windows.Forms.Padding(4);
            this.Gb_Cliente.Size = new System.Drawing.Size(1035, 112);
            this.Gb_Cliente.TabIndex = 6;
            this.Gb_Cliente.TabStop = false;
            this.Gb_Cliente.Text = "Cliente";
            // 
            // TxtM_Identidad
            // 
            this.TxtM_Identidad.Location = new System.Drawing.Point(152, 48);
            this.TxtM_Identidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtM_Identidad.Mask = "####-####-#####";
            this.TxtM_Identidad.Name = "TxtM_Identidad";
            this.TxtM_Identidad.Size = new System.Drawing.Size(224, 22);
            this.TxtM_Identidad.TabIndex = 2;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(584, 49);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(417, 22);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(882, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha";
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1365, 533);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_Pedido);
            this.Controls.Add(this.dateTp_Fecha);
            this.Controls.Add(this.Gb_Producto);
            this.Controls.Add(this.Gb_Cliente);
            this.Controls.Add(this.label6);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Pedido)).EndInit();
            this.Gb_Producto.ResumeLayout(false);
            this.Gb_Producto.PerformLayout();
            this.Gb_Cliente.ResumeLayout(false);
            this.Gb_Cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_TotalP;
        private System.Windows.Forms.TextBox Txt_Isv;
        private System.Windows.Forms.TextBox Txt_Sub_Tot;
        private System.Windows.Forms.DataGridView dtp_Pedido;
        private System.Windows.Forms.DateTimePicker dateTp_Fecha;
        private System.Windows.Forms.GroupBox Gb_Producto;
        private System.Windows.Forms.TextBox Txt_Descr;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Gb_Cliente;
        private System.Windows.Forms.MaskedTextBox TxtM_Identidad;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}