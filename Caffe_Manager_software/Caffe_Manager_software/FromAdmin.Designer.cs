namespace Caffe_Manager_software
{
    partial class frmAdmin
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMemberList = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnCustorm = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(468, 21);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(66, 24);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnMemberList
            // 
            this.btnMemberList.Location = new System.Drawing.Point(46, 72);
            this.btnMemberList.Name = "btnMemberList";
            this.btnMemberList.Size = new System.Drawing.Size(107, 38);
            this.btnMemberList.TabIndex = 0;
            this.btnMemberList.Text = "Danh Sach Nhan Vien";
            this.btnMemberList.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(186, 72);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(107, 38);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCustorm
            // 
            this.btnCustorm.Location = new System.Drawing.Point(333, 72);
            this.btnCustorm.Name = "btnCustorm";
            this.btnCustorm.Size = new System.Drawing.Size(107, 38);
            this.btnCustorm.TabIndex = 2;
            this.btnCustorm.Text = "Khach Hang Than Thiet";
            this.btnCustorm.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(46, 152);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(107, 38);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Hoa Don";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnSystem
            // 
            this.btnSystem.Location = new System.Drawing.Point(186, 152);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(107, 38);
            this.btnSystem.TabIndex = 4;
            this.btnSystem.Text = "He Thong";
            this.btnSystem.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 277);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnCustorm);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnMemberList);
            this.Controls.Add(this.btnLogOut);
            this.Name = "frmAdmin";
            this.Text = "FromAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMemberList;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnCustorm;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnSystem;
    }
}