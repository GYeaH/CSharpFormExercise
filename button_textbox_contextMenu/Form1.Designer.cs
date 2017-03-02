namespace button_textbox_contectMenu
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.changeButton = new System.Windows.Forms.Button();
            this.buttonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.formContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duplicateFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addControToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonContextMenuStrip.SuspendLayout();
            this.formContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Yellow;
            this.changeButton.ContextMenuStrip = this.buttonContextMenuStrip;
            this.changeButton.Location = new System.Drawing.Point(12, 38);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "CHANGE";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            this.changeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changeButton_MouseDown);
            // 
            // buttonContextMenuStrip
            // 
            this.buttonContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.buttonContextMenuStrip.Name = "buttonContextMenuStrip";
            this.buttonContextMenuStrip.Size = new System.Drawing.Size(102, 48);
            this.buttonContextMenuStrip.Text = "buttonContextMenuStrip";
            this.buttonContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.buttonContextMenuStrip_Opening);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.bigToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sizeToolStripMenuItem.Text = "size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.smallToolStripMenuItem.Text = "small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.bigToolStripMenuItem.Text = "big";
            this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "color";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.whiteToolStripMenuItem.Text = "white";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.blackToolStripMenuItem.Text = "black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 20);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "X:    Y:    Color:          ";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // formContextMenuStrip
            // 
            this.formContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateFormToolStripMenuItem,
            this.addControToolStripMenuItem});
            this.formContextMenuStrip.Name = "formContextMenuStrip";
            this.formContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // duplicateFormToolStripMenuItem
            // 
            this.duplicateFormToolStripMenuItem.Name = "duplicateFormToolStripMenuItem";
            this.duplicateFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.duplicateFormToolStripMenuItem.Text = "duplicate form";
            this.duplicateFormToolStripMenuItem.Click += new System.EventHandler(this.duplicateFormToolStripMenuItem_Click);
            // 
            // addControToolStripMenuItem
            // 
            this.addControToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonToolStripMenuItem,
            this.texboxToolStripMenuItem});
            this.addControToolStripMenuItem.Name = "addControToolStripMenuItem";
            this.addControToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addControToolStripMenuItem.Text = "add control";
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.buttonToolStripMenuItem.Text = "button";
            this.buttonToolStripMenuItem.Click += new System.EventHandler(this.buttonToolStripMenuItem_Click);
            // 
            // texboxToolStripMenuItem
            // 
            this.texboxToolStripMenuItem.Name = "texboxToolStripMenuItem";
            this.texboxToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.texboxToolStripMenuItem.Text = "texbox";
            this.texboxToolStripMenuItem.Click += new System.EventHandler(this.texboxToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.ContextMenuStrip = this.formContextMenuStrip;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.changeButton);
            this.Name = "MainForm";
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.buttonContextMenuStrip.ResumeLayout(false);
            this.formContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ContextMenuStrip buttonContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip formContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem duplicateFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addControToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texboxToolStripMenuItem;
    }
}

