namespace Expression
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
            this.label1 = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.tbExpression = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите выражение";
            // 
            // lResult
            // 
            this.lResult.Location = new System.Drawing.Point(12, 234);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(454, 40);
            this.lResult.TabIndex = 1;
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbExpression
            // 
            this.tbExpression.Location = new System.Drawing.Point(12, 99);
            this.tbExpression.Name = "tbExpression";
            this.tbExpression.Size = new System.Drawing.Size(454, 23);
            this.tbExpression.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbExpression);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Калькулятор выражений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lResult;
        private TextBox tbExpression;
        private Button button1;
    }
}