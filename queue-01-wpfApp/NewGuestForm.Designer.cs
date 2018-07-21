namespace queue_01_wpfApp
{
    partial class NewGuestForm
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
            this.newGuestNameTextBox = new System.Windows.Forms.TextBox();
            this.newGuestPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partySizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.addGuestFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partySizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Guest Name";
            // 
            // newGuestNameTextBox
            // 
            this.newGuestNameTextBox.Location = new System.Drawing.Point(22, 35);
            this.newGuestNameTextBox.MaxLength = 25;
            this.newGuestNameTextBox.Name = "newGuestNameTextBox";
            this.newGuestNameTextBox.Size = new System.Drawing.Size(243, 20);
            this.newGuestNameTextBox.TabIndex = 1;
            // 
            // newGuestPhoneTextBox
            // 
            this.newGuestPhoneTextBox.Location = new System.Drawing.Point(22, 83);
            this.newGuestPhoneTextBox.MaxLength = 12;
            this.newGuestPhoneTextBox.Name = "newGuestPhoneTextBox";
            this.newGuestPhoneTextBox.Size = new System.Drawing.Size(156, 20);
            this.newGuestPhoneTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number ###-###-####";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Party Size";
            // 
            // partySizeUpDown
            // 
            this.partySizeUpDown.Location = new System.Drawing.Point(222, 83);
            this.partySizeUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.partySizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partySizeUpDown.Name = "partySizeUpDown";
            this.partySizeUpDown.Size = new System.Drawing.Size(43, 20);
            this.partySizeUpDown.TabIndex = 3;
            this.partySizeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // addGuestFormButton
            // 
            this.addGuestFormButton.BackColor = System.Drawing.Color.LightBlue;
            this.addGuestFormButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addGuestFormButton.Location = new System.Drawing.Point(101, 132);
            this.addGuestFormButton.Name = "addGuestFormButton";
            this.addGuestFormButton.Size = new System.Drawing.Size(108, 36);
            this.addGuestFormButton.TabIndex = 4;
            this.addGuestFormButton.Text = "Add Guest";
            this.addGuestFormButton.UseVisualStyleBackColor = false;
            this.addGuestFormButton.Click += new System.EventHandler(this.addGuestFormButton_Click);
            // 
            // NewGuestForm
            // 
            this.AcceptButton = this.addGuestFormButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(299, 192);
            this.Controls.Add(this.addGuestFormButton);
            this.Controls.Add(this.partySizeUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newGuestPhoneTextBox);
            this.Controls.Add(this.newGuestNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewGuestForm";
            this.Text = "Add Guest ";
            ((System.ComponentModel.ISupportInitialize)(this.partySizeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newGuestNameTextBox;
        private System.Windows.Forms.TextBox newGuestPhoneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown partySizeUpDown;
        private System.Windows.Forms.Button addGuestFormButton;
    }
}