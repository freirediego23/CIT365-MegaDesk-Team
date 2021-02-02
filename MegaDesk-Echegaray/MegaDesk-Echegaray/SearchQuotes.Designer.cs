
namespace MegaDesk_Echegaray
{
    partial class SearchQuotes
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
            this.btnSearchQuotesClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchQuotesClose
            // 
            this.btnSearchQuotesClose.Location = new System.Drawing.Point(557, 335);
            this.btnSearchQuotesClose.Name = "btnSearchQuotesClose";
            this.btnSearchQuotesClose.Size = new System.Drawing.Size(169, 69);
            this.btnSearchQuotesClose.TabIndex = 0;
            this.btnSearchQuotesClose.Text = "Close";
            this.btnSearchQuotesClose.UseVisualStyleBackColor = true;
            this.btnSearchQuotesClose.Click += new System.EventHandler(this.btnSearchQuotesClose_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchQuotesClose);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchQuotesClose;
    }
}