
namespace MegaDesk_Echegaray
{
    partial class ViewAllQuotes
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
            this.btnViewAllQuotesClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewAllQuotesClose
            // 
            this.btnViewAllQuotesClose.Location = new System.Drawing.Point(518, 333);
            this.btnViewAllQuotesClose.Name = "btnViewAllQuotesClose";
            this.btnViewAllQuotesClose.Size = new System.Drawing.Size(215, 67);
            this.btnViewAllQuotesClose.TabIndex = 0;
            this.btnViewAllQuotesClose.Text = "Close";
            this.btnViewAllQuotesClose.UseVisualStyleBackColor = true;
            this.btnViewAllQuotesClose.Click += new System.EventHandler(this.btnViewAllQuotesClose_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewAllQuotesClose);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewAllQuotesClose;
    }
}