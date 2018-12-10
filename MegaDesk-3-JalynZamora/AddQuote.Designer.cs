namespace MegaDesk_3_JalynZamora
{
    partial class AddQuote
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
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthInput_Validating = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.Label();
            this.depthInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput_Validating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(22, 388);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(133, 35);
            this.MainMenuButton.TabIndex = 0;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(0, 0);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 9;
            // 
            // widthLabel
            // 
            this.widthLabel.Location = new System.Drawing.Point(0, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(100, 23);
            this.widthLabel.TabIndex = 8;
            // 
            // depthLabel
            // 
            this.depthLabel.Location = new System.Drawing.Point(385, 106);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(49, 19);
            this.depthLabel.TabIndex = 7;
            this.depthLabel.Text = "Depth:";
            // 
            // widthInput_Validating
            // 
            this.widthInput_Validating.Location = new System.Drawing.Point(141, 104);
            this.widthInput_Validating.Name = "widthInput_Validating";
            this.widthInput_Validating.Size = new System.Drawing.Size(167, 20);
            this.widthInput_Validating.TabIndex = 5;
            this.widthInput_Validating.ValueChanged += new System.EventHandler(this.WidthInput_Validating);
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(97, 106);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(38, 13);
            this.width.TabIndex = 10;
            this.width.Text = "Width:";
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(440, 104);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(167, 20);
            this.depthInput.TabIndex = 12;
            this.depthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthInput_KeyPress);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 435);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.width);
            this.Controls.Add(this.widthInput_Validating);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthInput_Validating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.NumericUpDown widthInput_Validating;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.NumericUpDown depthInput;
    }
}