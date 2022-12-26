namespace WindowsFormsAppmiddle
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.btninto = new System.Windows.Forms.Button();
            this.btnsearchbag = new System.Windows.Forms.Button();
            this.CBnum = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBNO = new System.Windows.Forms.RadioButton();
            this.RBYes = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncharge = new System.Windows.Forms.Button();
            this.lbllast = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "藥     霖";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // LB1
            // 
            this.LB1.BackColor = System.Drawing.Color.Wheat;
            this.LB1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 27;
            this.LB1.Location = new System.Drawing.Point(85, 146);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(449, 301);
            this.LB1.TabIndex = 1;
            this.LB1.SelectedIndexChanged += new System.EventHandler(this.LB1_SelectedIndexChanged);
            // 
            // btninto
            // 
            this.btninto.BackColor = System.Drawing.Color.Olive;
            this.btninto.Font = new System.Drawing.Font("新細明體-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btninto.ForeColor = System.Drawing.Color.Transparent;
            this.btninto.Location = new System.Drawing.Point(99, 508);
            this.btninto.Name = "btninto";
            this.btninto.Size = new System.Drawing.Size(162, 69);
            this.btninto.TabIndex = 2;
            this.btninto.Text = "加入倉庫";
            this.btninto.UseVisualStyleBackColor = false;
            this.btninto.Click += new System.EventHandler(this.btninto_Click);
            // 
            // btnsearchbag
            // 
            this.btnsearchbag.BackColor = System.Drawing.Color.Olive;
            this.btnsearchbag.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsearchbag.ForeColor = System.Drawing.Color.Transparent;
            this.btnsearchbag.Location = new System.Drawing.Point(357, 508);
            this.btnsearchbag.Name = "btnsearchbag";
            this.btnsearchbag.Size = new System.Drawing.Size(162, 69);
            this.btnsearchbag.TabIndex = 2;
            this.btnsearchbag.Text = "查看倉庫";
            this.btnsearchbag.UseVisualStyleBackColor = false;
            this.btnsearchbag.Click += new System.EventHandler(this.btnsearchbag_Click);
            // 
            // CBnum
            // 
            this.CBnum.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CBnum.FormattingEnabled = true;
            this.CBnum.Location = new System.Drawing.Point(658, 199);
            this.CBnum.Name = "CBnum";
            this.CBnum.Size = new System.Drawing.Size(68, 37);
            this.CBnum.TabIndex = 3;
            this.CBnum.SelectedIndexChanged += new System.EventHandler(this.CBnum_SelectedIndexChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Olive;
            this.txtsearch.Font = new System.Drawing.Font("微軟正黑體", 19F, System.Drawing.FontStyle.Bold);
            this.txtsearch.ForeColor = System.Drawing.SystemColors.Window;
            this.txtsearch.Location = new System.Drawing.Point(85, 106);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(327, 41);
            this.txtsearch.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearch.Location = new System.Drawing.Point(411, 106);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(123, 40);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "search";
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(830, -272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 37);
            this.comboBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBNO);
            this.groupBox1.Controls.Add(this.RBYes);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(30)))));
            this.groupBox1.Location = new System.Drawing.Point(575, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(138, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "擴充背包";
            // 
            // RBNO
            // 
            this.RBNO.AutoSize = true;
            this.RBNO.Location = new System.Drawing.Point(44, 49);
            this.RBNO.Name = "RBNO";
            this.RBNO.Size = new System.Drawing.Size(49, 20);
            this.RBNO.TabIndex = 0;
            this.RBNO.TabStop = true;
            this.RBNO.Text = "NO";
            this.RBNO.UseVisualStyleBackColor = true;
            this.RBNO.CheckedChanged += new System.EventHandler(this.RBNO_CheckedChanged);
            // 
            // RBYes
            // 
            this.RBYes.AutoSize = true;
            this.RBYes.Location = new System.Drawing.Point(44, 21);
            this.RBYes.Name = "RBYes";
            this.RBYes.Size = new System.Drawing.Size(56, 20);
            this.RBYes.TabIndex = 0;
            this.RBYes.TabStop = true;
            this.RBYes.Text = "YES";
            this.RBYes.UseVisualStyleBackColor = true;
            this.RBYes.CheckedChanged += new System.EventHandler(this.RBYes_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtname.Location = new System.Drawing.Point(607, 364);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(134, 43);
            this.txtname.TabIndex = 4;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(521, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.Olive;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lbltotal.Location = new System.Drawing.Point(85, 447);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(449, 29);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(526, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseMnemonic = false;
            // 
            // btncharge
            // 
            this.btncharge.BackColor = System.Drawing.Color.Olive;
            this.btncharge.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncharge.ForeColor = System.Drawing.Color.Transparent;
            this.btncharge.Location = new System.Drawing.Point(617, 508);
            this.btncharge.Name = "btncharge";
            this.btncharge.Size = new System.Drawing.Size(124, 69);
            this.btncharge.TabIndex = 2;
            this.btncharge.Text = "儲值";
            this.btncharge.UseVisualStyleBackColor = false;
            this.btncharge.Click += new System.EventHandler(this.btncharge_Click);
            // 
            // lbllast
            // 
            this.lbllast.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lbllast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbllast.Location = new System.Drawing.Point(540, 437);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(210, 39);
            this.lbllast.TabIndex = 0;
            this.lbllast.Text = "餘額 : ";
            this.lbllast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbllast.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 7;
            // 
            // lbldiscount
            // 
            this.lbldiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldiscount.Image = ((System.Drawing.Image)(resources.GetObject("lbldiscount.Image")));
            this.lbldiscount.Location = new System.Drawing.Point(12, 9);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(52, 82);
            this.lbldiscount.TabIndex = 9;
            this.lbldiscount.Click += new System.EventHandler(this.lbldiscount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(767, 613);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllast);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CBnum);
            this.Controls.Add(this.btncharge);
            this.Controls.Add(this.btnsearchbag);
            this.Controls.Add(this.btninto);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "藥霖";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button btninto;
        private System.Windows.Forms.Button btnsearchbag;
        private System.Windows.Forms.ComboBox CBnum;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBNO;
        private System.Windows.Forms.RadioButton RBYes;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncharge;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldiscount;
    }
}

