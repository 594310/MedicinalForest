namespace WindowsFormsAppmiddle
{
    partial class charge
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
            this.lbllast = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.btncharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllast.Location = new System.Drawing.Point(12, 30);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(79, 29);
            this.lbllast.TabIndex = 0;
            this.lbllast.Text = "餘額:";
            // 
            // txtmoney
            // 
            this.txtmoney.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmoney.Location = new System.Drawing.Point(12, 97);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(114, 46);
            this.txtmoney.TabIndex = 1;
            // 
            // btncharge
            // 
            this.btncharge.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncharge.Location = new System.Drawing.Point(144, 91);
            this.btncharge.Name = "btncharge";
            this.btncharge.Size = new System.Drawing.Size(75, 57);
            this.btncharge.TabIndex = 2;
            this.btncharge.Text = "充值";
            this.btncharge.UseVisualStyleBackColor = true;
            this.btncharge.Click += new System.EventHandler(this.btncharge_Click);
            // 
            // charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(233, 168);
            this.Controls.Add(this.btncharge);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.lbllast);
            this.Name = "charge";
            this.Text = "charge";
            this.Load += new System.EventHandler(this.charge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Button btncharge;
    }
}