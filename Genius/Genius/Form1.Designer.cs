
namespace Genius
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
            this.lQuestion = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lQuestion
            // 
            this.lQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lQuestion.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lQuestion.Location = new System.Drawing.Point(0, 0);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(800, 156);
            this.lQuestion.TabIndex = 0;
            this.lQuestion.Text = "Вопрос";
            this.lQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbAnswer.Location = new System.Drawing.Point(251, 182);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(330, 42);
            this.tbAnswer.TabIndex = 1;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(454, 260);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(127, 29);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "следующий";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(251, 260);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(132, 29);
            this.bPrevious.TabIndex = 3;
            this.bPrevious.Text = "предыдущий";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bFinish
            // 
            this.bFinish.Location = new System.Drawing.Point(588, 260);
            this.bFinish.Name = "bFinish";
            this.bFinish.Size = new System.Drawing.Size(157, 29);
            this.bFinish.TabIndex = 4;
            this.bFinish.Text = "завершить тест";
            this.bFinish.UseVisualStyleBackColor = true;
            this.bFinish.Click += new System.EventHandler(this.bFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.bFinish);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lQuestion);
            this.Name = "Form1";
            this.Text = "Тест \"Гений вы или идиот?\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bFinish;
    }
}

