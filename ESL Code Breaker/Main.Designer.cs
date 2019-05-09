namespace ESL_Bomb
{
    partial class Main
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
            this.ngBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dnBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.numberLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabooBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ngBtn
            // 
            this.ngBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngBtn.Location = new System.Drawing.Point(12, 108);
            this.ngBtn.Name = "ngBtn";
            this.ngBtn.Size = new System.Drawing.Size(260, 53);
            this.ngBtn.TabIndex = 0;
            this.ngBtn.Text = "Code Challenge";
            this.ngBtn.UseVisualStyleBackColor = true;
            this.ngBtn.Click += new System.EventHandler(this.ngBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.Location = new System.Drawing.Point(12, 226);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(260, 53);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(197, 326);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dnBtn);
            this.groupBox1.Controls.Add(this.upBtn);
            this.groupBox1.Controls.Add(this.numberLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // dnBtn
            // 
            this.dnBtn.Enabled = false;
            this.dnBtn.Location = new System.Drawing.Point(217, 60);
            this.dnBtn.Name = "dnBtn";
            this.dnBtn.Size = new System.Drawing.Size(37, 23);
            this.dnBtn.TabIndex = 3;
            this.dnBtn.Text = "DN";
            this.dnBtn.UseVisualStyleBackColor = true;
            this.dnBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(217, 11);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(37, 23);
            this.upBtn.TabIndex = 2;
            this.upBtn.Text = "UP";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(225, 37);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(18, 20);
            this.numberLbl.TabIndex = 1;
            this.numberLbl.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puzzle";
            // 
            // tabooBtn
            // 
            this.tabooBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabooBtn.Location = new System.Drawing.Point(12, 167);
            this.tabooBtn.Name = "tabooBtn";
            this.tabooBtn.Size = new System.Drawing.Size(260, 53);
            this.tabooBtn.TabIndex = 4;
            this.tabooBtn.Text = "Taboo";
            this.tabooBtn.UseVisualStyleBackColor = true;
            this.tabooBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.tabooBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.ngBtn);
            this.Name = "Main";
            this.Text = "ESL Code Breaker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ngBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dnBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Button tabooBtn;
    }
}

