namespace scratchpad__
{
    partial class FindAndReplaceDialog
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
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.repalceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.regexCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(61, 17);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(309, 21);
            this.findTextBox.TabIndex = 0;
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // repalceTextBox
            // 
            this.repalceTextBox.Location = new System.Drawing.Point(59, 54);
            this.repalceTextBox.Name = "repalceTextBox";
            this.repalceTextBox.Size = new System.Drawing.Size(311, 21);
            this.repalceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "查找";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "替换";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(395, 14);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "查找";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.find_button_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(395, 54);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 5;
            this.replaceButton.Text = "替换";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replace_button_clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.regexCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(477, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // regexCheckBox
            // 
            this.regexCheckBox.AutoSize = true;
            this.regexCheckBox.Location = new System.Drawing.Point(6, 20);
            this.regexCheckBox.Name = "regexCheckBox";
            this.regexCheckBox.Size = new System.Drawing.Size(48, 16);
            this.regexCheckBox.TabIndex = 0;
            this.regexCheckBox.Text = "正则";
            this.regexCheckBox.UseVisualStyleBackColor = true;
            this.regexCheckBox.CheckedChanged += new System.EventHandler(this.regexCheckBox_CheckedChanged);
            // 
            // FindAndReplaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 87);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repalceTextBox);
            this.Controls.Add(this.findTextBox);
            this.Name = "FindAndReplaceDialog";
            this.Text = "抓痕板-查找与替换";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.TextBox repalceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox regexCheckBox;
    }
}