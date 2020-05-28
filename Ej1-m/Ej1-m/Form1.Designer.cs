namespace Ej1_m
{
    partial class Form1
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
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.txtBox_CodigoProducto = new System.Windows.Forms.TextBox();
            this.lbl_CodigoProducto = new System.Windows.Forms.Label();
            this.lbl_Drescipcion = new System.Windows.Forms.Label();
            this.txtBox_DescripcionProducto = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txtBox_PrecioProducto = new System.Windows.Forms.TextBox();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.txtBox_NombreProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(149, 140);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(75, 36);
            this.btn_AgregarProducto.TabIndex = 0;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // txtBox_CodigoProducto
            // 
            this.txtBox_CodigoProducto.Location = new System.Drawing.Point(138, 35);
            this.txtBox_CodigoProducto.Name = "txtBox_CodigoProducto";
            this.txtBox_CodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtBox_CodigoProducto.TabIndex = 1;
            // 
            // lbl_CodigoProducto
            // 
            this.lbl_CodigoProducto.AutoSize = true;
            this.lbl_CodigoProducto.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lbl_CodigoProducto.Location = new System.Drawing.Point(28, 38);
            this.lbl_CodigoProducto.Name = "lbl_CodigoProducto";
            this.lbl_CodigoProducto.Size = new System.Drawing.Size(101, 13);
            this.lbl_CodigoProducto.TabIndex = 5;
            this.lbl_CodigoProducto.Text = "Codigo de Producto";
            // 
            // lbl_Drescipcion
            // 
            this.lbl_Drescipcion.AutoSize = true;
            this.lbl_Drescipcion.Location = new System.Drawing.Point(28, 64);
            this.lbl_Drescipcion.Name = "lbl_Drescipcion";
            this.lbl_Drescipcion.Size = new System.Drawing.Size(60, 13);
            this.lbl_Drescipcion.TabIndex = 7;
            this.lbl_Drescipcion.Text = "Descipcion";
            // 
            // txtBox_DescripcionProducto
            // 
            this.txtBox_DescripcionProducto.Location = new System.Drawing.Point(138, 61);
            this.txtBox_DescripcionProducto.Name = "txtBox_DescripcionProducto";
            this.txtBox_DescripcionProducto.Size = new System.Drawing.Size(100, 20);
            this.txtBox_DescripcionProducto.TabIndex = 6;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(28, 91);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Precio.TabIndex = 9;
            this.lbl_Precio.Text = "Precio";
            // 
            // txtBox_PrecioProducto
            // 
            this.txtBox_PrecioProducto.Location = new System.Drawing.Point(138, 88);
            this.txtBox_PrecioProducto.Name = "txtBox_PrecioProducto";
            this.txtBox_PrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtBox_PrecioProducto.TabIndex = 8;
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(28, 117);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(105, 13);
            this.lbl_NombreProducto.TabIndex = 11;
            this.lbl_NombreProducto.Text = "Nombre de Producto";
            // 
            // txtBox_NombreProducto
            // 
            this.txtBox_NombreProducto.Location = new System.Drawing.Point(138, 114);
            this.txtBox_NombreProducto.Name = "txtBox_NombreProducto";
            this.txtBox_NombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtBox_NombreProducto.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_NombreProducto);
            this.Controls.Add(this.txtBox_NombreProducto);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txtBox_PrecioProducto);
            this.Controls.Add(this.lbl_Drescipcion);
            this.Controls.Add(this.txtBox_DescripcionProducto);
            this.Controls.Add(this.lbl_CodigoProducto);
            this.Controls.Add(this.txtBox_CodigoProducto);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.TextBox txtBox_CodigoProducto;
        private System.Windows.Forms.Label lbl_CodigoProducto;
        private System.Windows.Forms.Label lbl_Drescipcion;
        private System.Windows.Forms.TextBox txtBox_DescripcionProducto;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txtBox_PrecioProducto;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.TextBox txtBox_NombreProducto;
    }
}

