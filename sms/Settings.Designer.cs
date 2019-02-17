namespace sms
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.datasourceTxt = new System.Windows.Forms.TextBox();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.datasourceErrorLabel = new System.Windows.Forms.Label();
            this.dbErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1097, 653);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1097, 40);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.saveBtn);
            this.panel6.Controls.Add(this.isCB);
            this.panel6.Controls.Add(this.passTxt);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.usernameTxt);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.dbTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.datasourceTxt);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.passErrorLabel);
            this.panel6.Controls.Add(this.usernameErrorLabel);
            this.panel6.Controls.Add(this.dbErrorLabel);
            this.panel6.Controls.Add(this.datasourceErrorLabel);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1097, 613);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source";
            // 
            // datasourceTxt
            // 
            this.datasourceTxt.Location = new System.Drawing.Point(4, 230);
            this.datasourceTxt.MaxLength = 50;
            this.datasourceTxt.Name = "datasourceTxt";
            this.datasourceTxt.Size = new System.Drawing.Size(224, 25);
            this.datasourceTxt.TabIndex = 1;
            this.datasourceTxt.TextChanged += new System.EventHandler(this.datasourceTxt_TextChanged);
            // 
            // dbTxt
            // 
            this.dbTxt.Location = new System.Drawing.Point(3, 280);
            this.dbTxt.MaxLength = 50;
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(224, 25);
            this.dbTxt.TabIndex = 2;
            this.dbTxt.TextChanged += new System.EventHandler(this.dbTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(3, 334);
            this.usernameTxt.MaxLength = 50;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(224, 25);
            this.usernameTxt.TabIndex = 3;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(3, 382);
            this.passTxt.MaxLength = 50;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(224, 25);
            this.passTxt.TabIndex = 4;
            this.passTxt.UseSystemPasswordChar = true;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(4, 414);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(139, 21);
            this.isCB.TabIndex = 5;
            this.isCB.Text = "Integerated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(3, 442);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(224, 32);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // datasourceErrorLabel
            // 
            this.datasourceErrorLabel.AutoSize = true;
            this.datasourceErrorLabel.Location = new System.Drawing.Point(214, 210);
            this.datasourceErrorLabel.Name = "datasourceErrorLabel";
            this.datasourceErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.datasourceErrorLabel.TabIndex = 7;
            this.datasourceErrorLabel.Text = "*";
            this.datasourceErrorLabel.Visible = false;
            // 
            // dbErrorLabel
            // 
            this.dbErrorLabel.AutoSize = true;
            this.dbErrorLabel.Location = new System.Drawing.Point(214, 260);
            this.dbErrorLabel.Name = "dbErrorLabel";
            this.dbErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.dbErrorLabel.TabIndex = 8;
            this.dbErrorLabel.Text = "*";
            this.dbErrorLabel.Visible = false;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Location = new System.Drawing.Point(214, 314);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.usernameErrorLabel.TabIndex = 9;
            this.usernameErrorLabel.Text = "*";
            this.usernameErrorLabel.Visible = false;
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.Location = new System.Drawing.Point(214, 362);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.passErrorLabel.TabIndex = 10;
            this.passErrorLabel.Text = "*";
            this.passErrorLabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 653);
            this.ControlBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datasourceTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label dbErrorLabel;
        private System.Windows.Forms.Label datasourceErrorLabel;
    }
}