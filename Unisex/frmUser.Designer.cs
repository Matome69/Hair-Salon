namespace Unisex
{
    partial class frmUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbBook = new System.Windows.Forms.TabPage();
            this.btnBook = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbBook);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tbBook
            // 
            this.tbBook.Controls.Add(this.btnBook);
            this.tbBook.Controls.Add(this.cbTime);
            this.tbBook.Controls.Add(this.label3);
            this.tbBook.Controls.Add(this.label2);
            this.tbBook.Controls.Add(this.cbService);
            this.tbBook.Controls.Add(this.monthCalendar1);
            this.tbBook.Controls.Add(this.label1);
            this.tbBook.Location = new System.Drawing.Point(4, 22);
            this.tbBook.Name = "tbBook";
            this.tbBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbBook.Size = new System.Drawing.Size(350, 400);
            this.tbBook.TabIndex = 0;
            this.tbBook.Text = "Appointment";
            this.tbBook.UseVisualStyleBackColor = true;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(9, 330);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(9, 286);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(121, 21);
            this.cbTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date ";
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(9, 34);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(121, 21);
            this.cbService.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 99);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of service:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUser";
            this.Text = "Unisex";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbBook.ResumeLayout(false);
            this.tbBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbBook;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}