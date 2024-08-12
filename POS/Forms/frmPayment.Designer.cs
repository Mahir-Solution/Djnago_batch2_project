namespace POS.Forms
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbsource = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.btnfetch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbupdatecustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtupdatepayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbcustomer = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtsupsearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtsupsearch);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.cbsource);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.txtpid);
            this.panel2.Controls.Add(this.btnfetch);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.cbupdatecustomer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtupdatepayment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cbcustomer);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.txtamount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 470);
            this.panel2.TabIndex = 4;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkViolet;
            this.btnexit.Location = new System.Drawing.Point(800, 22);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(39, 34);
            this.btnexit.TabIndex = 174;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cbsource
            // 
            this.cbsource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsource.FormattingEnabled = true;
            this.cbsource.Items.AddRange(new object[] {
            "Cash",
            "Jazz Cash",
            "Bank"});
            this.cbsource.Location = new System.Drawing.Point(111, 326);
            this.cbsource.Name = "cbsource";
            this.cbsource.Size = new System.Drawing.Size(193, 32);
            this.cbsource.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label9.Location = new System.Drawing.Point(64, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 172;
            this.label9.Text = "Payment Source";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(66, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 42);
            this.button3.TabIndex = 171;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(457, 405);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(100, 20);
            this.txtpid.TabIndex = 169;
            this.txtpid.Visible = false;
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.Transparent;
            this.btnfetch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfetch.BackgroundImage")));
            this.btnfetch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfetch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.ForeColor = System.Drawing.Color.Transparent;
            this.btnfetch.Location = new System.Drawing.Point(604, 233);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(68, 63);
            this.btnfetch.TabIndex = 5;
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnupdate.Location = new System.Drawing.Point(604, 384);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(68, 63);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.panel3.Location = new System.Drawing.Point(409, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 452);
            this.panel3.TabIndex = 166;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(453, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 165;
            this.label3.Text = "Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(451, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 164;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(486, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(333, 29);
            this.dateTimePicker2.TabIndex = 163;
            // 
            // cbupdatecustomer
            // 
            this.cbupdatecustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbupdatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbupdatecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbupdatecustomer.FormattingEnabled = true;
            this.cbupdatecustomer.Location = new System.Drawing.Point(556, 175);
            this.cbupdatecustomer.Name = "cbupdatecustomer";
            this.cbupdatecustomer.Size = new System.Drawing.Size(195, 32);
            this.cbupdatecustomer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label4.Location = new System.Drawing.Point(511, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 161;
            this.label4.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label5.Location = new System.Drawing.Point(509, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 160;
            this.label5.Text = "Customer";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(513, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 41);
            this.button1.TabIndex = 159;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(510, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 158;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(509, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 31);
            this.label7.TabIndex = 157;
            this.label7.Text = "Update Payment";
            // 
            // txtupdatepayment
            // 
            this.txtupdatepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtupdatepayment.Location = new System.Drawing.Point(558, 326);
            this.txtupdatepayment.Multiline = true;
            this.txtupdatepayment.Name = "txtupdatepayment";
            this.txtupdatepayment.Size = new System.Drawing.Size(193, 31);
            this.txtupdatepayment.TabIndex = 6;
            this.txtupdatepayment.UseSystemPasswordChar = true;
            this.txtupdatepayment.TextChanged += new System.EventHandler(this.txtupdatepayment_TextChanged);
            this.txtupdatepayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtupdatepayment_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 154;
            this.label2.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 153;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 29);
            this.dateTimePicker1.TabIndex = 152;
            // 
            // cbcustomer
            // 
            this.cbcustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcustomer.FormattingEnabled = true;
            this.cbcustomer.Location = new System.Drawing.Point(109, 183);
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
            this.btnclear.Location = new System.Drawing.Point(12, 21);
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
            this.label1.Location = new System.Drawing.Point(64, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label6.Location = new System.Drawing.Point(62, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "Customer";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(66, 248);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 42);
            this.button7.TabIndex = 72;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(63, 173);
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
            this.label8.Location = new System.Drawing.Point(62, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 31);
            this.label8.TabIndex = 70;
            this.label8.Text = "Received Payment";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsave.BackgroundImage")));
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(151, 382);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(67, 63);
            this.btnsave.TabIndex = 3;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(111, 251);
            this.txtamount.Multiline = true;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(193, 35);
            this.txtamount.TabIndex = 1;
            this.txtamount.UseSystemPasswordChar = true;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // txtsupsearch
            // 
            this.txtsupsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtsupsearch.Location = new System.Drawing.Point(123, 157);
            this.txtsupsearch.Name = "txtsupsearch";
            this.txtsupsearch.Size = new System.Drawing.Size(159, 20);
            this.txtsupsearch.TabIndex = 175;
            this.txtsupsearch.TextChanged += new System.EventHandler(this.txtsupsearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.textBox1.Location = new System.Drawing.Point(568, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 176;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 470);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbcustomer;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbupdatecustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtupdatepayment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.ComboBox cbsource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtsupsearch;
    }
}