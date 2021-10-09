namespace adam_asmaca
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.harfPaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.alfabePaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(386, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(135, 47);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // harfPaneli
            // 
            this.harfPaneli.Location = new System.Drawing.Point(12, 179);
            this.harfPaneli.Name = "harfPaneli";
            this.harfPaneli.Size = new System.Drawing.Size(374, 62);
            this.harfPaneli.TabIndex = 4;
            // 
            // alfabePaneli
            // 
            this.alfabePaneli.Location = new System.Drawing.Point(12, 12);
            this.alfabePaneli.Name = "alfabePaneli";
            this.alfabePaneli.Size = new System.Drawing.Size(368, 161);
            this.alfabePaneli.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 216);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.alfabePaneli);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.harfPaneli);
            this.Name = "Form1";
            this.Text = "Adam Asmaca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.FlowLayoutPanel harfPaneli;
        private System.Windows.Forms.FlowLayoutPanel alfabePaneli;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

