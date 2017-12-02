namespace WorkFlowMySql.GUI
{
    partial class FrmSolveTicket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblForward = new System.Windows.Forms.LinkLabel();
            this.status = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActiveUser = new System.Windows.Forms.TextBox();
            this.btnTicketCancel = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTicket = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.tpResponse = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTxtResponse = new System.Windows.Forms.RichTextBox();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpTicket.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpResponse.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llblForward);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtActiveUser);
            this.groupBox1.Controls.Add(this.btnTicketCancel);
            this.groupBox1.Controls.Add(this.btnCloseTicket);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.txtHeader);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Service";
            // 
            // llblForward
            // 
            this.llblForward.AutoSize = true;
            this.llblForward.Location = new System.Drawing.Point(579, 44);
            this.llblForward.Name = "llblForward";
            this.llblForward.Size = new System.Drawing.Size(45, 13);
            this.llblForward.TabIndex = 20;
            this.llblForward.TabStop = true;
            this.llblForward.Text = "Forward";
            this.llblForward.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblForward_LinkClicked_1);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status.Location = new System.Drawing.Point(438, 67);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(98, 18);
            this.status.TabIndex = 19;
            this.status.Text = "Ticket Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(441, 89);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(438, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Active user:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Header:";
            // 
            // txtActiveUser
            // 
            this.txtActiveUser.Location = new System.Drawing.Point(441, 44);
            this.txtActiveUser.Name = "txtActiveUser";
            this.txtActiveUser.ReadOnly = true;
            this.txtActiveUser.Size = new System.Drawing.Size(126, 20);
            this.txtActiveUser.TabIndex = 16;
            // 
            // btnTicketCancel
            // 
            this.btnTicketCancel.Location = new System.Drawing.Point(6, 305);
            this.btnTicketCancel.Name = "btnTicketCancel";
            this.btnTicketCancel.Size = new System.Drawing.Size(114, 36);
            this.btnTicketCancel.TabIndex = 15;
            this.btnTicketCancel.Text = "Cancel Ticket";
            this.btnTicketCancel.UseVisualStyleBackColor = true;
            this.btnTicketCancel.Click += new System.EventHandler(this.btnTicketCancel_Click_1);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Location = new System.Drawing.Point(550, 305);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(114, 36);
            this.btnCloseTicket.TabIndex = 14;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTicket);
            this.tabControl1.Controls.Add(this.tpResponse);
            this.tabControl1.Location = new System.Drawing.Point(6, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 207);
            this.tabControl1.TabIndex = 13;
            // 
            // tpTicket
            // 
            this.tpTicket.Controls.Add(this.panel1);
            this.tpTicket.Location = new System.Drawing.Point(4, 22);
            this.tpTicket.Name = "tpTicket";
            this.tpTicket.Padding = new System.Windows.Forms.Padding(3);
            this.tpTicket.Size = new System.Drawing.Size(650, 181);
            this.tpTicket.TabIndex = 0;
            this.tpTicket.Text = "Ticket";
            this.tpTicket.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rTxtContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 175);
            this.panel1.TabIndex = 0;
            // 
            // rTxtContent
            // 
            this.rTxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtContent.Location = new System.Drawing.Point(0, 0);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.ReadOnly = true;
            this.rTxtContent.Size = new System.Drawing.Size(644, 175);
            this.rTxtContent.TabIndex = 0;
            this.rTxtContent.Text = "";
            // 
            // tpResponse
            // 
            this.tpResponse.Controls.Add(this.panel2);
            this.tpResponse.Location = new System.Drawing.Point(4, 22);
            this.tpResponse.Name = "tpResponse";
            this.tpResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tpResponse.Size = new System.Drawing.Size(650, 181);
            this.tpResponse.TabIndex = 1;
            this.tpResponse.Text = "Response";
            this.tpResponse.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rTxtResponse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 175);
            this.panel2.TabIndex = 0;
            // 
            // rTxtResponse
            // 
            this.rTxtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtResponse.Location = new System.Drawing.Point(0, 0);
            this.rTxtResponse.Name = "rTxtResponse";
            this.rTxtResponse.Size = new System.Drawing.Size(644, 175);
            this.rTxtResponse.TabIndex = 0;
            this.rTxtResponse.Text = "";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(10, 44);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ReadOnly = true;
            this.txtHeader.Size = new System.Drawing.Size(337, 20);
            this.txtHeader.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 191);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WorkFlowMySql.Properties.Resources.SaaS_Help_Desk_Software_Comparison;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSolveTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(697, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSolveTicket";
            this.Text = "Solve";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpTicket.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpResponse.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblForward;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActiveUser;
        private System.Windows.Forms.Button btnTicketCancel;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private System.Windows.Forms.TabPage tpResponse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rTxtResponse;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}