
namespace ProyectoFinal
{
    partial class CapturaPedidos
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
            this.labelR = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.cantidadR = new System.Windows.Forms.NumericUpDown();
            this.cantidadP = new System.Windows.Forms.NumericUpDown();
            this.cantidadV = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAPTURA DE PEDIDOS";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(41, 275);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(72, 17);
            this.labelR.TabIndex = 1;
            this.labelR.Text = "Refrescos";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(44, 324);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(128, 17);
            this.labelP.TabIndex = 2;
            this.labelP.Text = "Pan Fresco (pieza)";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(44, 373);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(168, 17);
            this.labelV.TabIndex = 3;
            this.labelV.Text = "Verdura Congelada (1kg)";
            // 
            // cantidadR
            // 
            this.cantidadR.Location = new System.Drawing.Point(237, 270);
            this.cantidadR.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.cantidadR.Name = "cantidadR";
            this.cantidadR.Size = new System.Drawing.Size(73, 22);
            this.cantidadR.TabIndex = 4;
            // 
            // cantidadP
            // 
            this.cantidadP.Location = new System.Drawing.Point(237, 324);
            this.cantidadP.Maximum = new decimal(new int[] {
            810,
            0,
            0,
            0});
            this.cantidadP.Name = "cantidadP";
            this.cantidadP.Size = new System.Drawing.Size(73, 22);
            this.cantidadP.TabIndex = 5;
            // 
            // cantidadV
            // 
            this.cantidadV.Location = new System.Drawing.Point(237, 373);
            this.cantidadV.Maximum = new decimal(new int[] {
            285,
            0,
            0,
            0});
            this.cantidadV.Name = "cantidadV";
            this.cantidadV.Size = new System.Drawing.Size(73, 22);
            this.cantidadV.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID TIENDA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "NOMBRE TIENDA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(316, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "máx. 360";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(317, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "máx. 810";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(319, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "máx. 285";
            // 
            // CapturaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cantidadV);
            this.Controls.Add(this.cantidadP);
            this.Controls.Add(this.cantidadR);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.label1);
            this.Name = "CapturaPedidos";
            this.Text = "CapturaPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.cantidadR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.NumericUpDown cantidadR;
        private System.Windows.Forms.NumericUpDown cantidadP;
        private System.Windows.Forms.NumericUpDown cantidadV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}