namespace SpicyMeatball_CS115Final
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnEntrees = new System.Windows.Forms.Button();
            this.lblInstructionsForUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblMenuTitle.Location = new System.Drawing.Point(471, 28);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(271, 55);
            this.lblMenuTitle.TabIndex = 3;
            this.lblMenuTitle.Text = "Main Menu";
            // 
            // btnBeverages
            // 
            this.btnBeverages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBeverages.AutoSize = true;
            this.btnBeverages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeverages.BackgroundImage")));
            this.btnBeverages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBeverages.Location = new System.Drawing.Point(829, 259);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(345, 225);
            this.btnBeverages.TabIndex = 2;
            this.btnBeverages.Text = "Beverages";
            this.btnBeverages.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBeverages.UseVisualStyleBackColor = true;
            this.btnBeverages.Click += new System.EventHandler(this.BtnBeverages_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDessert.AutoSize = true;
            this.btnDessert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDessert.BackgroundImage")));
            this.btnDessert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDessert.Location = new System.Drawing.Point(429, 259);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(345, 225);
            this.btnDessert.TabIndex = 1;
            this.btnDessert.Text = "Desserts";
            this.btnDessert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDessert.UseVisualStyleBackColor = true;
            this.btnDessert.Click += new System.EventHandler(this.BtnDessert_Click);
            // 
            // btnEntrees
            // 
            this.btnEntrees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrees.AutoSize = true;
            this.btnEntrees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrees.BackgroundImage")));
            this.btnEntrees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrees.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrees.ForeColor = System.Drawing.Color.Black;
            this.btnEntrees.Location = new System.Drawing.Point(30, 259);
            this.btnEntrees.Name = "btnEntrees";
            this.btnEntrees.Size = new System.Drawing.Size(345, 225);
            this.btnEntrees.TabIndex = 0;
            this.btnEntrees.Text = "Entrees";
            this.btnEntrees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntrees.UseVisualStyleBackColor = true;
            this.btnEntrees.Click += new System.EventHandler(this.BtnEntrees_Click);
            // 
            // lblInstructionsForUser
            // 
            this.lblInstructionsForUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInstructionsForUser.AutoSize = true;
            this.lblInstructionsForUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructionsForUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructionsForUser.Location = new System.Drawing.Point(206, 139);
            this.lblInstructionsForUser.Name = "lblInstructionsForUser";
            this.lblInstructionsForUser.Size = new System.Drawing.Size(788, 33);
            this.lblInstructionsForUser.TabIndex = 4;
            this.lblInstructionsForUser.Text = "*****Press the image of desired food you wish to order.*****\r\n";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.lblInstructionsForUser);
            this.Controls.Add(this.lblMenuTitle);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnEntrees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delicioso E-Restorante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrees;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblInstructionsForUser;
    }
}

