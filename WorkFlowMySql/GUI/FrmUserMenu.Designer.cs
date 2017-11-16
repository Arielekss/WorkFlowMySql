namespace WorkFlowMySql.GUI
{
    partial class FrmUserMenu
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTick = new System.Windows.Forms.Button();
            this.btnTicketView = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUserTick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(50, 9);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User:";
            // 
            // btnCreateTick
            // 
            this.btnCreateTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTick.Location = new System.Drawing.Point(9, 94);
            this.btnCreateTick.Name = "btnCreateTick";
            this.btnCreateTick.Size = new System.Drawing.Size(86, 23);
            this.btnCreateTick.TabIndex = 2;
            this.btnCreateTick.Text = "Create Ticket";
            this.btnCreateTick.UseVisualStyleBackColor = true;
            this.btnCreateTick.Click += new System.EventHandler(this.btnCreateTick_Click);
            // 
            // btnTicketView
            // 
            this.btnTicketView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTicketView.Location = new System.Drawing.Point(182, 94);
            this.btnTicketView.Name = "btnTicketView";
            this.btnTicketView.Size = new System.Drawing.Size(75, 23);
            this.btnTicketView.TabIndex = 3;
            this.btnTicketView.Text = "View Ticket";
            this.btnTicketView.UseVisualStyleBackColor = true;
            this.btnTicketView.Click += new System.EventHandler(this.btnTicketView_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Location = new System.Drawing.Point(181, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnUserTick
            // 
            this.btnUserTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserTick.Location = new System.Drawing.Point(101, 94);
            this.btnUserTick.Name = "btnUserTick";
            this.btnUserTick.Size = new System.Drawing.Size(75, 23);
            this.btnUserTick.TabIndex = 5;
            this.btnUserTick.Text = "User Ticket";
            this.btnUserTick.UseVisualStyleBackColor = true;
            this.btnUserTick.Click += new System.EventHandler(this.btnUserTick_Click);
            // 
            // FrmUserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 129);
            this.Controls.Add(this.btnUserTick);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTicketView);
            this.Controls.Add(this.btnCreateTick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Name = "FrmUserMenu";
            this.Text = "FrmUserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTick;
        private System.Windows.Forms.Button btnTicketView;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUserTick;
    }
}