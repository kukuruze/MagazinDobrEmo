
namespace DobrEmo
{
    partial class FormForgotPassword
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
            this.labelTextDisplayed = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAdvance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextDisplayed
            // 
            this.labelTextDisplayed.Location = new System.Drawing.Point(31, 59);
            this.labelTextDisplayed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTextDisplayed.Name = "labelTextDisplayed";
            this.labelTextDisplayed.Size = new System.Drawing.Size(196, 25);
            this.labelTextDisplayed.TabIndex = 0;
            this.labelTextDisplayed.Text = "Имейл";
            this.labelTextDisplayed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(31, 90);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(196, 31);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonAdvance
            // 
            this.buttonAdvance.Location = new System.Drawing.Point(55, 133);
            this.buttonAdvance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdvance.Name = "buttonAdvance";
            this.buttonAdvance.Size = new System.Drawing.Size(150, 44);
            this.buttonAdvance.TabIndex = 2;
            this.buttonAdvance.Text = "Напред";
            this.buttonAdvance.UseVisualStyleBackColor = true;
            this.buttonAdvance.Click += new System.EventHandler(this.buttonAdvance_Click);
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 233);
            this.Controls.Add(this.buttonAdvance);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelTextDisplayed);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormForgotPassword";
            this.Text = "FormForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextDisplayed;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAdvance;
    }
}