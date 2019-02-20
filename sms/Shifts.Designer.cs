namespace sms
{
    partial class Shifts
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
            this.label2 = new System.Windows.Forms.Label();
            this.shiftNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shiftDD = new System.Windows.Forms.ComboBox();
            this.shiftErrorLabel = new System.Windows.Forms.Label();
            this.shiftNameErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(234, 626);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1095, 626);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.shiftNameErrorLabel);
            this.panel6.Controls.Add(this.shiftErrorLabel);
            this.panel6.Controls.Add(this.shiftDD);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.shiftNameTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(234, 586);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.shiftNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.shiftDD, 0);
            this.panel6.Controls.SetChildIndex(this.shiftErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.shiftNameErrorLabel, 0);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1095, 586);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shift Name";
            // 
            // shiftNameTxt
            // 
            this.shiftNameTxt.Location = new System.Drawing.Point(3, 238);
            this.shiftNameTxt.Name = "shiftNameTxt";
            this.shiftNameTxt.Size = new System.Drawing.Size(225, 25);
            this.shiftNameTxt.TabIndex = 2;
            this.shiftNameTxt.TextChanged += new System.EventHandler(this.shiftNameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shift";
            // 
            // shiftDD
            // 
            this.shiftDD.FormattingEnabled = true;
            this.shiftDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.shiftDD.Location = new System.Drawing.Point(3, 287);
            this.shiftDD.Name = "shiftDD";
            this.shiftDD.Size = new System.Drawing.Size(225, 25);
            this.shiftDD.TabIndex = 4;
            // 
            // shiftErrorLabel
            // 
            this.shiftErrorLabel.AutoSize = true;
            this.shiftErrorLabel.Location = new System.Drawing.Point(215, 266);
            this.shiftErrorLabel.Name = "shiftErrorLabel";
            this.shiftErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.shiftErrorLabel.TabIndex = 5;
            this.shiftErrorLabel.Text = "*";
            this.shiftErrorLabel.Visible = false;
            // 
            // shiftNameErrorLabel
            // 
            this.shiftNameErrorLabel.AutoSize = true;
            this.shiftNameErrorLabel.Location = new System.Drawing.Point(215, 217);
            this.shiftNameErrorLabel.Name = "shiftNameErrorLabel";
            this.shiftNameErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.shiftNameErrorLabel.TabIndex = 6;
            this.shiftNameErrorLabel.Text = "*";
            this.shiftNameErrorLabel.Visible = false;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 626);
            this.Name = "Shifts";
            this.Text = "Shifts";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox shiftNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shiftDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label shiftNameErrorLabel;
        private System.Windows.Forms.Label shiftErrorLabel;
    }
}