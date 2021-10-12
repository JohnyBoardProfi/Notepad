namespace Notepad
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.lblExample = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(69, 46);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(42, 13);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Sample";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.55F);
            this.lblExample.Location = new System.Drawing.Point(81, 59);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(132, 29);
            this.lblExample.TabIndex = 1;
            this.lblExample.Text = "AaBbYyZz";
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36"});
            this.cbFont.Location = new System.Drawing.Point(135, 22);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(78, 21);
            this.cbFont.TabIndex = 2;
            this.cbFont.SelectedValueChanged += new System.EventHandler(this.cbFont_SelectedValueChanged);
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "обычный",
            "курсив",
            "полужирный",
            "линия по середине",
            "подчёркнутый"});
            this.cbStyle.Location = new System.Drawing.Point(12, 22);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(117, 21);
            this.cbStyle.TabIndex = 3;
            this.cbStyle.SelectedValueChanged += new System.EventHandler(this.cbStyle_SelectedValueChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(138, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(9, 6);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(55, 13);
            this.lblStyle.TabIndex = 5;
            this.lblStyle.Text = "Font style:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(135, 6);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Size";
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 123);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblSize;
    }
}