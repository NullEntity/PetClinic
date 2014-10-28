namespace PetClinic
{
    partial class frmPetClinic
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalDesc = new System.Windows.Forms.Label();
            this.pcsService8 = new PetClinic.ctlPetClinicService();
            this.pcsService7 = new PetClinic.ctlPetClinicService();
            this.pcsService6 = new PetClinic.ctlPetClinicService();
            this.pcsService5 = new PetClinic.ctlPetClinicService();
            this.pcsService4 = new PetClinic.ctlPetClinicService();
            this.pcsService3 = new PetClinic.ctlPetClinicService();
            this.pcsService2 = new PetClinic.ctlPetClinicService();
            this.pcsService1 = new PetClinic.ctlPetClinicService();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(187, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(106, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.pcsService8);
            this.grpOptions.Controls.Add(this.pcsService7);
            this.grpOptions.Controls.Add(this.pcsService6);
            this.grpOptions.Controls.Add(this.pcsService5);
            this.grpOptions.Controls.Add(this.pcsService4);
            this.grpOptions.Controls.Add(this.pcsService3);
            this.grpOptions.Controls.Add(this.pcsService2);
            this.grpOptions.Controls.Add(this.pcsService1);
            this.grpOptions.Location = new System.Drawing.Point(13, 13);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(249, 220);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(205, 236);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalDesc
            // 
            this.lblTotalDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDesc.AutoSize = true;
            this.lblTotalDesc.Location = new System.Drawing.Point(165, 236);
            this.lblTotalDesc.Name = "lblTotalDesc";
            this.lblTotalDesc.Size = new System.Drawing.Size(34, 13);
            this.lblTotalDesc.TabIndex = 1;
            this.lblTotalDesc.Text = "Total:";
            // 
            // pcsService8
            // 
            this.pcsService8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService8.Location = new System.Drawing.Point(6, 194);
            this.pcsService8.Name = "pcsService8";
            this.pcsService8.ServiceName = "Dental Checkup";
            this.pcsService8.Size = new System.Drawing.Size(237, 19);
            this.pcsService8.TabIndex = 7;
            this.pcsService8.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // pcsService7
            // 
            this.pcsService7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService7.Location = new System.Drawing.Point(6, 169);
            this.pcsService7.Name = "pcsService7";
            this.pcsService7.ServiceName = "Screening";
            this.pcsService7.Size = new System.Drawing.Size(237, 19);
            this.pcsService7.TabIndex = 6;
            this.pcsService7.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // pcsService6
            // 
            this.pcsService6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService6.Location = new System.Drawing.Point(6, 144);
            this.pcsService6.Name = "pcsService6";
            this.pcsService6.ServiceName = "Boarding (One Day)";
            this.pcsService6.Size = new System.Drawing.Size(237, 19);
            this.pcsService6.TabIndex = 5;
            this.pcsService6.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // pcsService5
            // 
            this.pcsService5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService5.Location = new System.Drawing.Point(6, 119);
            this.pcsService5.Name = "pcsService5";
            this.pcsService5.ServiceName = "Standard Checkup";
            this.pcsService5.Size = new System.Drawing.Size(237, 19);
            this.pcsService5.TabIndex = 4;
            this.pcsService5.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // pcsService4
            // 
            this.pcsService4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService4.Location = new System.Drawing.Point(6, 94);
            this.pcsService4.Name = "pcsService4";
            this.pcsService4.ServiceName = "House Call";
            this.pcsService4.Size = new System.Drawing.Size(237, 19);
            this.pcsService4.TabIndex = 3;
            this.pcsService4.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // pcsService3
            // 
            this.pcsService3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService3.Location = new System.Drawing.Point(6, 69);
            this.pcsService3.Name = "pcsService3";
            this.pcsService3.ServiceName = "Grooming";
            this.pcsService3.Size = new System.Drawing.Size(237, 19);
            this.pcsService3.TabIndex = 2;
            this.pcsService3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // pcsService2
            // 
            this.pcsService2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService2.Location = new System.Drawing.Point(6, 44);
            this.pcsService2.Name = "pcsService2";
            this.pcsService2.ServiceName = "Vaccination";
            this.pcsService2.Size = new System.Drawing.Size(237, 19);
            this.pcsService2.TabIndex = 1;
            this.pcsService2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // pcsService1
            // 
            this.pcsService1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcsService1.Location = new System.Drawing.Point(6, 19);
            this.pcsService1.Name = "pcsService1";
            this.pcsService1.ServiceName = "In Office Checkup";
            this.pcsService1.Size = new System.Drawing.Size(237, 19);
            this.pcsService1.TabIndex = 0;
            this.pcsService1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // frmPetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 290);
            this.Controls.Add(this.lblTotalDesc);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "frmPetClinic";
            this.Text = "Lions, Tigers, and Bears Pet Clinic";
            this.Load += new System.EventHandler(this.frmPetClinic_Load);
            this.grpOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalDesc;
        private ctlPetClinicService pcsService1;
        private ctlPetClinicService pcsService7;
        private ctlPetClinicService pcsService6;
        private ctlPetClinicService pcsService5;
        private ctlPetClinicService pcsService4;
        private ctlPetClinicService pcsService3;
        private ctlPetClinicService pcsService2;
        private ctlPetClinicService pcsService8;

    }
}

