
namespace D_Anjolell_8_2
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEntry = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.Location = new System.Drawing.Point(233, 238);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 57);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEntry.Location = new System.Drawing.Point(299, 94);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(199, 31);
            this.lblEntry.TabIndex = 1;
            this.lblEntry.Text = "Enter a phrase:";
            // 
            // txtEntry
            // 
            this.txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtEntry.Location = new System.Drawing.Point(233, 160);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(322, 38);
            this.txtEntry.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(197, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Average number of letters";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExit.Location = new System.Drawing.Point(431, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 57);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWords.Location = new System.Drawing.Point(227, 328);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(0, 31);
            this.lblWords.TabIndex = 6;
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLetters.Location = new System.Drawing.Point(227, 380);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(0, 31);
            this.lblLetters.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Average number of letters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblLetters;
    }
}

