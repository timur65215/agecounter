﻿namespace WFT2
{
    partial class engn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dobbox = new System.Windows.Forms.TextBox();
            this.mobbox = new System.Windows.Forms.TextBox();
            this.yobbox = new System.Windows.Forms.TextBox();
            this.nexteng2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Month of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of Birth";
            // 
            // dobbox
            // 
            this.dobbox.Location = new System.Drawing.Point(280, 85);
            this.dobbox.Name = "dobbox";
            this.dobbox.Size = new System.Drawing.Size(100, 31);
            this.dobbox.TabIndex = 3;
            // 
            // mobbox
            // 
            this.mobbox.Location = new System.Drawing.Point(280, 142);
            this.mobbox.Name = "mobbox";
            this.mobbox.Size = new System.Drawing.Size(100, 31);
            this.mobbox.TabIndex = 4;
            // 
            // yobbox
            // 
            this.yobbox.Location = new System.Drawing.Point(280, 203);
            this.yobbox.Name = "yobbox";
            this.yobbox.Size = new System.Drawing.Size(100, 31);
            this.yobbox.TabIndex = 5;
            // 
            // nexteng2
            // 
            this.nexteng2.Location = new System.Drawing.Point(130, 277);
            this.nexteng2.Name = "nexteng2";
            this.nexteng2.Size = new System.Drawing.Size(241, 67);
            this.nexteng2.TabIndex = 6;
            this.nexteng2.Text = "Next";
            this.nexteng2.UseVisualStyleBackColor = true;
            this.nexteng2.Click += new System.EventHandler(this.nexteng2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // engn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nexteng2);
            this.Controls.Add(this.yobbox);
            this.Controls.Add(this.mobbox);
            this.Controls.Add(this.dobbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "engn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dobbox;
        private System.Windows.Forms.TextBox mobbox;
        private System.Windows.Forms.TextBox yobbox;
        private System.Windows.Forms.Button nexteng2;
        private System.Windows.Forms.Button button1;
    }
}