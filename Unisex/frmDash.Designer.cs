namespace Unisex
{
    partial class frmDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDash));
            this.tbHairdresser = new System.Windows.Forms.TabControl();
            this.tbHair = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tbHairdresser.SuspendLayout();
            this.tbHair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHairdresser
            // 
            this.tbHairdresser.Controls.Add(this.tbHair);
            this.tbHairdresser.Controls.Add(this.tabPage2);
            this.tbHairdresser.Location = new System.Drawing.Point(13, 13);
            this.tbHairdresser.Name = "tbHairdresser";
            this.tbHairdresser.SelectedIndex = 0;
            this.tbHairdresser.Size = new System.Drawing.Size(775, 425);
            this.tbHairdresser.TabIndex = 0;
            // 
            // tbHair
            // 
            this.tbHair.Controls.Add(this.dgvClients);
            this.tbHair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbHair.Location = new System.Drawing.Point(4, 22);
            this.tbHair.Name = "tbHair";
            this.tbHair.Padding = new System.Windows.Forms.Padding(3);
            this.tbHair.Size = new System.Drawing.Size(767, 399);
            this.tbHair.TabIndex = 0;
            this.tbHair.Text = "Clients";
            this.tbHair.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(6, 6);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(488, 387);
            this.dgvClients.TabIndex = 0;
            // 
            // frmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(199)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbHairdresser);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDash";
            this.Text = "frmDash";
            this.Load += new System.EventHandler(this.frmDash_Load);
            this.tbHairdresser.ResumeLayout(false);
            this.tbHair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbHairdresser;
        private System.Windows.Forms.TabPage tbHair;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}