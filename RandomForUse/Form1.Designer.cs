namespace RandomForUse
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
            RandomGroupBox1 = new GroupBox();
            RandomTxt2 = new TextBox();
            RandomTxt1 = new TextBox();
            RandomMonthCalendar1 = new MonthCalendar();
            RandomBtn = new Button();
            RandomGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // RandomGroupBox1
            // 
            RandomGroupBox1.Controls.Add(RandomTxt2);
            RandomGroupBox1.Controls.Add(RandomTxt1);
            RandomGroupBox1.Location = new Point(72, 63);
            RandomGroupBox1.Name = "RandomGroupBox1";
            RandomGroupBox1.Size = new Size(200, 145);
            RandomGroupBox1.TabIndex = 0;
            RandomGroupBox1.TabStop = false;
            RandomGroupBox1.Text = "The Random Group Box!!!";
            // 
            // RandomTxt2
            // 
            RandomTxt2.Location = new Point(20, 77);
            RandomTxt2.Name = "RandomTxt2";
            RandomTxt2.Size = new Size(100, 23);
            RandomTxt2.TabIndex = 1;
            // 
            // RandomTxt1
            // 
            RandomTxt1.Location = new Point(21, 34);
            RandomTxt1.Name = "RandomTxt1";
            RandomTxt1.Size = new Size(100, 23);
            RandomTxt1.TabIndex = 0;
            // 
            // RandomMonthCalendar1
            // 
            RandomMonthCalendar1.Location = new Point(323, 63);
            RandomMonthCalendar1.Name = "RandomMonthCalendar1";
            RandomMonthCalendar1.TabIndex = 1;
            // 
            // RandomBtn
            // 
            RandomBtn.Location = new Point(72, 238);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Size = new Size(250, 86);
            RandomBtn.TabIndex = 2;
            RandomBtn.Text = "The Random Button!";
            RandomBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RandomBtn);
            Controls.Add(RandomMonthCalendar1);
            Controls.Add(RandomGroupBox1);
            Name = "Form1";
            Text = "Form1";
            RandomGroupBox1.ResumeLayout(false);
            RandomGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RandomGroupBox1;
        private TextBox RandomTxt2;
        private TextBox RandomTxt1;
        private MonthCalendar RandomMonthCalendar1;
        private Button RandomBtn;
    }
}
