namespace Ejercicio_1
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
            this.vender = new System.Windows.Forms.Button();
            this.titulo_txtbox = new System.Windows.Forms.TextBox();
            this.cant_textbox = new System.Windows.Forms.TextBox();
            this.prod_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.listBox_ventas = new System.Windows.Forms.ListBox();
            this.lbl_msjError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vender
            // 
            this.vender.Location = new System.Drawing.Point(261, 76);
            this.vender.Name = "vender";
            this.vender.Size = new System.Drawing.Size(75, 23);
            this.vender.TabIndex = 0;
            this.vender.Text = "Vender";
            this.vender.UseVisualStyleBackColor = true;
            this.vender.Click += new System.EventHandler(this.vender_Click);
            // 
            // titulo_txtbox
            // 
            this.titulo_txtbox.Location = new System.Drawing.Point(59, 12);
            this.titulo_txtbox.Name = "titulo_txtbox";
            this.titulo_txtbox.Size = new System.Drawing.Size(224, 20);
            this.titulo_txtbox.TabIndex = 1;
            this.titulo_txtbox.TextChanged += new System.EventHandler(this.titulo_txtbox_TextChanged);
            // 
            // cant_textbox
            // 
            this.cant_textbox.Location = new System.Drawing.Point(139, 78);
            this.cant_textbox.Name = "cant_textbox";
            this.cant_textbox.Size = new System.Drawing.Size(100, 20);
            this.cant_textbox.TabIndex = 3;
            // 
            // prod_comboBox
            // 
            this.prod_comboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.prod_comboBox.FormattingEnabled = true;
            this.prod_comboBox.Items.AddRange(new object[] {
            "001 - Lápicera",
            "002 - Resma A4",
            "003 - Marcadores"});
            this.prod_comboBox.Location = new System.Drawing.Point(12, 78);
            this.prod_comboBox.Name = "prod_comboBox";
            this.prod_comboBox.Size = new System.Drawing.Size(121, 21);
            this.prod_comboBox.TabIndex = 4;
            this.prod_comboBox.Text = "Elija un producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total recaudado hasta el momento: $";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.ForeColor = System.Drawing.Color.Black;
            this.lbl_total.Location = new System.Drawing.Point(190, 322);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "0";
            // 
            // listBox_ventas
            // 
            this.listBox_ventas.FormattingEnabled = true;
            this.listBox_ventas.Location = new System.Drawing.Point(13, 133);
            this.listBox_ventas.Name = "listBox_ventas";
            this.listBox_ventas.Size = new System.Drawing.Size(243, 173);
            this.listBox_ventas.TabIndex = 7;
            // 
            // lbl_msjError
            // 
            this.lbl_msjError.AutoSize = true;
            this.lbl_msjError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msjError.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjError.Location = new System.Drawing.Point(13, 106);
            this.lbl_msjError.Name = "lbl_msjError";
            this.lbl_msjError.Size = new System.Drawing.Size(0, 13);
            this.lbl_msjError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.lbl_msjError);
            this.Controls.Add(this.listBox_ventas);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prod_comboBox);
            this.Controls.Add(this.cant_textbox);
            this.Controls.Add(this.titulo_txtbox);
            this.Controls.Add(this.vender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vender;
        private System.Windows.Forms.TextBox titulo_txtbox;
        private System.Windows.Forms.TextBox cant_textbox;
        private System.Windows.Forms.ComboBox prod_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.ListBox listBox_ventas;
        private System.Windows.Forms.Label lbl_msjError;
    }
}

