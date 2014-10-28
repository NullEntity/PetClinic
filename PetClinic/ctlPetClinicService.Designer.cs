namespace PetClinic
{
    partial class ctlPetClinicService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValue = new System.Windows.Forms.Label();
            this.cbCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.Location = new System.Drawing.Point(86, 1);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(63, 13);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "label1";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbCheckbox
            // 
            this.cbCheckbox.AutoSize = true;
            this.cbCheckbox.Location = new System.Drawing.Point(0, 0);
            this.cbCheckbox.Name = "cbCheckbox";
            this.cbCheckbox.Size = new System.Drawing.Size(80, 17);
            this.cbCheckbox.TabIndex = 2;
            this.cbCheckbox.Text = "checkBox1";
            this.cbCheckbox.UseVisualStyleBackColor = true;
            this.cbCheckbox.CheckedChanged += new System.EventHandler(this.cbCheckbox_CheckedChanged);
            // 
            // ctlPetClinicService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCheckbox);
            this.Controls.Add(this.lblValue);
            this.Name = "ctlPetClinicService";
            this.Size = new System.Drawing.Size(152, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.CheckBox cbCheckbox;
    }
}
