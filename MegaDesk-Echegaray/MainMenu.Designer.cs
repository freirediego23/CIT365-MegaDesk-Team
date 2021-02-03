
namespace MegaDesk_Echegaray
{
    partial class MainMenu
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
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuote.Location = new System.Drawing.Point(103, 67);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(174, 61);
            this.btnAddNewQuote.TabIndex = 0;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = true;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(103, 154);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(174, 61);
            this.btnViewQuotes.TabIndex = 1;
            this.btnViewQuotes.Text = "&View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = true;
            this.btnViewQuotes.Click += new System.EventHandler(this.btnViewQuotes_Click);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(103, 240);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(174, 61);
            this.btnSearchQuotes.TabIndex = 2;
            this.btnSearchQuotes.Text = "&Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = true;
            this.btnSearchQuotes.Click += new System.EventHandler(this.btnSearchQuotes_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(103, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 61);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnAddNewQuote);
            this.Name = "MainMenu";
            this.Text = "Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnExit;
    }
}

