namespace SetIP
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.DefaultIPGateway = new System.Windows.Forms.TextBox();
            this.DNSServerSearchOrder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SubnetMask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "設置IP位址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "設置閘道位址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "設置DNS";
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(37, 45);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(152, 22);
            this.IPAddress.TabIndex = 3;
            this.IPAddress.Text = "192.168.1.1";
            // 
            // DefaultIPGateway
            // 
            this.DefaultIPGateway.Location = new System.Drawing.Point(37, 129);
            this.DefaultIPGateway.Name = "DefaultIPGateway";
            this.DefaultIPGateway.Size = new System.Drawing.Size(152, 22);
            this.DefaultIPGateway.TabIndex = 4;
            this.DefaultIPGateway.Text = "255.255.255.4";
            // 
            // DNSServerSearchOrder
            // 
            this.DNSServerSearchOrder.Location = new System.Drawing.Point(37, 173);
            this.DNSServerSearchOrder.Name = "DNSServerSearchOrder";
            this.DNSServerSearchOrder.Size = new System.Drawing.Size(152, 22);
            this.DNSServerSearchOrder.TabIndex = 5;
            this.DNSServerSearchOrder.Text = "4.4.8.8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "使用固定IP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(37, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "自動取得IP位置";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SubnetMask
            // 
            this.SubnetMask.Location = new System.Drawing.Point(37, 89);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.Size = new System.Drawing.Size(152, 22);
            this.SubnetMask.TabIndex = 9;
            this.SubnetMask.Text = "255.255.254.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "子網路遮罩";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 265);
            this.Controls.Add(this.SubnetMask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DNSServerSearchOrder);
            this.Controls.Add(this.DefaultIPGateway);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.TextBox DefaultIPGateway;
        private System.Windows.Forms.TextBox DNSServerSearchOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SubnetMask;
        private System.Windows.Forms.Label label4;
    }
}