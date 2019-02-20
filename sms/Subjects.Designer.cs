namespace sms
{
    partial class Subjects
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
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.subjectErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(234, 629);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1092, 629);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1092, 40);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.subjectTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.subjectErrorLabel);
            this.panel6.Size = new System.Drawing.Size(234, 589);
            this.panel6.Controls.SetChildIndex(this.subjectErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.subjectTxt, 0);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1092, 589);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subjects";
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(4, 224);
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(224, 25);
            this.subjectTxt.TabIndex = 2;
            this.subjectTxt.TextChanged += new System.EventHandler(this.subjectTxt_TextChanged);
            // 
            // subjectErrorLabel
            // 
            this.subjectErrorLabel.AutoSize = true;
            this.subjectErrorLabel.Location = new System.Drawing.Point(215, 204);
            this.subjectErrorLabel.Name = "subjectErrorLabel";
            this.subjectErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.subjectErrorLabel.TabIndex = 3;
            this.subjectErrorLabel.Text = "*";
            this.subjectErrorLabel.Visible = false;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 629);
            this.Name = "Subjects";
            this.Text = "Subjects";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subjectErrorLabel;
    }
}