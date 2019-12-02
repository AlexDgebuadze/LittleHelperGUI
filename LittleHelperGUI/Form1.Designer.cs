namespace LittleHelperGUI
{
    partial class SetUp
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
            this.start_btn = new System.Windows.Forms.Button();
            this.FolderNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBro = new System.Windows.Forms.FolderBrowserDialog();
            this.Dir_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boostrap_combo = new System.Windows.Forms.ComboBox();
            this.jquery_combo = new System.Windows.Forms.ComboBox();
            this.DirectoryBox = new System.Windows.Forms.TextBox();
            this.SassCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(84, 209);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // FolderNameBox
            // 
            this.FolderNameBox.Location = new System.Drawing.Point(60, 35);
            this.FolderNameBox.Name = "FolderNameBox";
            this.FolderNameBox.Size = new System.Drawing.Size(118, 20);
            this.FolderNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory Name :";
            // 
            // Dir_button
            // 
            this.Dir_button.Location = new System.Drawing.Point(184, 89);
            this.Dir_button.Name = "Dir_button";
            this.Dir_button.Size = new System.Drawing.Size(40, 22);
            this.Dir_button.TabIndex = 4;
            this.Dir_button.Text = "Path";
            this.Dir_button.UseVisualStyleBackColor = true;
            this.Dir_button.Click += new System.EventHandler(this.Dir_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder Name :";
            // 
            // boostrap_combo
            // 
            this.boostrap_combo.FormattingEnabled = true;
            this.boostrap_combo.Location = new System.Drawing.Point(46, 127);
            this.boostrap_combo.Name = "boostrap_combo";
            this.boostrap_combo.Size = new System.Drawing.Size(69, 21);
            this.boostrap_combo.TabIndex = 7;
            this.boostrap_combo.Text = "Bootstrap";
            // 
            // jquery_combo
            // 
            this.jquery_combo.FormattingEnabled = true;
            this.jquery_combo.Location = new System.Drawing.Point(132, 127);
            this.jquery_combo.Name = "jquery_combo";
            this.jquery_combo.Size = new System.Drawing.Size(67, 21);
            this.jquery_combo.TabIndex = 8;
            this.jquery_combo.Text = "JQuery";
            // 
            // DirectoryBox
            // 
            this.DirectoryBox.Location = new System.Drawing.Point(60, 89);
            this.DirectoryBox.Name = "DirectoryBox";
            this.DirectoryBox.Size = new System.Drawing.Size(118, 20);
            this.DirectoryBox.TabIndex = 9;
            // 
            // SassCheck
            // 
            this.SassCheck.AutoSize = true;
            this.SassCheck.Location = new System.Drawing.Point(97, 163);
            this.SassCheck.Name = "SassCheck";
            this.SassCheck.Size = new System.Drawing.Size(49, 17);
            this.SassCheck.TabIndex = 10;
            this.SassCheck.Text = "Sass";
            this.SassCheck.UseVisualStyleBackColor = true;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 245);
            this.Controls.Add(this.SassCheck);
            this.Controls.Add(this.DirectoryBox);
            this.Controls.Add(this.jquery_combo);
            this.Controls.Add(this.boostrap_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dir_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderNameBox);
            this.Controls.Add(this.start_btn);
            this.Name = "SetUp";
            this.Text = "SetUp";
            this.Load += new System.EventHandler(this.SetUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox FolderNameBox;
        private System.Windows.Forms.TextBox Dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBro;
        private System.Windows.Forms.Button Dir_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boostrap_combo;
        private System.Windows.Forms.ComboBox jquery_combo;
        private System.Windows.Forms.TextBox DirectoryBox;
        private System.Windows.Forms.CheckBox SassCheck;
    }
}

