namespace MyStore
{
    partial class Form_SalesSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProducts_saled = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sales Summary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBoxProducts_saled
            // 
            this.listBoxProducts_saled.FormattingEnabled = true;
            this.listBoxProducts_saled.Location = new System.Drawing.Point(191, 145);
            this.listBoxProducts_saled.Name = "listBoxProducts_saled";
            this.listBoxProducts_saled.Size = new System.Drawing.Size(346, 199);
            this.listBoxProducts_saled.TabIndex = 5;
            // 
            // Form_SalesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProducts_saled);
            this.Controls.Add(this.label1);
            this.Name = "Form_SalesSummary";
            this.Text = "Form_SalesSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProducts_saled;
    }
}