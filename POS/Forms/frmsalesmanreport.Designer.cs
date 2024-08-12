namespace POS.Forms
{
    partial class frmsalesmanreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsalesmanreport));
            this.cbsupplier1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnfetch = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbsupplier1
            // 
            this.cbsupplier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsupplier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsupplier1.FormattingEnabled = true;
            this.cbsupplier1.Location = new System.Drawing.Point(172, 151);
            this.cbsupplier1.Name = "cbsupplier1";
            this.cbsupplier1.Size = new System.Drawing.Size(195, 32);
            this.cbsupplier1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(94, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 31);
            this.label7.TabIndex = 120;
            this.label7.Text = "Salesman Bottle Report";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(129, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 119;
            this.label5.Text = "Name";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(127, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 37);
            this.button3.TabIndex = 118;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.Transparent;
            this.btnfetch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfetch.BackgroundImage")));
            this.btnfetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.ForeColor = System.Drawing.Color.Transparent;
            this.btnfetch.Location = new System.Drawing.Point(207, 242);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(68, 63);
            this.btnfetch.TabIndex = 1;
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnexit.Location = new System.Drawing.Point(470, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(43, 40);
            this.btnexit.TabIndex = 121;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnclear.Location = new System.Drawing.Point(12, 15);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(44, 37);
            this.btnclear.TabIndex = 122;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmsalesmanreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(536, 390);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.cbsupplier1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsalesmanreport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsalesmanreport";
            this.Load += new System.EventHandler(this.frmsalesmanreport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbsupplier1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
    }
}