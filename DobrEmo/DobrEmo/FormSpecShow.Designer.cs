
namespace DobrEmo
{
    partial class FormSpecShow
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
            this.buttonToStoreStart = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPrice = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonToStoreStart
            // 
            this.buttonToStoreStart.Location = new System.Drawing.Point(278, 378);
            this.buttonToStoreStart.Name = "buttonToStoreStart";
            this.buttonToStoreStart.Size = new System.Drawing.Size(213, 53);
            this.buttonToStoreStart.TabIndex = 3;
            this.buttonToStoreStart.Text = "To Menu";
            this.buttonToStoreStart.UseVisualStyleBackColor = true;
            this.buttonToStoreStart.Click += new System.EventHandler(this.buttonToStoreStart_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(37, 33);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(512, 318);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "";
            // 
            // richTextBoxPrice
            // 
            this.richTextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxPrice.Location = new System.Drawing.Point(560, 33);
            this.richTextBoxPrice.Name = "richTextBoxPrice";
            this.richTextBoxPrice.ReadOnly = true;
            this.richTextBoxPrice.Size = new System.Drawing.Size(215, 318);
            this.richTextBoxPrice.TabIndex = 4;
            this.richTextBoxPrice.Text = "";
            // 
            // FormSpecShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 468);
            this.Controls.Add(this.richTextBoxPrice);
            this.Controls.Add(this.buttonToStoreStart);
            this.Controls.Add(this.richTextBoxInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSpecShow";
            this.Text = "Specifications";
            this.Load += new System.EventHandler(this.FormCPUsShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToStoreStart;
        public System.Windows.Forms.RichTextBox richTextBoxInfo;
        public System.Windows.Forms.RichTextBox richTextBoxPrice;
    }
}