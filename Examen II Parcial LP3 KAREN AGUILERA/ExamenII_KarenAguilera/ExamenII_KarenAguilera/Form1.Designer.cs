namespace ExamenII_KarenAguilera
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreUsuario_Txt = new System.Windows.Forms.TextBox();
            this.Contraseña_txt = new System.Windows.Forms.TextBox();
            this.Ingresar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // NombreUsuario_Txt
            // 
            this.NombreUsuario_Txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario_Txt.Location = new System.Drawing.Point(127, 54);
            this.NombreUsuario_Txt.Name = "NombreUsuario_Txt";
            this.NombreUsuario_Txt.Size = new System.Drawing.Size(171, 26);
            this.NombreUsuario_Txt.TabIndex = 3;
            this.NombreUsuario_Txt.Text = "KAGUILERA";
            // 
            // Contraseña_txt
            // 
            this.Contraseña_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña_txt.Location = new System.Drawing.Point(127, 107);
            this.Contraseña_txt.Name = "Contraseña_txt";
            this.Contraseña_txt.Size = new System.Drawing.Size(171, 26);
            this.Contraseña_txt.TabIndex = 4;
            this.Contraseña_txt.Text = "123456";
            // 
            // Ingresar_btn
            // 
            this.Ingresar_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_btn.Location = new System.Drawing.Point(74, 176);
            this.Ingresar_btn.Name = "Ingresar_btn";
            this.Ingresar_btn.Size = new System.Drawing.Size(75, 38);
            this.Ingresar_btn.TabIndex = 5;
            this.Ingresar_btn.Text = "Ingresar";
            this.Ingresar_btn.UseVisualStyleBackColor = true;
            this.Ingresar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_btn.Location = new System.Drawing.Point(223, 176);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 38);
            this.Cancelar_btn.TabIndex = 6;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(400, 239);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Ingresar_btn);
            this.Controls.Add(this.Contraseña_txt);
            this.Controls.Add(this.NombreUsuario_Txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreUsuario_Txt;
        private System.Windows.Forms.TextBox Contraseña_txt;
        private System.Windows.Forms.Button Ingresar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
    }
}

