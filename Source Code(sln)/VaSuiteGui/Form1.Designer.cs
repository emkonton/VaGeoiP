namespace VaSuiteGui
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.osint = new System.Windows.Forms.TabPage();
            this.ipadusin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gialsb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.osint.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // osint
            // 
            this.osint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.osint.Controls.Add(this.rtbOutput);
            this.osint.Controls.Add(this.ipadusin);
            this.osint.Controls.Add(this.label2);
            this.osint.Controls.Add(this.gialsb);
            this.osint.Controls.Add(this.label1);
            this.osint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.osint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.osint.Location = new System.Drawing.Point(4, 22);
            this.osint.Name = "osint";
            this.osint.Padding = new System.Windows.Forms.Padding(3);
            this.osint.Size = new System.Drawing.Size(988, 501);
            this.osint.TabIndex = 0;
            this.osint.Text = "Osint";
            // 
            // ipadusin
            // 
            this.ipadusin.Location = new System.Drawing.Point(10, 469);
            this.ipadusin.Name = "ipadusin";
            this.ipadusin.Size = new System.Drawing.Size(198, 21);
            this.ipadusin.TabIndex = 0;
            this.ipadusin.TextChanged += new System.EventHandler(this.ipadusin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(10, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İp adress";
            // 
            // gialsb
            // 
            this.gialsb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gialsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gialsb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gialsb.ForeColor = System.Drawing.Color.Red;
            this.gialsb.Location = new System.Drawing.Point(13, 184);
            this.gialsb.Name = "gialsb";
            this.gialsb.Size = new System.Drawing.Size(129, 23);
            this.gialsb.TabIndex = 2;
            this.gialsb.Text = "Scan Start";
            this.gialsb.UseVisualStyleBackColor = false;
            this.gialsb.Click += new System.EventHandler(this.gialsb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(10, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geographic IP address location scanning";
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(84)))), ((int)(((byte)(66)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Location = new System.Drawing.Point(13, 213);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(424, 235);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.osint);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(52, 18);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(467, 522);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VaSuite";
            this.osint.ResumeLayout(false);
            this.osint.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage osint;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox ipadusin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gialsb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

