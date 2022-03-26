namespace ExamenII_KarenAguilera
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IdProducto_txt = new System.Windows.Forms.TextBox();
            this.NombreProducto_txt = new System.Windows.Forms.TextBox();
            this.DescripcionProducto_txt = new System.Windows.Forms.TextBox();
            this.ExistenciaProducto_txt = new System.Windows.Forms.TextBox();
            this.PrecioProducto_txt = new System.Windows.Forms.TextBox();
            this.Nuevo_btn = new System.Windows.Forms.Button();
            this.Guardar_btn = new System.Windows.Forms.Button();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.ListaProductos_Dgv = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos_Dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "GOLOSINAS KAREN";
            // 
            // IdProducto_txt
            // 
            this.IdProducto_txt.Location = new System.Drawing.Point(147, 38);
            this.IdProducto_txt.Name = "IdProducto_txt";
            this.IdProducto_txt.Size = new System.Drawing.Size(100, 20);
            this.IdProducto_txt.TabIndex = 6;
            // 
            // NombreProducto_txt
            // 
            this.NombreProducto_txt.Location = new System.Drawing.Point(147, 73);
            this.NombreProducto_txt.Name = "NombreProducto_txt";
            this.NombreProducto_txt.Size = new System.Drawing.Size(366, 20);
            this.NombreProducto_txt.TabIndex = 7;
            // 
            // DescripcionProducto_txt
            // 
            this.DescripcionProducto_txt.Location = new System.Drawing.Point(147, 108);
            this.DescripcionProducto_txt.Multiline = true;
            this.DescripcionProducto_txt.Name = "DescripcionProducto_txt";
            this.DescripcionProducto_txt.Size = new System.Drawing.Size(366, 48);
            this.DescripcionProducto_txt.TabIndex = 8;
            // 
            // ExistenciaProducto_txt
            // 
            this.ExistenciaProducto_txt.Location = new System.Drawing.Point(147, 213);
            this.ExistenciaProducto_txt.Name = "ExistenciaProducto_txt";
            this.ExistenciaProducto_txt.Size = new System.Drawing.Size(100, 20);
            this.ExistenciaProducto_txt.TabIndex = 9;
            this.ExistenciaProducto_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciaProducto_txt_KeyPress);
            // 
            // PrecioProducto_txt
            // 
            this.PrecioProducto_txt.Location = new System.Drawing.Point(147, 170);
            this.PrecioProducto_txt.Name = "PrecioProducto_txt";
            this.PrecioProducto_txt.Size = new System.Drawing.Size(100, 20);
            this.PrecioProducto_txt.TabIndex = 10;
            this.PrecioProducto_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioProducto_txt_KeyPress);
            // 
            // Nuevo_btn
            // 
            this.Nuevo_btn.Location = new System.Drawing.Point(130, 256);
            this.Nuevo_btn.Name = "Nuevo_btn";
            this.Nuevo_btn.Size = new System.Drawing.Size(75, 23);
            this.Nuevo_btn.TabIndex = 11;
            this.Nuevo_btn.Text = "Nuevo";
            this.Nuevo_btn.UseVisualStyleBackColor = true;
            this.Nuevo_btn.Click += new System.EventHandler(this.Nuevo_btn_Click);
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Location = new System.Drawing.Point(229, 256);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(75, 23);
            this.Guardar_btn.TabIndex = 13;
            this.Guardar_btn.Text = "Guardar";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            this.Guardar_btn.Click += new System.EventHandler(this.Guardar_btn_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.Location = new System.Drawing.Point(334, 256);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_btn.TabIndex = 14;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.UseVisualStyleBackColor = true;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.Location = new System.Drawing.Point(427, 256);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_btn.TabIndex = 15;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // ListaProductos_Dgv
            // 
            this.ListaProductos_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProductos_Dgv.Location = new System.Drawing.Point(34, 285);
            this.ListaProductos_Dgv.Name = "ListaProductos_Dgv";
            this.ListaProductos_Dgv.Size = new System.Drawing.Size(564, 150);
            this.ListaProductos_Dgv.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(629, 473);
            this.Controls.Add(this.ListaProductos_Dgv);
            this.Controls.Add(this.Cancelar_btn);
            this.Controls.Add(this.Eliminar_btn);
            this.Controls.Add(this.Guardar_btn);
            this.Controls.Add(this.Nuevo_btn);
            this.Controls.Add(this.PrecioProducto_txt);
            this.Controls.Add(this.ExistenciaProducto_txt);
            this.Controls.Add(this.DescripcionProducto_txt);
            this.Controls.Add(this.NombreProducto_txt);
            this.Controls.Add(this.IdProducto_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaProductos_Dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdProducto_txt;
        private System.Windows.Forms.TextBox NombreProducto_txt;
        private System.Windows.Forms.TextBox DescripcionProducto_txt;
        private System.Windows.Forms.TextBox ExistenciaProducto_txt;
        private System.Windows.Forms.TextBox PrecioProducto_txt;
        private System.Windows.Forms.Button Nuevo_btn;
        private System.Windows.Forms.Button Guardar_btn;
        private System.Windows.Forms.Button Eliminar_btn;
        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.DataGridView ListaProductos_Dgv;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}