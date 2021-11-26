namespace WindowsFormsApp1
{
    partial class CalculatorGUI
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
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.OutcomeButton = new System.Windows.Forms.Button();
            this.OutcomeLabel = new System.Windows.Forms.Label();
            this.OutcomeDescriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InputField = new WindowsFormsApp1.DecimalTextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(24, 48);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(34, 23);
            this.MultiplyButton.TabIndex = 2;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(64, 48);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(31, 23);
            this.DivideButton.TabIndex = 13;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(139, 48);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(34, 23);
            this.MinusButton.TabIndex = 5;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(101, 48);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(32, 23);
            this.PlusButton.TabIndex = 4;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // OutcomeButton
            // 
            this.OutcomeButton.Location = new System.Drawing.Point(139, 22);
            this.OutcomeButton.Name = "OutcomeButton";
            this.OutcomeButton.Size = new System.Drawing.Size(34, 23);
            this.OutcomeButton.TabIndex = 1;
            this.OutcomeButton.Text = "=";
            this.OutcomeButton.UseVisualStyleBackColor = true;
            this.OutcomeButton.Click += new System.EventHandler(this.OutcomeButton_Click);
            // 
            // OutcomeLabel
            // 
            this.OutcomeLabel.AutoSize = true;
            this.OutcomeLabel.Location = new System.Drawing.Point(121, 9);
            this.OutcomeLabel.Name = "OutcomeLabel";
            this.OutcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutcomeLabel.Size = new System.Drawing.Size(13, 13);
            this.OutcomeLabel.TabIndex = 6;
            this.OutcomeLabel.Text = "0";
            this.OutcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.OutcomeLabel.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // OutcomeDescriptionLabel
            // 
            this.OutcomeDescriptionLabel.AutoSize = true;
            this.OutcomeDescriptionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutcomeDescriptionLabel.Location = new System.Drawing.Point(21, 9);
            this.OutcomeDescriptionLabel.Name = "OutcomeDescriptionLabel";
            this.OutcomeDescriptionLabel.Size = new System.Drawing.Size(76, 13);
            this.OutcomeDescriptionLabel.TabIndex = 7;
            this.OutcomeDescriptionLabel.Text = "The answer is:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.InputField);
            this.panel1.Controls.Add(this.MinusButton);
            this.panel1.Controls.Add(this.MultiplyButton);
            this.panel1.Controls.Add(this.DivideButton);
            this.panel1.Controls.Add(this.PlusButton);
            this.panel1.Controls.Add(this.OutcomeButton);
            this.panel1.Location = new System.Drawing.Point(36, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(139, 75);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(34, 19);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.OutcomeDescriptionLabel);
            this.panel2.Controls.Add(this.OutcomeLabel);
            this.panel2.Location = new System.Drawing.Point(36, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 60);
            this.panel2.TabIndex = 9;
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(24, 22);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(109, 20);
            this.InputField.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(23, 35);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 8;
            // 
            // CalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorGUI";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculatorForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button OutcomeButton;
        private System.Windows.Forms.Label OutcomeLabel;
        private System.Windows.Forms.Label OutcomeDescriptionLabel;
        private System.Windows.Forms.Panel panel1;
        private DecimalTextBox InputField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}

