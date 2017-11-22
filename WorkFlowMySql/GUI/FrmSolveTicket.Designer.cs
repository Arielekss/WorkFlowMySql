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
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.tpResponse = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTxtResponse = new System.Windows.Forms.RichTextBox();
            this.tpTicket = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.btnTicketCancel = new System.Windows.Forms.Button();
            this.txtActiveUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.llblForward = new System.Windows.Forms.LinkLabel();
            this.tpResponse.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpTicket.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(16, 23);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ReadOnly = true;
            this.txtHeader.Size = new System.Drawing.Size(337, 20);
            this.txtHeader.TabIndex = 0;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTicket);
            this.tabControl1.Controls.Add(this.tpResponse);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 207);
            this.tabControl1.TabIndex = 2;
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Location = new System.Drawing.Point(588, 283);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCloseTicket.TabIndex = 3;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            // 
            // btnTicketCancel
            // 
            this.btnTicketCancel.Location = new System.Drawing.Point(16, 283);
            this.btnTicketCancel.Name = "btnTicketCancel";
            this.btnTicketCancel.Size = new System.Drawing.Size(84, 23);
            this.btnTicketCancel.TabIndex = 4;
            this.btnTicketCancel.Text = "Cancel Ticket";
            this.btnTicketCancel.UseVisualStyleBackColor = true;
            // 
            // txtActiveUser
            // 
            this.txtActiveUser.Location = new System.Drawing.Point(447, 23);
            this.txtActiveUser.Name = "txtActiveUser";
            this.txtActiveUser.ReadOnly = true;
            this.txtActiveUser.Size = new System.Drawing.Size(126, 20);
            this.txtActiveUser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Header:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Active user:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(447, 63);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 1;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(444, 47);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(73, 13);
            this.status.TabIndex = 9;
            this.status.Text = "Ticket Status:";
            // 
            // llblForward
            // 
            this.llblForward.AutoSize = true;
            this.llblForward.Location = new System.Drawing.Point(585, 26);
            this.llblForward.Name = "llblForward";
            this.llblForward.Size = new System.Drawing.Size(45, 13);
            this.llblForward.TabIndex = 10;
            this.llblForward.TabStop = true;
            this.llblForward.Text = "Forward";
            // 
            // FrmSolveTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 318);
            this.Controls.Add(this.llblForward);
            this.Controls.Add(this.status);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActiveUser);
            this.Controls.Add(this.btnTicketCancel);
            this.Controls.Add(this.btnCloseTicket);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtHeader);
            this.Name = "FrmSolveTicket";
            this.Text = "Solve";
            this.tpResponse.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tpTicket.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TabPage tpResponse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rTxtResponse;
        private System.Windows.Forms.TabPage tpTicket;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Button btnTicketCancel;
        private System.Windows.Forms.TextBox txtActiveUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.LinkLabel llblForward;
    }
}