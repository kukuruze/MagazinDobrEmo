
namespace DobrEmo
{
    partial class FormStoreStart
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
            this.buttonHardDrivesShow = new System.Windows.Forms.Button();
            this.buttonCPUsShow = new System.Windows.Forms.Button();
            this.buttonGPUsShow = new System.Windows.Forms.Button();
            this.buttonMotherBoardsShow = new System.Windows.Forms.Button();
            this.buttonRAMsShow = new System.Windows.Forms.Button();
            this.buttonExitApplication = new System.Windows.Forms.Button();
            this.buttonSSDsShow = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHardDrivesShow
            // 
            this.buttonHardDrivesShow.Location = new System.Drawing.Point(48, 95);
            this.buttonHardDrivesShow.Name = "buttonHardDrivesShow";
            this.buttonHardDrivesShow.Size = new System.Drawing.Size(186, 74);
            this.buttonHardDrivesShow.TabIndex = 0;
            this.buttonHardDrivesShow.Text = "Hard Drives";
            this.buttonHardDrivesShow.UseVisualStyleBackColor = true;
            this.buttonHardDrivesShow.Click += new System.EventHandler(this.buttonHardDrivesShow_Click);
            // 
            // buttonCPUsShow
            // 
            this.buttonCPUsShow.Location = new System.Drawing.Point(298, 95);
            this.buttonCPUsShow.Name = "buttonCPUsShow";
            this.buttonCPUsShow.Size = new System.Drawing.Size(186, 74);
            this.buttonCPUsShow.TabIndex = 1;
            this.buttonCPUsShow.Text = "CPUs";
            this.buttonCPUsShow.UseVisualStyleBackColor = true;
            this.buttonCPUsShow.Click += new System.EventHandler(this.buttonCPUsShow_Click);
            // 
            // buttonGPUsShow
            // 
            this.buttonGPUsShow.Location = new System.Drawing.Point(48, 205);
            this.buttonGPUsShow.Name = "buttonGPUsShow";
            this.buttonGPUsShow.Size = new System.Drawing.Size(186, 74);
            this.buttonGPUsShow.TabIndex = 2;
            this.buttonGPUsShow.Text = "GPUs";
            this.buttonGPUsShow.UseVisualStyleBackColor = true;
            this.buttonGPUsShow.Click += new System.EventHandler(this.buttonGPUsShow_Click);
            // 
            // buttonMotherBoardsShow
            // 
            this.buttonMotherBoardsShow.Location = new System.Drawing.Point(298, 205);
            this.buttonMotherBoardsShow.Name = "buttonMotherBoardsShow";
            this.buttonMotherBoardsShow.Size = new System.Drawing.Size(186, 74);
            this.buttonMotherBoardsShow.TabIndex = 3;
            this.buttonMotherBoardsShow.Text = "Mother Boards";
            this.buttonMotherBoardsShow.UseVisualStyleBackColor = true;
            this.buttonMotherBoardsShow.Click += new System.EventHandler(this.buttonMotherBoardsShow_Click);
            // 
            // buttonRAMsShow
            // 
            this.buttonRAMsShow.Location = new System.Drawing.Point(48, 317);
            this.buttonRAMsShow.Name = "buttonRAMsShow";
            this.buttonRAMsShow.Size = new System.Drawing.Size(186, 74);
            this.buttonRAMsShow.TabIndex = 4;
            this.buttonRAMsShow.Text = "RAMs";
            this.buttonRAMsShow.UseVisualStyleBackColor = true;
            this.buttonRAMsShow.Click += new System.EventHandler(this.buttonRAMsShow_Click);
            // 
            // buttonExitApplication
            // 
            this.buttonExitApplication.BackColor = System.Drawing.Color.Crimson;
            this.buttonExitApplication.ForeColor = System.Drawing.Color.White;
            this.buttonExitApplication.Location = new System.Drawing.Point(48, 412);
            this.buttonExitApplication.Name = "buttonExitApplication";
            this.buttonExitApplication.Size = new System.Drawing.Size(186, 74);
            this.buttonExitApplication.TabIndex = 5;
            this.buttonExitApplication.Text = "Изход";
            this.buttonExitApplication.UseVisualStyleBackColor = false;
            this.buttonExitApplication.Click += new System.EventHandler(this.buttonExitApplication_Click);
            // 
            // buttonSSDsShow
            // 
            this.buttonSSDsShow.Location = new System.Drawing.Point(298, 317);
            this.buttonSSDsShow.Name = "buttonSSDsShow";
            this.buttonSSDsShow.Size = new System.Drawing.Size(186, 74);
            this.buttonSSDsShow.TabIndex = 6;
            this.buttonSSDsShow.Text = "SSDs";
            this.buttonSSDsShow.UseVisualStyleBackColor = true;
            this.buttonSSDsShow.Click += new System.EventHandler(this.buttonSSDsShow_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.BackColor = System.Drawing.Color.Lime;
            this.buttonCart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCart.Location = new System.Drawing.Point(298, 412);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(186, 74);
            this.buttonCart.TabIndex = 7;
            this.buttonCart.Text = "Количка";
            this.buttonCart.UseVisualStyleBackColor = false;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(26, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(492, 76);
            this.labelUser.TabIndex = 8;
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormStoreStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 516);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.buttonSSDsShow);
            this.Controls.Add(this.buttonExitApplication);
            this.Controls.Add(this.buttonRAMsShow);
            this.Controls.Add(this.buttonMotherBoardsShow);
            this.Controls.Add(this.buttonGPUsShow);
            this.Controls.Add(this.buttonCPUsShow);
            this.Controls.Add(this.buttonHardDrivesShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStoreStart";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormStoreStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHardDrivesShow;
        private System.Windows.Forms.Button buttonCPUsShow;
        private System.Windows.Forms.Button buttonGPUsShow;
        private System.Windows.Forms.Button buttonRAMsShow;
        private System.Windows.Forms.Button buttonMotherBoardsShow;
        private System.Windows.Forms.Button buttonExitApplication;
        private System.Windows.Forms.Button buttonSSDsShow;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Label labelUser;
    }
}