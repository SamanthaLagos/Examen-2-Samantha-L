namespace Examen2_SamanthaLagos
{
    partial class FrmProducto
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
            this.components = new System.ComponentModel.Container();
            this.Dtp_Productos = new System.Windows.Forms.DataGridView();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Txt_Existencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Descr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dtp_Productos
            // 
            this.Dtp_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtp_Productos.Location = new System.Drawing.Point(179, 313);
            this.Dtp_Productos.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Productos.Name = "Dtp_Productos";
            this.Dtp_Productos.RowHeadersWidth = 51;
            this.Dtp_Productos.Size = new System.Drawing.Size(1001, 226);
            this.Dtp_Productos.TabIndex = 51;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Enabled = false;
            this.Btn_Cancelar.Location = new System.Drawing.Point(797, 268);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Cancelar.TabIndex = 50;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(685, 268);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Eliminar.TabIndex = 49;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Enabled = false;
            this.Btn_Guardar.Location = new System.Drawing.Point(573, 268);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Guardar.TabIndex = 48;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(461, 268);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(104, 38);
            this.Btn_Modificar.TabIndex = 47;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(349, 268);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(104, 38);
            this.Btn_Nuevo.TabIndex = 46;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Txt_Existencia
            // 
            this.Txt_Existencia.Enabled = false;
            this.Txt_Existencia.Location = new System.Drawing.Point(346, 124);
            this.Txt_Existencia.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Existencia.Name = "Txt_Existencia";
            this.Txt_Existencia.Size = new System.Drawing.Size(261, 22);
            this.Txt_Existencia.TabIndex = 45;
            this.Txt_Existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Existencia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Existencia:";
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Enabled = false;
            this.Txt_Precio.Location = new System.Drawing.Point(346, 89);
            this.Txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(261, 22);
            this.Txt_Precio.TabIndex = 43;
            this.Txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Precio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Precio:";
            // 
            // Txt_Descr
            // 
            this.Txt_Descr.Enabled = false;
            this.Txt_Descr.Location = new System.Drawing.Point(346, 55);
            this.Txt_Descr.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descr.MaxLength = 45;
            this.Txt_Descr.Name = "Txt_Descr";
            this.Txt_Descr.Size = new System.Drawing.Size(261, 22);
            this.Txt_Descr.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Descripción:";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Enabled = false;
            this.Txt_Codigo.Location = new System.Drawing.Point(346, 20);
            this.Txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(261, 22);
            this.Txt_Codigo.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Código:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1359, 559);
            this.Controls.Add(this.Dtp_Productos);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Txt_Existencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Descr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.label1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dtp_Productos;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.TextBox Txt_Existencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Descr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}