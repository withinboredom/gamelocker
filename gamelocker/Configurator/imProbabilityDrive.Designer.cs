namespace Configurator
{
    partial class imProbabilityDrive
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
            this.numericUpDownPicker = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPicker
            // 
            this.numericUpDownPicker.Location = new System.Drawing.Point(9, 15);
            this.numericUpDownPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPicker.Name = "numericUpDownPicker";
            this.numericUpDownPicker.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPicker.TabIndex = 0;
            this.numericUpDownPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(135, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(216, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // imProbabilityDrive
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(301, 46);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "imProbabilityDrive";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Pick a number";
            this.Load += new System.EventHandler(this.imProbabilityDrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.NumericUpDown numericUpDownPicker;
    }
}