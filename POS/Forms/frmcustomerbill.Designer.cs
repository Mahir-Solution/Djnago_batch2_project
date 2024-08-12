namespace POS.Forms
{
    partial class frmcustomerbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustomerbill));
            this.customerpanel = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbsupplier1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnfetch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtsupsearch = new System.Windows.Forms.TextBox();
            this.customerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerpanel
            // 
            this.customerpanel.Controls.Add(this.txtsupsearch);
            this.customerpanel.Controls.Add(this.btnexit);
            this.customerpanel.Controls.Add(this.cbsupplier1);
            this.customerpanel.Controls.Add(this.label5);
            this.customerpanel.Controls.Add(this.button3);
            this.customerpanel.Controls.Add(this.btnfetch);
            this.customerpanel.Controls.Add(this.label8);
            this.customerpanel.Controls.Add(this.label1);
            this.customerpanel.Controls.Add(this.pictureBox2);
            this.customerpanel.Controls.Add(this.dateTimePicker2);
            this.customerpanel.Controls.Add(this.label2);
            this.customerpanel.Controls.Add(this.pictureBox1);
            this.customerpanel.Controls.Add(this.dateTimePicker1);
            this.customerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerpanel.Location = new System.Drawing.Point(0, 0);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(707, 414);
            this.customerpanel.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnexit.Location = new System.Drawing.Point(584, 31);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 34);
            this.btnexit.TabIndex = 4;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cbsupplier1
            // 
            this.cbsupplier1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsupplier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsupplier1.FormattingEnabled = true;
            this.cbsupplier1.Location = new System.Drawing.Point(263, 97);
            this.cbsupplier1.Name = "cbsupplier1";
            this.cbsupplier1.Size = new System.Drawing.Size(195, 32);
            this.cbsupplier1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(220, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 182;
            this.label5.Text = "Name";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(218, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 37);
            this.button3.TabIndex = 181;
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
            this.btnfetch.Location = new System.Drawing.Point(308, 324);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(68, 63);
            this.btnfetch.TabIndex = 3;
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(256, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 31);
            this.label8.TabIndex = 179;
            this.label8.Text = "Customer Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(167, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 178;
            this.label1.Text = "End_Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(171, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 177;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(206, 264);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(333, 29);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(167, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 175;
            this.label2.Text = "Start_Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 29);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtsupsearch
            // 
            this.txtsupsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtsupsearch.Location = new System.Drawing.Point(270, 73);
            this.txtsupsearch.Name = "txtsupsearch";
            this.txtsupsearch.Size = new System.Drawing.Size(174, 20);
            this.txtsupsearch.TabIndex = 183;
            this.txtsupsearch.TextChanged += new System.EventHandler(this.txtsupsearch_TextChanged);
            // 
            // frmcustomerbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(707, 414);
            this.Controls.Add(this.customerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcustomerbill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcustomerbill";
            this.Load += new System.EventHandler(this.frmcustomerbill_Load);
            this.customerpanel.ResumeLayout(false);
            this.customerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerpanel;
        private System.Windows.Forms.ComboBox cbsupplier1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtsupsearch;
    }
}