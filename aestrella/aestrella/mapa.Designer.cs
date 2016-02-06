namespace aestrella
{
    partial class mapa
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelbotones = new System.Windows.Forms.Panel();
            this.nodoinicialr = new System.Windows.Forms.RadioButton();
            this.bloqueor = new System.Windows.Forms.RadioButton();
            this.nodofinalr = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelbotones
            // 
            this.panelbotones.Location = new System.Drawing.Point(103, 12);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(169, 100);
            this.panelbotones.TabIndex = 1;
            // 
            // nodoinicialr
            // 
            this.nodoinicialr.AutoSize = true;
            this.nodoinicialr.Location = new System.Drawing.Point(12, 38);
            this.nodoinicialr.Name = "nodoinicialr";
            this.nodoinicialr.Size = new System.Drawing.Size(80, 17);
            this.nodoinicialr.TabIndex = 2;
            this.nodoinicialr.Text = "Nodo inicial";
            this.nodoinicialr.UseVisualStyleBackColor = true;
            this.nodoinicialr.CheckedChanged += new System.EventHandler(this.nodoinicialr_CheckedChanged);
            // 
            // bloqueor
            // 
            this.bloqueor.AutoSize = true;
            this.bloqueor.Location = new System.Drawing.Point(13, 86);
            this.bloqueor.Name = "bloqueor";
            this.bloqueor.Size = new System.Drawing.Size(64, 17);
            this.bloqueor.TabIndex = 4;
            this.bloqueor.Text = "Bloqueo";
            this.bloqueor.UseVisualStyleBackColor = true;
            this.bloqueor.CheckedChanged += new System.EventHandler(this.bloqueor_CheckedChanged);
            // 
            // nodofinalr
            // 
            this.nodofinalr.AutoSize = true;
            this.nodofinalr.Location = new System.Drawing.Point(12, 63);
            this.nodofinalr.Name = "nodofinalr";
            this.nodofinalr.Size = new System.Drawing.Size(85, 17);
            this.nodofinalr.TabIndex = 5;
            this.nodofinalr.TabStop = true;
            this.nodofinalr.Text = "radioButton1";
            this.nodofinalr.UseVisualStyleBackColor = true;
            this.nodofinalr.CheckedChanged += new System.EventHandler(this.nodofinalr_CheckedChanged_1);
            // 
            // mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nodofinalr);
            this.Controls.Add(this.bloqueor);
            this.Controls.Add(this.nodoinicialr);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.button1);
            this.Name = "mapa";
            this.Text = "mapa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mapa_FormClosed);
            this.Load += new System.EventHandler(this.mapa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelbotones;
        private System.Windows.Forms.RadioButton nodoinicialr;
        private System.Windows.Forms.RadioButton bloqueor;
        private System.Windows.Forms.RadioButton nodofinalr;
    }
}