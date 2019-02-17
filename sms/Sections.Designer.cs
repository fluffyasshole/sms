namespace sms
{
    partial class Sections
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.secnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.secstatusDD = new System.Windows.Forms.ComboBox();
            this.secstatusErrorLabel = new System.Windows.Forms.Label();
            this.secnameErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(234, 622);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1091, 622);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1091, 40);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.secnameErrorLabel);
            this.panel6.Controls.Add(this.secstatusErrorLabel);
            this.panel6.Controls.Add(this.secstatusDD);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.secnameTxt);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Size = new System.Drawing.Size(234, 582);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.secnameTxt, 0);
            this.panel6.Controls.SetChildIndex(this.label3, 0);
            this.panel6.Controls.SetChildIndex(this.secstatusDD, 0);
            this.panel6.Controls.SetChildIndex(this.secstatusErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.secnameErrorLabel, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(1091, 582);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section Name";
            // 
            // secnameTxt
            // 
            this.secnameTxt.Location = new System.Drawing.Point(4, 123);
            this.secnameTxt.Name = "secnameTxt";
            this.secnameTxt.Size = new System.Drawing.Size(224, 25);
            this.secnameTxt.TabIndex = 2;
            this.secnameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // secstatusDD
            // 
            this.secstatusDD.FormattingEnabled = true;
            this.secstatusDD.Items.AddRange(new object[] {
            "Active",
            "Draft"});
            this.secstatusDD.Location = new System.Drawing.Point(4, 172);
            this.secstatusDD.Name = "secstatusDD";
            this.secstatusDD.Size = new System.Drawing.Size(224, 25);
            this.secstatusDD.TabIndex = 4;
            this.secstatusDD.SelectedIndexChanged += new System.EventHandler(this.secstatusDD_SelectedIndexChanged);
            // 
            // secstatusErrorLabel
            // 
            this.secstatusErrorLabel.AutoSize = true;
            this.secstatusErrorLabel.Location = new System.Drawing.Point(215, 152);
            this.secstatusErrorLabel.Name = "secstatusErrorLabel";
            this.secstatusErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.secstatusErrorLabel.TabIndex = 7;
            this.secstatusErrorLabel.Text = "*";
            this.secstatusErrorLabel.Visible = false;
            // 
            // secnameErrorLabel
            // 
            this.secnameErrorLabel.AutoSize = true;
            this.secnameErrorLabel.Location = new System.Drawing.Point(215, 102);
            this.secnameErrorLabel.Name = "secnameErrorLabel";
            this.secnameErrorLabel.Size = new System.Drawing.Size(13, 17);
            this.secnameErrorLabel.TabIndex = 8;
            this.secnameErrorLabel.Text = "*";
            this.secnameErrorLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1091, 532);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.sectionIDGV,
            this.sectionGV,
            this.statusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "S. No";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 62;
            // 
            // sectionIDGV
            // 
            this.sectionIDGV.HeaderText = "Section ID";
            this.sectionIDGV.Name = "sectionIDGV";
            this.sectionIDGV.ReadOnly = true;
            this.sectionIDGV.Visible = false;
            // 
            // sectionGV
            // 
            this.sectionGV.HeaderText = "Section";
            this.sectionGV.Name = "sectionGV";
            this.sectionGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 622);
            this.Name = "Sections";
            this.Text = "Sections";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label secnameErrorLabel;
        private System.Windows.Forms.Label secstatusErrorLabel;
        private System.Windows.Forms.ComboBox secstatusDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox secnameTxt;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}