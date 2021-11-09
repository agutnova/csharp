namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRect = new System.Windows.Forms.Button();
            this.bEllipse = new System.Windows.Forms.Button();
            this.bLine = new System.Windows.Forms.Button();
            this.bPen = new System.Windows.Forms.Button();
            this.pbWorkarea = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pForeColor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkarea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pForeColor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bRect);
            this.panel1.Controls.Add(this.bEllipse);
            this.panel1.Controls.Add(this.bLine);
            this.panel1.Controls.Add(this.bPen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 56);
            this.panel1.TabIndex = 0;
            // 
            // bRect
            // 
            this.bRect.Image = ((System.Drawing.Image)(resources.GetObject("bRect.Image")));
            this.bRect.Location = new System.Drawing.Point(126, 12);
            this.bRect.Name = "bRect";
            this.bRect.Size = new System.Drawing.Size(32, 31);
            this.bRect.TabIndex = 3;
            this.bRect.UseVisualStyleBackColor = true;
            this.bRect.Click += new System.EventHandler(this.bRect_Click);
            // 
            // bEllipse
            // 
            this.bEllipse.Image = ((System.Drawing.Image)(resources.GetObject("bEllipse.Image")));
            this.bEllipse.Location = new System.Drawing.Point(88, 12);
            this.bEllipse.Name = "bEllipse";
            this.bEllipse.Size = new System.Drawing.Size(32, 31);
            this.bEllipse.TabIndex = 2;
            this.bEllipse.UseVisualStyleBackColor = true;
            this.bEllipse.Click += new System.EventHandler(this.bEllipse_Click);
            // 
            // bLine
            // 
            this.bLine.Image = ((System.Drawing.Image)(resources.GetObject("bLine.Image")));
            this.bLine.Location = new System.Drawing.Point(50, 12);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(32, 31);
            this.bLine.TabIndex = 1;
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // bPen
            // 
            this.bPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPen.Image = ((System.Drawing.Image)(resources.GetObject("bPen.Image")));
            this.bPen.Location = new System.Drawing.Point(12, 12);
            this.bPen.Name = "bPen";
            this.bPen.Size = new System.Drawing.Size(32, 31);
            this.bPen.TabIndex = 0;
            this.bPen.UseVisualStyleBackColor = true;
            this.bPen.Click += new System.EventHandler(this.bPen_Click);
            // 
            // pbWorkarea
            // 
            this.pbWorkarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbWorkarea.Location = new System.Drawing.Point(0, 56);
            this.pbWorkarea.Name = "pbWorkarea";
            this.pbWorkarea.Size = new System.Drawing.Size(801, 472);
            this.pbWorkarea.TabIndex = 1;
            this.pbWorkarea.TabStop = false;
            this.pbWorkarea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbWorkarea_MouseDown);
            this.pbWorkarea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbWorkarea_MouseMove);
            this.pbWorkarea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbWorkarea_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pForeColor
            // 
            this.pForeColor.Location = new System.Drawing.Point(254, 12);
            this.pForeColor.Name = "pForeColor";
            this.pForeColor.Size = new System.Drawing.Size(61, 29);
            this.pForeColor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.pbWorkarea);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Рисовалка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWorkarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPen;
        private System.Windows.Forms.PictureBox pbWorkarea;
        private System.Windows.Forms.Button bRect;
        private System.Windows.Forms.Button bEllipse;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pForeColor;
    }
}

