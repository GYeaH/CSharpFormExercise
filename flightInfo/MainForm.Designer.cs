namespace flightInfo
{
    partial class Form
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
            this.idLabel = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(98, 115);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(57, 155);
            this.originLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(67, 20);
            this.originLabel.TabIndex = 1;
            this.originLabel.Text = "ORIGIN";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(4, 195);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(116, 20);
            this.destinationLabel.TabIndex = 2;
            this.destinationLabel.Text = "DESTINATION";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(70, 235);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(52, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "DATE";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(75, 280);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(47, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "TIME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "FLIGHT INFO";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(152, 111);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(148, 26);
            this.idTextBox.TabIndex = 6;
            // 
            // originTextBox
            // 
            this.originTextBox.Location = new System.Drawing.Point(152, 151);
            this.originTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(148, 26);
            this.originTextBox.TabIndex = 7;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(152, 191);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(148, 26);
            this.destinationTextBox.TabIndex = 8;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(152, 231);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(148, 26);
            this.dateTextBox.TabIndex = 9;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(152, 275);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(148, 26);
            this.timeTextBox.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(170, 334);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 35);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.Location = new System.Drawing.Point(4, 9);
            this.summaryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(318, 33);
            this.summaryLabel.TabIndex = 12;
            this.summaryLabel.Text = "Summary show here";
            this.summaryLabel.Click += new System.EventHandler(this.summaryLabel_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.idLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label summaryLabel;
    }
}

