namespace WFT2
{
    partial class start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.russianl = new System.Windows.Forms.Button();
            this.ukranianl = new System.Windows.Forms.Button();
            this.englishl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // russianl
            // 
            this.russianl.BackColor = System.Drawing.SystemColors.Control;
            this.russianl.FlatAppearance.BorderSize = 0;
            this.russianl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.russianl.Location = new System.Drawing.Point(109, 100);
            this.russianl.Name = "russianl";
            this.russianl.Size = new System.Drawing.Size(309, 81);
            this.russianl.TabIndex = 0;
            this.russianl.Text = "Русский";
            this.russianl.UseVisualStyleBackColor = false;
            this.russianl.Click += new System.EventHandler(this.button1_Click);
            // 
            // ukranianl
            // 
            this.ukranianl.BackColor = System.Drawing.SystemColors.Control;
            this.ukranianl.FlatAppearance.BorderSize = 0;
            this.ukranianl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ukranianl.Location = new System.Drawing.Point(109, 187);
            this.ukranianl.Name = "ukranianl";
            this.ukranianl.Size = new System.Drawing.Size(309, 81);
            this.ukranianl.TabIndex = 1;
            this.ukranianl.Text = "Українська";
            this.ukranianl.UseVisualStyleBackColor = false;
            this.ukranianl.Click += new System.EventHandler(this.ukranianl_Click);
            // 
            // englishl
            // 
            this.englishl.BackColor = System.Drawing.SystemColors.Control;
            this.englishl.FlatAppearance.BorderSize = 0;
            this.englishl.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.englishl.Location = new System.Drawing.Point(109, 274);
            this.englishl.Name = "englishl";
            this.englishl.Size = new System.Drawing.Size(309, 81);
            this.englishl.TabIndex = 2;
            this.englishl.Text = "English";
            this.englishl.UseVisualStyleBackColor = false;
            this.englishl.Click += new System.EventHandler(this.englishl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select language:";
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.englishl);
            this.Controls.Add(this.ukranianl);
            this.Controls.Add(this.russianl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "start";
            this.Opacity = 0.9D;
            this.Text = "Language chooser";
            this.Load += new System.EventHandler(this.start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button russianl;
        private System.Windows.Forms.Button ukranianl;
        private System.Windows.Forms.Button englishl;
        private System.Windows.Forms.Label label1;
    }
}

