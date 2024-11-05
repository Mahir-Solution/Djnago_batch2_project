namespace POS.Forms
{
    partial class frmSaleReturnForm
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
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleReturnForm));
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtorderdetailid = new System.Windows.Forms.TextBox();
            this.txtreturncustomer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpickerreturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btreturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtreturnordernumber = new System.Windows.Forms.TextBox();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.Removebtn = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            label8.Location = new System.Drawing.Point(245, 26);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(270, 31);
            label8.TabIndex = 207;
            label8.Text = "Sale Return Record";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.btnupdate.Location = new System.Drawing.Point(534, 474);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(149, 40);
            this.btnupdate.TabIndex = 220;
            this.btnupdate.Text = "Update ";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtorderdetailid
            // 
            this.txtorderdetailid.Location = new System.Drawing.Point(28, 160);
            this.txtorderdetailid.Name = "txtorderdetailid";
            this.txtorderdetailid.Size = new System.Drawing.Size(100, 20);
            this.txtorderdetailid.TabIndex = 219;
            this.txtorderdetailid.Visible = false;
            // 
            // txtreturncustomer
            // 
            this.txtreturncustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturncustomer.Location = new System.Drawing.Point(215, 160);
            this.txtreturncustomer.Multiline = true;
            this.txtreturncustomer.Name = "txtreturncustomer";
            this.txtreturncustomer.Size = new System.Drawing.Size(454, 33);
            this.txtreturncustomer.TabIndex = 218;
            this.txtreturncustomer.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.dataGridView1.Location = new System.Drawing.Point(73, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 234);
            this.dataGridView1.TabIndex = 217;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label3.Location = new System.Drawing.Point(303, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 216;
            this.label3.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 215;
            this.pictureBox1.TabStop = false;
            // 
            // dtpickerreturn
            // 
            this.dtpickerreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerreturn.Location = new System.Drawing.Point(336, 87);
            this.dtpickerreturn.Name = "dtpickerreturn";
            this.dtpickerreturn.Size = new System.Drawing.Size(333, 29);
            this.dtpickerreturn.TabIndex = 214;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(159, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 213;
            this.label1.Text = "Customer";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(163, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 33);
            this.button1.TabIndex = 212;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btreturn
            // 
            this.btreturn.BackColor = System.Drawing.Color.Transparent;
            this.btreturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.btreturn.Location = new System.Drawing.Point(702, 85);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(103, 34);
            this.btreturn.TabIndex = 208;
            this.btreturn.Text = "Return";
            this.btreturn.UseVisualStyleBackColor = false;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 211;
            this.label2.Text = "Order_Number";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(28, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 32);
            this.button7.TabIndex = 210;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtreturnordernumber
            // 
            this.txtreturnordernumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturnordernumber.Location = new System.Drawing.Point(73, 86);
            this.txtreturnordernumber.Multiline = true;
            this.txtreturnordernumber.Name = "txtreturnordernumber";
            this.txtreturnordernumber.Size = new System.Drawing.Size(161, 33);
            this.txtreturnordernumber.TabIndex = 209;
            this.txtreturnordernumber.UseSystemPasswordChar = true;
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(28, 12);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(100, 20);
            this.txtcid.TabIndex = 221;
            this.txtcid.Visible = false;
            // 
            // Removebtn
            // 
            this.Removebtn.BackColor = System.Drawing.Color.Transparent;
            this.Removebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(88)))), ((int)(((byte)(108)))));
            this.Removebtn.Location = new System.Drawing.Point(174, 477);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(137, 34);
            this.Removebtn.TabIndex = 222;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = false;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // frmSaleReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(829, 540);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtorderdetailid);
            this.Controls.Add(this.txtreturncustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpickerreturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtreturnordernumber);
            this.Controls.Add(label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSaleReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaleReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtorderdetailid;
        private System.Windows.Forms.TextBox txtreturncustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpickerreturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtreturnordernumber;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Button Removebtn;
    }
}