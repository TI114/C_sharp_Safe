namespace safeNamespace
{
    partial class Control
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCloseOpen = new System.Windows.Forms.Button();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(28, 33);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(77, 34);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCloseOpen
            // 
            this.BtnCloseOpen.Location = new System.Drawing.Point(28, 84);
            this.BtnCloseOpen.Name = "BtnCloseOpen";
            this.BtnCloseOpen.Size = new System.Drawing.Size(77, 34);
            this.BtnCloseOpen.TabIndex = 1;
            this.BtnCloseOpen.Text = "Open/Close";
            this.BtnCloseOpen.UseVisualStyleBackColor = true;
            this.BtnCloseOpen.Click += new System.EventHandler(this.BtnCloseOpen_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(241, 41);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(100, 20);
            this.TbPassword.TabIndex = 2;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 364);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.BtnCloseOpen);
            this.Controls.Add(this.BtnCreate);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCloseOpen;
        private System.Windows.Forms.TextBox TbPassword;
    }
}