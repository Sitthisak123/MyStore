namespace MyStore
{
    partial class form_menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ขายสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คลงสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.สรปยอดขายToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ปดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 411);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขายสนคาToolStripMenuItem,
            this.คลงสนคาToolStripMenuItem,
            this.สรปยอดขายToolStripMenuItem,
            this.ปดโปรแกรมToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ขายสนคาToolStripMenuItem
            // 
            this.ขายสนคาToolStripMenuItem.Name = "ขายสนคาToolStripMenuItem";
            this.ขายสนคาToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ขายสนคาToolStripMenuItem.Text = "ขายสินค้า";
            this.ขายสนคาToolStripMenuItem.Click += new System.EventHandler(this.ขายสนคาToolStripMenuItem_Click);
            // 
            // คลงสนคาToolStripMenuItem
            // 
            this.คลงสนคาToolStripMenuItem.Name = "คลงสนคาToolStripMenuItem";
            this.คลงสนคาToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.คลงสนคาToolStripMenuItem.Text = "คลังสินค้า";
            this.คลงสนคาToolStripMenuItem.Click += new System.EventHandler(this.คลงสนคาToolStripMenuItem_Click);
            // 
            // สรปยอดขายToolStripMenuItem
            // 
            this.สรปยอดขายToolStripMenuItem.Name = "สรปยอดขายToolStripMenuItem";
            this.สรปยอดขายToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.สรปยอดขายToolStripMenuItem.Text = "สรุปยอดขาย";
            this.สรปยอดขายToolStripMenuItem.Click += new System.EventHandler(this.สรปยอดขายToolStripMenuItem_Click);
            // 
            // ปดโปรแกรมToolStripMenuItem
            // 
            this.ปดโปรแกรมToolStripMenuItem.Name = "ปดโปรแกรมToolStripMenuItem";
            this.ปดโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.ปดโปรแกรมToolStripMenuItem.Text = "ปิดโปรแกรม";
            this.ปดโปรแกรมToolStripMenuItem.Click += new System.EventHandler(this.ปดโปรแกรมToolStripMenuItem_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_menu";
            this.Text = "form_menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ขายสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คลงสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem สรปยอดขายToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ปดโปรแกรมToolStripMenuItem;
    }
}