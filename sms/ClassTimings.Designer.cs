namespace sms
{
    partial class ClassTimings
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
            this.timeNameTxt = new System.Windows.Forms.TextBox();
            this.fromTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dayDD = new System.Windows.Forms.ComboBox();
            this.timeErrorLabel = new System.Windows.Forms.Label();
            this.fromErrorLabel = new System.Windows.Forms.Label();
            this.toErrorLabel = new System.Windows.Forms.Label();
            this.dayErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(234, 627);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1095, 627);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dayErrorLabel);
            this.panel6.Controls.Add(this.toErrorLabel);
            this.panel6.Controls.Add(this.fromErrorLabel);
            this.panel6.Controls.Add(this.timeErrorLabel);
            this.panel6.Controls.Add(this.dayDD);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.toTxt);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.fromTxt);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.timeNameTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(234, 587);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.timeNameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.fromTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label4, 0);
            this.panel6.Controls.SetChildIndex(this.toTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label5, 0);
            this.panel6.Controls.SetChildIndex(this.dayDD, 0);
            this.panel6.Controls.SetChildIndex(this.timeErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.fromErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.toErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.dayErrorLabel, 0);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1095, 587);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Name";
            // 
            // timeNameTxt
            // 
            this.timeNameTxt.Location = new System.Drawing.Point(4, 187);
            this.timeNameTxt.Name = "timeNameTxt";
            this.timeNameTxt.Size = new System.Drawing.Size(224, 25);
            this.timeNameTxt.TabIndex = 2;
            this.timeNameTxt.TextChanged += new System.EventHandler(this.timeNameTxt_TextChanged);
            // 
            // fromTxt
            // 
            this.fromTxt.Location = new System.Drawing.Point(4, 238);
            this.fromTxt.Name = "fromTxt";
            this.fromTxt.Size = new System.Drawing.Size(224, 25);
            this.fromTxt.TabIndex = 4;
            this.fromTxt.TextChanged += new System.EventHandler(this.fromTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // toTxt
            // 
            this.toTxt.Location = new System.Drawing.Point(5, 291);
            this.toTxt.Name = "toTxt";
            this.toTxt.Size = new System.Drawing.Size(224, 25);
            this.toTxt.TabIndex = 6;
            this.toTxt.TextChanged += new System.EventHandler(this.toTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Day";
            // 
            // dayDD
            // 
            this.dayDD.FormattingEnabled = true;
            this.dayDD.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayDD.Location = new System.Drawing.Point(5, 340);
            this.dayDD.Name = "dayDD";
            this.dayDD.Size = new System.Drawing.Size(223, 25);
            this.dayDD.TabIndex = 8;
            // 
            // timeErrorLabel
            // 
            this.timeErrorLabel.AutoSize = true;
            this.timeErrorLabel.Location = new System.Drawing.Point(218, 167);
            this.timeErrorLabel.Name = "timeErrorLabel";
            this.timeErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.timeErrorLabel.TabIndex = 9;
            this.timeErrorLabel.Text = "*";
            this.timeErrorLabel.Visible = false;
            // 
            // fromErrorLabel
            // 
            this.fromErrorLabel.AutoSize = true;
            this.fromErrorLabel.Location = new System.Drawing.Point(215, 217);
            this.fromErrorLabel.Name = "fromErrorLabel";
            this.fromErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.fromErrorLabel.TabIndex = 10;
            this.fromErrorLabel.Text = "*";
            this.fromErrorLabel.Visible = false;
            // 
            // toErrorLabel
            // 
            this.toErrorLabel.AutoSize = true;
            this.toErrorLabel.Location = new System.Drawing.Point(215, 266);
            this.toErrorLabel.Name = "toErrorLabel";
            this.toErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.toErrorLabel.TabIndex = 11;
            this.toErrorLabel.Text = "*";
            this.toErrorLabel.Visible = false;
            // 
            // dayErrorLabel
            // 
            this.dayErrorLabel.AutoSize = true;
            this.dayErrorLabel.Location = new System.Drawing.Point(215, 320);
            this.dayErrorLabel.Name = "dayErrorLabel";
            this.dayErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.dayErrorLabel.TabIndex = 12;
            this.dayErrorLabel.Text = "*";
            this.dayErrorLabel.Visible = false;
            // 
            // ClassTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 627);
            this.Name = "ClassTimings";
            this.Text = "ClassTimings";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fromTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dayDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dayErrorLabel;
        private System.Windows.Forms.Label toErrorLabel;
        private System.Windows.Forms.Label fromErrorLabel;
        private System.Windows.Forms.Label timeErrorLabel;
    }
}