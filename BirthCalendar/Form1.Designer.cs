
namespace BirthCalendar
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
            this.textBox_Day = new System.Windows.Forms.TextBox();
            this.textBox_Month = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // textBox_Day
            // 
            this.textBox_Day.Location = new System.Drawing.Point(30, 37);
            this.textBox_Day.Name = "textBox_Day";
            this.textBox_Day.Size = new System.Drawing.Size(67, 47);
            this.textBox_Day.TabIndex = 0;
            this.textBox_Day.Text = "1";
            this.textBox_Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Day.TextChanged += new System.EventHandler(this.textBox_Day_TextChanged);
            // 
            // textBox_Month
            // 
            this.textBox_Month.Location = new System.Drawing.Point(145, 37);
            this.textBox_Month.Name = "textBox_Month";
            this.textBox_Month.Size = new System.Drawing.Size(67, 47);
            this.textBox_Month.TabIndex = 1;
            this.textBox_Month.Text = "1";
            this.textBox_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Month.TextChanged += new System.EventHandler(this.textBox_Month_TextChanged);
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(264, 37);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(119, 47);
            this.textBox_year.TabIndex = 2;
            this.textBox_year.Text = "1999";
            this.textBox_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_year.TextChanged += new System.EventHandler(this.textBox_year_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(422, 37);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_Month);
            this.Controls.Add(this.textBox_Day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Day;
        private System.Windows.Forms.TextBox textBox_Month;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

