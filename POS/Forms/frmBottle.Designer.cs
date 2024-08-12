namespace POS.Forms
{
    partial class frmBottle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBottle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbsalesman = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cbcustomer = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtreturn = new System.Windows.Forms.TextBox();
            this.txtsupsearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.txtsupsearch);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.cbsalesman);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.cbcustomer);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtreturn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 474);
            this.panel2.TabIndex = 3;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnexit.Location = new System.Drawing.Point(563, 25);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 34);
            this.btnexit.TabIndex = 158;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(139, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 157;
            this.label2.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 29);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(284, 366);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "On_Shop";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbsalesman
            // 
            this.cbsalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsalesman.FormattingEnabled = true;
            this.cbsalesman.Location = new System.Drawing.Point(252, 312);
            this.cbsalesman.Name = "cbsalesman";
            this.cbsalesman.Size = new System.Drawing.Size(195, 32);
            this.cbsalesman.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(200, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 123;
            this.label5.Text = "Salesman";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(207, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 37);
            this.button3.TabIndex = 122;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbcustomer
            // 
            this.cbcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcustomer.FormattingEnabled = true;
            this.cbcustomer.Location = new System.Drawing.Point(250, 155);
            this.cbcustomer.Name = "cbcustomer";
            this.cbcustomer.Size = new System.Drawing.Size(195, 32);
            this.cbcustomer.TabIndex = 0;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnclear.Location = new System.Drawing.Point(59, 22);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(44, 37);
            this.btnclear.TabIndex = 104;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(205, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Return";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(203, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "Customer";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(207, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 42);
            this.button7.TabIndex = 72;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(204, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 45);
            this.button6.TabIndex = 71;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label8.Location = new System.Drawing.Point(207, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 31);
            this.label8.TabIndex = 70;
            this.label8.Text = "Received Bottle";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(284, 399);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(59, 63);
            this.btnsave.TabIndex = 4;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtreturn
            // 
            this.txtreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturn.Location = new System.Drawing.Point(252, 234);
            this.txtreturn.Multiline = true;
            this.txtreturn.Name = "txtreturn";
            this.txtreturn.Size = new System.Drawing.Size(193, 30);
            this.txtreturn.TabIndex = 1;
            this.txtreturn.UseSystemPasswordChar = true;
            this.txtreturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtreturn_KeyPress);
            // 
            // txtsupsearch
            // 
            this.txtsupsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtsupsearch.Location = new System.Drawing.Point(261, 129);
            this.txtsupsearch.Name = "txtsupsearch";
            this.txtsupsearch.Size = new System.Drawing.Size(166, 20);
            this.txtsupsearch.TabIndex = 160;
            this.txtsupsearch.TextChanged += new System.EventHandler(this.txtsupsearch_TextChanged);
            // 
            // frmBottle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 474);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBottle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBottle";
            this.Load += new System.EventHandler(this.frmBottle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbcustomer;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtreturn;
        private System.Windows.Forms.ComboBox cbsalesman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtsupsearch;
    }
}