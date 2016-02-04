namespace aestrella
{
    partial class menu
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numerocollabel = new System.Windows.Forms.Label();
            this.numerofilcol = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textpesoc = new System.Windows.Forms.TextBox();
            this.textpesod = new System.Windows.Forms.TextBox();
            this.labelcruz = new System.Windows.Forms.Label();
            this.labeldiagonal = new System.Windows.Forms.Label();
            this.buttonaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 29);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numerocollabel
            // 
            this.numerocollabel.AutoSize = true;
            this.numerocollabel.Location = new System.Drawing.Point(13, 29);
            this.numerocollabel.Name = "numerocollabel";
            this.numerocollabel.Size = new System.Drawing.Size(56, 13);
            this.numerocollabel.TabIndex = 1;
            this.numerocollabel.Text = "Columnas:";
            // 
            // numerofilcol
            // 
            this.numerofilcol.AutoSize = true;
            this.numerofilcol.Location = new System.Drawing.Point(13, 69);
            this.numerofilcol.Name = "numerofilcol";
            this.numerofilcol.Size = new System.Drawing.Size(31, 13);
            this.numerofilcol.TabIndex = 2;
            this.numerofilcol.Text = "Filas:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(95, 67);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textpesoc
            // 
            this.textpesoc.Location = new System.Drawing.Point(95, 113);
            this.textpesoc.Name = "textpesoc";
            this.textpesoc.Size = new System.Drawing.Size(79, 20);
            this.textpesoc.TabIndex = 4;
            // 
            // textpesod
            // 
            this.textpesod.Location = new System.Drawing.Point(95, 152);
            this.textpesod.Name = "textpesod";
            this.textpesod.Size = new System.Drawing.Size(79, 20);
            this.textpesod.TabIndex = 5;
            // 
            // labelcruz
            // 
            this.labelcruz.AutoSize = true;
            this.labelcruz.Location = new System.Drawing.Point(13, 116);
            this.labelcruz.Name = "labelcruz";
            this.labelcruz.Size = new System.Drawing.Size(57, 13);
            this.labelcruz.TabIndex = 6;
            this.labelcruz.Text = "Peso cruz:";
            // 
            // labeldiagonal
            // 
            this.labeldiagonal.AutoSize = true;
            this.labeldiagonal.Location = new System.Drawing.Point(13, 155);
            this.labeldiagonal.Name = "labeldiagonal";
            this.labeldiagonal.Size = new System.Drawing.Size(77, 13);
            this.labeldiagonal.TabIndex = 7;
            this.labeldiagonal.Text = "Peso diagonal:";
            // 
            // buttonaceptar
            // 
            this.buttonaceptar.Location = new System.Drawing.Point(55, 201);
            this.buttonaceptar.Name = "buttonaceptar";
            this.buttonaceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonaceptar.TabIndex = 8;
            this.buttonaceptar.Text = "Aceptar";
            this.buttonaceptar.UseVisualStyleBackColor = true;
            this.buttonaceptar.Click += new System.EventHandler(this.buttonaceptar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 261);
            this.Controls.Add(this.buttonaceptar);
            this.Controls.Add(this.labeldiagonal);
            this.Controls.Add(this.labelcruz);
            this.Controls.Add(this.textpesod);
            this.Controls.Add(this.textpesoc);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numerofilcol);
            this.Controls.Add(this.numerocollabel);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label numerocollabel;
        private System.Windows.Forms.Label numerofilcol;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textpesoc;
        private System.Windows.Forms.TextBox textpesod;
        private System.Windows.Forms.Label labeldiagonal;
        private System.Windows.Forms.Label labelcruz;
        private System.Windows.Forms.Button buttonaceptar;
    }
}

