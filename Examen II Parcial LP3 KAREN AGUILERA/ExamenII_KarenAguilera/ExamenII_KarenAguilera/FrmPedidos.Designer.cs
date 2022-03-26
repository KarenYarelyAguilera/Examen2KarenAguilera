namespace ExamenII_KarenAguilera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NombreCliente_txt = new System.Windows.Forms.TextBox();
            this.CodigoPedido_txt = new System.Windows.Forms.TextBox();
            this.Cantidad_txt = new System.Windows.Forms.TextBox();
            this.Total_txt = new System.Windows.Forms.TextBox();
            this.Detalles_dataGridView = new System.Windows.Forms.DataGridView();
            this.CodigoProducto_txt = new System.Windows.Forms.TextBox();
            this.isv_txt = new System.Windows.Forms.TextBox();
            this.SubTotal_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Descripcion_txt = new System.Windows.Forms.TextBox();
            this.Guardar_btn = new System.Windows.Forms.Button();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = " PEDIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre del cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total a pagar:";
            // 
            // NombreCliente_txt
            // 
            this.NombreCliente_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCliente_txt.Location = new System.Drawing.Point(155, 66);
            this.NombreCliente_txt.Name = "NombreCliente_txt";
            this.NombreCliente_txt.Size = new System.Drawing.Size(228, 23);
            this.NombreCliente_txt.TabIndex = 9;
            // 
            // CodigoPedido_txt
            // 
            this.CodigoPedido_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoPedido_txt.Location = new System.Drawing.Point(113, 6);
            this.CodigoPedido_txt.Name = "CodigoPedido_txt";
            this.CodigoPedido_txt.Size = new System.Drawing.Size(100, 23);
            this.CodigoPedido_txt.TabIndex = 12;
            // 
            // Cantidad_txt
            // 
            this.Cantidad_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad_txt.Location = new System.Drawing.Point(436, 113);
            this.Cantidad_txt.Name = "Cantidad_txt";
            this.Cantidad_txt.Size = new System.Drawing.Size(100, 23);
            this.Cantidad_txt.TabIndex = 14;
            // 
            // Total_txt
            // 
            this.Total_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_txt.Location = new System.Drawing.Point(502, 300);
            this.Total_txt.Name = "Total_txt";
            this.Total_txt.Size = new System.Drawing.Size(100, 23);
            this.Total_txt.TabIndex = 16;
            // 
            // Detalles_dataGridView
            // 
            this.Detalles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detalles_dataGridView.Location = new System.Drawing.Point(12, 334);
            this.Detalles_dataGridView.Name = "Detalles_dataGridView";
            this.Detalles_dataGridView.Size = new System.Drawing.Size(626, 140);
            this.Detalles_dataGridView.TabIndex = 17;
            // 
            // CodigoProducto_txt
            // 
            this.CodigoProducto_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProducto_txt.Location = new System.Drawing.Point(155, 116);
            this.CodigoProducto_txt.Name = "CodigoProducto_txt";
            this.CodigoProducto_txt.Size = new System.Drawing.Size(100, 23);
            this.CodigoProducto_txt.TabIndex = 18;
            // 
            // isv_txt
            // 
            this.isv_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isv_txt.Location = new System.Drawing.Point(299, 302);
            this.isv_txt.Name = "isv_txt";
            this.isv_txt.Size = new System.Drawing.Size(100, 23);
            this.isv_txt.TabIndex = 19;
            // 
            // SubTotal_txt
            // 
            this.SubTotal_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal_txt.Location = new System.Drawing.Point(113, 300);
            this.SubTotal_txt.Name = "SubTotal_txt";
            this.SubTotal_txt.Size = new System.Drawing.Size(100, 23);
            this.SubTotal_txt.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "ISV:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "SubTotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Descripcion:";
            // 
            // Descripcion_txt
            // 
            this.Descripcion_txt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_txt.Location = new System.Drawing.Point(159, 160);
            this.Descripcion_txt.Multiline = true;
            this.Descripcion_txt.Name = "Descripcion_txt";
            this.Descripcion_txt.Size = new System.Drawing.Size(196, 37);
            this.Descripcion_txt.TabIndex = 24;
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_btn.Location = new System.Drawing.Point(395, 174);
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.Size = new System.Drawing.Size(207, 23);
            this.Guardar_btn.TabIndex = 25;
            this.Guardar_btn.Text = "GUARDAR PEDIDO";
            this.Guardar_btn.UseVisualStyleBackColor = true;
            this.Guardar_btn.Click += new System.EventHandler(this.Guardar_btn_Click);
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(422, 9);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.Fecha_dateTimePicker.TabIndex = 26;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(650, 502);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(this.Guardar_btn);
            this.Controls.Add(this.Descripcion_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubTotal_txt);
            this.Controls.Add(this.isv_txt);
            this.Controls.Add(this.CodigoProducto_txt);
            this.Controls.Add(this.Detalles_dataGridView);
            this.Controls.Add(this.Total_txt);
            this.Controls.Add(this.Cantidad_txt);
            this.Controls.Add(this.CodigoPedido_txt);
            this.Controls.Add(this.NombreCliente_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalles_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NombreCliente_txt;
        private System.Windows.Forms.TextBox CodigoPedido_txt;
        private System.Windows.Forms.TextBox Cantidad_txt;
        private System.Windows.Forms.TextBox Total_txt;
        private System.Windows.Forms.DataGridView Detalles_dataGridView;
        private System.Windows.Forms.TextBox CodigoProducto_txt;
        private System.Windows.Forms.TextBox isv_txt;
        private System.Windows.Forms.TextBox SubTotal_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Descripcion_txt;
        private System.Windows.Forms.Button Guardar_btn;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
    }
}