namespace demon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbVessels = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbVessels)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVessels
            // 
            this.pbVessels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVessels.Location = new System.Drawing.Point(0, 0);
            this.pbVessels.Name = "pbVessels";
            this.pbVessels.Size = new System.Drawing.Size(755, 440);
            this.pbVessels.TabIndex = 0;
            this.pbVessels.TabStop = false;
            this.pbVessels.Click += new System.EventHandler(this.pbVessels_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 440);
            this.Controls.Add(this.pbVessels);
            this.Name = "Form1";
            this.Text = "Демон Максвелла";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVessels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbVessels;
        private System.Windows.Forms.Timer timer1;
    }
}