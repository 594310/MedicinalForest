namespace WindowsFormsAppmiddle
{
    partial class bag
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
            this.LBbag = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnout = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.lbl餘額 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBbag
            // 
            this.LBbag.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LBbag.FormattingEnabled = true;
            this.LBbag.ItemHeight = 24;
            this.LBbag.Location = new System.Drawing.Point(45, 81);
            this.LBbag.Name = "LBbag";
            this.LBbag.Size = new System.Drawing.Size(659, 316);
            this.LBbag.TabIndex = 0;
            this.LBbag.SelectedIndexChanged += new System.EventHandler(this.LBbag_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(160)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(252, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "倉    庫";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnout
            // 
            this.btnout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnout.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnout.Location = new System.Drawing.Point(276, 437);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(94, 42);
            this.btnout.TabIndex = 2;
            this.btnout.Text = "清空倉庫";
            this.btnout.UseVisualStyleBackColor = false;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnclean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclean.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclean.Location = new System.Drawing.Point(86, 437);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(94, 42);
            this.btnclean.TabIndex = 2;
            this.btnclean.Text = "丟棄物品";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // lbl餘額
            // 
            this.lbl餘額.BackColor = System.Drawing.Color.Silver;
            this.lbl餘額.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl餘額.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl餘額.Location = new System.Drawing.Point(45, 397);
            this.lbl餘額.Name = "lbl餘額";
            this.lbl餘額.Size = new System.Drawing.Size(659, 28);
            this.lbl餘額.TabIndex = 3;
            this.lbl餘額.Text = "餘額";
            this.lbl餘額.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(50)))), ((int)(((byte)(10)))));
            this.btnback.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(610, 437);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 42);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "返回商店";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // bag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(85)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(747, 506);
            this.Controls.Add(this.lbl餘額);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBbag);
            this.Name = "bag";
            this.Text = "bag";
            this.Load += new System.EventHandler(this.bag_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBbag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Label lbl餘額;
        private System.Windows.Forms.Button btnback;
    }
}