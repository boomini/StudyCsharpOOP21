
namespace ApplicationDev
{
    partial class FM_Passwords
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
            this.txtUserId = new System.Windows.Forms.Label();
            this.txtBeforePw = new System.Windows.Forms.Label();
            this.txtChangePw = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPerPW = new System.Windows.Forms.TextBox();
            this.txtNowPW = new System.Windows.Forms.TextBox();
            this.btnPwChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.AutoSize = true;
            this.txtUserId.Location = new System.Drawing.Point(46, 66);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(74, 20);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.Text = "사용자 ID";
            // 
            // txtBeforePw
            // 
            this.txtBeforePw.AutoSize = true;
            this.txtBeforePw.Location = new System.Drawing.Point(46, 112);
            this.txtBeforePw.Name = "txtBeforePw";
            this.txtBeforePw.Size = new System.Drawing.Size(67, 20);
            this.txtBeforePw.TabIndex = 1;
            this.txtBeforePw.Text = "이전 PW";
            // 
            // txtChangePw
            // 
            this.txtChangePw.AutoSize = true;
            this.txtChangePw.Location = new System.Drawing.Point(46, 168);
            this.txtChangePw.Name = "txtChangePw";
            this.txtChangePw.Size = new System.Drawing.Size(67, 20);
            this.txtChangePw.TabIndex = 2;
            this.txtChangePw.Text = "변경 PW";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(404, 27);
            this.txtID.TabIndex = 3;
            // 
            // txtPerPW
            // 
            this.txtPerPW.Location = new System.Drawing.Point(136, 112);
            this.txtPerPW.Name = "txtPerPW";
            this.txtPerPW.Size = new System.Drawing.Size(404, 27);
            this.txtPerPW.TabIndex = 4;
            // 
            // txtNowPW
            // 
            this.txtNowPW.Location = new System.Drawing.Point(136, 168);
            this.txtNowPW.Name = "txtNowPW";
            this.txtNowPW.Size = new System.Drawing.Size(404, 27);
            this.txtNowPW.TabIndex = 5;
            // 
            // btnPwChange
            // 
            this.btnPwChange.Location = new System.Drawing.Point(300, 284);
            this.btnPwChange.Name = "btnPwChange";
            this.btnPwChange.Size = new System.Drawing.Size(94, 29);
            this.btnPwChange.TabIndex = 6;
            this.btnPwChange.Text = "변경등록";
            this.btnPwChange.UseVisualStyleBackColor = true;
            this.btnPwChange.Click += new System.EventHandler(this.btnPwChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(459, 284);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FM_Passwords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 334);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPwChange);
            this.Controls.Add(this.txtNowPW);
            this.Controls.Add(this.txtPerPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtChangePw);
            this.Controls.Add(this.txtBeforePw);
            this.Controls.Add(this.txtUserId);
            this.Name = "FM_Passwords";
            this.Text = "비밀번호 변경";
            this.Load += new System.EventHandler(this.FM_Passwords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUserId;
        private System.Windows.Forms.Label txtBeforePw;
        private System.Windows.Forms.Label txtChangePw;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPerPW;
        private System.Windows.Forms.TextBox txtNowPW;
        private System.Windows.Forms.Button btnPwChange;
        private System.Windows.Forms.Button btnClose;

    }
}