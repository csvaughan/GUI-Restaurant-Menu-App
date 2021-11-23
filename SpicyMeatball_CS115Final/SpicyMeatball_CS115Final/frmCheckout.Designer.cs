
namespace SpicyMeatball_CS115Final
{
    partial class FrmCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckout));
            this.panOrder = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.gbxTip = new System.Windows.Forms.GroupBox();
            this.lblSuggestedTip = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblTipadd = new System.Windows.Forms.Label();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.panPin = new System.Windows.Forms.Panel();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblPayinfo = new System.Windows.Forms.Label();
            this.panCard = new System.Windows.Forms.Panel();
            this.lblCardnum = new System.Windows.Forms.Label();
            this.lblExdate = new System.Windows.Forms.Label();
            this.txtCardnum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.labelSlash = new System.Windows.Forms.Label();
            this.cbxPayment = new System.Windows.Forms.ComboBox();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.panName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panOrder.SuspendLayout();
            this.gbxTip.SuspendLayout();
            this.gbxPayment.SuspendLayout();
            this.panPin.SuspendLayout();
            this.panCard.SuspendLayout();
            this.panName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panOrder
            // 
            this.panOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOrder.Controls.Add(this.lblTotal);
            this.panOrder.Controls.Add(this.btnRemove);
            this.panOrder.Controls.Add(this.lbxOrder);
            this.panOrder.Controls.Add(this.lblOrder);
            this.panOrder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panOrder.Location = new System.Drawing.Point(32, 28);
            this.panOrder.Name = "panOrder";
            this.panOrder.Size = new System.Drawing.Size(225, 517);
            this.panOrder.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(17, 397);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(185, 62);
            this.lblTotal.TabIndex = 9;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(17, 462);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(185, 41);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lbxOrder
            // 
            this.lbxOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbxOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.ItemHeight = 19;
            this.lbxOrder.Location = new System.Drawing.Point(17, 47);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(185, 346);
            this.lbxOrder.TabIndex = 6;
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(72, 14);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(81, 21);
            this.lblOrder.TabIndex = 8;
            this.lblOrder.Text = "My Order";
            // 
            // gbxTip
            // 
            this.gbxTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxTip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxTip.Controls.Add(this.lblSuggestedTip);
            this.gbxTip.Controls.Add(this.txtTip);
            this.gbxTip.Controls.Add(this.lblTipadd);
            this.gbxTip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxTip.Location = new System.Drawing.Point(288, 175);
            this.gbxTip.Name = "gbxTip";
            this.gbxTip.Size = new System.Drawing.Size(300, 370);
            this.gbxTip.TabIndex = 13;
            this.gbxTip.TabStop = false;
            this.gbxTip.Text = "Add a Tip?";
            // 
            // lblSuggestedTip
            // 
            this.lblSuggestedTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuggestedTip.BackColor = System.Drawing.SystemColors.Control;
            this.lblSuggestedTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSuggestedTip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuggestedTip.Location = new System.Drawing.Point(18, 26);
            this.lblSuggestedTip.Name = "lblSuggestedTip";
            this.lblSuggestedTip.Size = new System.Drawing.Size(262, 253);
            this.lblSuggestedTip.TabIndex = 7;
            // 
            // txtTip
            // 
            this.txtTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTip.Location = new System.Drawing.Point(205, 296);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(62, 26);
            this.txtTip.TabIndex = 5;
            // 
            // lblTipadd
            // 
            this.lblTipadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipadd.Location = new System.Drawing.Point(18, 296);
            this.lblTipadd.Name = "lblTipadd";
            this.lblTipadd.Size = new System.Drawing.Size(194, 71);
            this.lblTipadd.TabIndex = 6;
            this.lblTipadd.Text = "Enter tip amount to add: $\r\n(Enter 0 if you don\'t want to add a tip)";
            // 
            // gbxPayment
            // 
            this.gbxPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxPayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxPayment.Controls.Add(this.panPin);
            this.gbxPayment.Controls.Add(this.lblPayinfo);
            this.gbxPayment.Controls.Add(this.panCard);
            this.gbxPayment.Controls.Add(this.cbxPayment);
            this.gbxPayment.Controls.Add(this.lblWaiter);
            this.gbxPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxPayment.Location = new System.Drawing.Point(605, 94);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(371, 268);
            this.gbxPayment.TabIndex = 14;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Payment Method";
            // 
            // panPin
            // 
            this.panPin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panPin.Controls.Add(this.txtPin);
            this.panPin.Controls.Add(this.lblPin);
            this.panPin.Location = new System.Drawing.Point(68, 185);
            this.panPin.Name = "panPin";
            this.panPin.Size = new System.Drawing.Size(122, 33);
            this.panPin.TabIndex = 10;
            this.panPin.Visible = false;
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPin.Location = new System.Drawing.Point(59, 3);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(54, 26);
            this.txtPin.TabIndex = 2;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(18, 6);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(35, 19);
            this.lblPin.TabIndex = 7;
            this.lblPin.Text = "PIN";
            // 
            // lblPayinfo
            // 
            this.lblPayinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayinfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblPayinfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayinfo.Location = new System.Drawing.Point(9, 26);
            this.lblPayinfo.Name = "lblPayinfo";
            this.lblPayinfo.Size = new System.Drawing.Size(230, 65);
            this.lblPayinfo.TabIndex = 9;
            this.lblPayinfo.Text = "Choose a payment option. We accept Cash, Credit Card, or Debit Card";
            // 
            // panCard
            // 
            this.panCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panCard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panCard.Controls.Add(this.lblCardnum);
            this.panCard.Controls.Add(this.lblExdate);
            this.panCard.Controls.Add(this.txtCardnum);
            this.panCard.Controls.Add(this.txtYear);
            this.panCard.Controls.Add(this.txtMonth);
            this.panCard.Controls.Add(this.labelSlash);
            this.panCard.Location = new System.Drawing.Point(9, 104);
            this.panCard.Name = "panCard";
            this.panCard.Size = new System.Drawing.Size(348, 75);
            this.panCard.TabIndex = 8;
            this.panCard.Visible = false;
            // 
            // lblCardnum
            // 
            this.lblCardnum.AutoSize = true;
            this.lblCardnum.Location = new System.Drawing.Point(11, 7);
            this.lblCardnum.Name = "lblCardnum";
            this.lblCardnum.Size = new System.Drawing.Size(97, 19);
            this.lblCardnum.TabIndex = 9;
            this.lblCardnum.Text = "Card Number:";
            // 
            // lblExdate
            // 
            this.lblExdate.AutoSize = true;
            this.lblExdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExdate.Location = new System.Drawing.Point(200, 18);
            this.lblExdate.Name = "lblExdate";
            this.lblExdate.Size = new System.Drawing.Size(106, 19);
            this.lblExdate.TabIndex = 8;
            this.lblExdate.Text = "Experation Date";
            // 
            // txtCardnum
            // 
            this.txtCardnum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCardnum.Location = new System.Drawing.Point(11, 38);
            this.txtCardnum.Name = "txtCardnum";
            this.txtCardnum.Size = new System.Drawing.Size(161, 26);
            this.txtCardnum.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.Gainsboro;
            this.txtYear.Location = new System.Drawing.Point(263, 38);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(43, 26);
            this.txtYear.TabIndex = 5;
            this.txtYear.Text = "YY";
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonth
            // 
            this.txtMonth.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMonth.Location = new System.Drawing.Point(200, 38);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(41, 26);
            this.txtMonth.TabIndex = 4;
            this.txtMonth.Text = "MM";
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSlash
            // 
            this.labelSlash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSlash.Location = new System.Drawing.Point(247, 39);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(21, 29);
            this.labelSlash.TabIndex = 6;
            this.labelSlash.Text = "/";
            // 
            // cbxPayment
            // 
            this.cbxPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPayment.FormattingEnabled = true;
            this.cbxPayment.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.cbxPayment.Location = new System.Drawing.Point(245, 45);
            this.cbxPayment.Name = "cbxPayment";
            this.cbxPayment.Size = new System.Drawing.Size(109, 27);
            this.cbxPayment.TabIndex = 0;
            this.cbxPayment.Text = "Payment Type";
            this.cbxPayment.SelectedIndexChanged += new System.EventHandler(this.CbxPayment_SelectedIndexChanged);
            // 
            // lblWaiter
            // 
            this.lblWaiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWaiter.Location = new System.Drawing.Point(6, 127);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(359, 114);
            this.lblWaiter.TabIndex = 3;
            this.lblWaiter.Text = "Please wait for waiter to collect payment.";
            this.lblWaiter.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(605, 402);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(371, 110);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnMain
            // 
            this.btnMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMain.BackColor = System.Drawing.SystemColors.Control;
            this.btnMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMain.Location = new System.Drawing.Point(1018, 468);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(139, 44);
            this.btnMain.TabIndex = 16;
            this.btnMain.Text = "Back to Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // panName
            // 
            this.panName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panName.BackColor = System.Drawing.SystemColors.Control;
            this.panName.Controls.Add(this.label1);
            this.panName.Controls.Add(this.txtName);
            this.panName.Location = new System.Drawing.Point(288, 94);
            this.panName.Name = "panName";
            this.panName.Size = new System.Drawing.Size(300, 75);
            this.panName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a name for the order:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(81, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 23);
            this.txtName.TabIndex = 0;
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panName);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxPayment);
            this.Controls.Add(this.gbxTip);
            this.Controls.Add(this.panOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCheckout_Load);
            this.panOrder.ResumeLayout(false);
            this.panOrder.PerformLayout();
            this.gbxTip.ResumeLayout(false);
            this.gbxTip.PerformLayout();
            this.gbxPayment.ResumeLayout(false);
            this.panPin.ResumeLayout(false);
            this.panPin.PerformLayout();
            this.panCard.ResumeLayout(false);
            this.panCard.PerformLayout();
            this.panName.ResumeLayout(false);
            this.panName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panOrder;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.ListBox lbxOrder;
        public System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.GroupBox gbxTip;
        private System.Windows.Forms.Label lblSuggestedTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblTipadd;
        public System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.Label lblPayinfo;
        private System.Windows.Forms.Panel panCard;
        private System.Windows.Forms.Label lblCardnum;
        private System.Windows.Forms.Label lblExdate;
        private System.Windows.Forms.TextBox txtCardnum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label labelSlash;
        public System.Windows.Forms.TextBox txtPin;
        public System.Windows.Forms.ComboBox cbxPayment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Panel panPin;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTotal;
    }
}