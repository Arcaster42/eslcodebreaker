namespace ESL_Bomb
{
    partial class Taboo
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
            this.passBtn = new System.Windows.Forms.Button();
            this.pointBtn = new System.Windows.Forms.Button();
            this.pointLbl = new System.Windows.Forms.Label();
            this.keyLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bad3Lbl = new System.Windows.Forms.Label();
            this.bad2Lbl = new System.Windows.Forms.Label();
            this.bad1Lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // passBtn
            // 
            this.passBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passBtn.Location = new System.Drawing.Point(12, 286);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(117, 56);
            this.passBtn.TabIndex = 0;
            this.passBtn.Text = "PASS";
            this.passBtn.UseVisualStyleBackColor = true;
            // 
            // pointBtn
            // 
            this.pointBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointBtn.Location = new System.Drawing.Point(155, 286);
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.Size = new System.Drawing.Size(117, 56);
            this.pointBtn.TabIndex = 1;
            this.pointBtn.Text = "POINT";
            this.pointBtn.UseVisualStyleBackColor = true;
            this.pointBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pointLbl
            // 
            this.pointLbl.AutoSize = true;
            this.pointLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLbl.Location = new System.Drawing.Point(132, 252);
            this.pointLbl.Name = "pointLbl";
            this.pointLbl.Size = new System.Drawing.Size(24, 26);
            this.pointLbl.TabIndex = 2;
            this.pointLbl.Text = "0";
            this.pointLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLbl.Location = new System.Drawing.Point(32, 27);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(132, 31);
            this.keyLbl.TabIndex = 3;
            this.keyLbl.Text = "Key Word";
            this.keyLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyLbl);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Word";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bad3Lbl);
            this.groupBox2.Controls.Add(this.bad2Lbl);
            this.groupBox2.Controls.Add(this.bad1Lbl);
            this.groupBox2.Location = new System.Drawing.Point(43, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 116);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banned Words";
            // 
            // bad3Lbl
            // 
            this.bad3Lbl.AutoSize = true;
            this.bad3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bad3Lbl.Location = new System.Drawing.Point(65, 73);
            this.bad3Lbl.Name = "bad3Lbl";
            this.bad3Lbl.Size = new System.Drawing.Size(73, 24);
            this.bad3Lbl.TabIndex = 5;
            this.bad3Lbl.Text = "B Word";
            this.bad3Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bad2Lbl
            // 
            this.bad2Lbl.AutoSize = true;
            this.bad2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bad2Lbl.Location = new System.Drawing.Point(65, 49);
            this.bad2Lbl.Name = "bad2Lbl";
            this.bad2Lbl.Size = new System.Drawing.Size(73, 24);
            this.bad2Lbl.TabIndex = 4;
            this.bad2Lbl.Text = "B Word";
            this.bad2Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bad1Lbl
            // 
            this.bad1Lbl.AutoSize = true;
            this.bad1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bad1Lbl.Location = new System.Drawing.Point(65, 25);
            this.bad1Lbl.Name = "bad1Lbl";
            this.bad1Lbl.Size = new System.Drawing.Size(73, 24);
            this.bad1Lbl.TabIndex = 3;
            this.bad1Lbl.Text = "B Word";
            this.bad1Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Taboo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pointLbl);
            this.Controls.Add(this.pointBtn);
            this.Controls.Add(this.passBtn);
            this.Name = "Taboo";
            this.Text = "Taboo";
            this.Load += new System.EventHandler(this.Taboo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button passBtn;
        private System.Windows.Forms.Button pointBtn;
        private System.Windows.Forms.Label pointLbl;
        private System.Windows.Forms.Label keyLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label bad3Lbl;
        private System.Windows.Forms.Label bad2Lbl;
        private System.Windows.Forms.Label bad1Lbl;
    }
}