namespace Examen2_SamanthaLagos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_contraseña = new System.Windows.Forms.TextBox();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn__Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_contraseña
            // 
            this.Txt_contraseña.Location = new System.Drawing.Point(227, 146);
            this.Txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_contraseña.Name = "Txt_contraseña";
            this.Txt_contraseña.Size = new System.Drawing.Size(249, 22);
            this.Txt_contraseña.TabIndex = 17;
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(227, 71);
            this.Txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.Size = new System.Drawing.Size(249, 22);
            this.Txt_usuario.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(426, 240);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(100, 28);
            this.Btn_salir.TabIndex = 13;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn__Aceptar
            // 
            this.Btn__Aceptar.Location = new System.Drawing.Point(178, 240);
            this.Btn__Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn__Aceptar.Name = "Btn__Aceptar";
            this.Btn__Aceptar.Size = new System.Drawing.Size(100, 28);
            this.Btn__Aceptar.TabIndex = 12;
            this.Btn__Aceptar.Text = "Aceptar";
            this.Btn__Aceptar.UseVisualStyleBackColor = true;
            this.Btn__Aceptar.Click += new System.EventHandler(this.Btn__Aceptar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_contraseña);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn__Aceptar);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_contraseña;
        private System.Windows.Forms.TextBox Txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn__Aceptar;
    }
}

