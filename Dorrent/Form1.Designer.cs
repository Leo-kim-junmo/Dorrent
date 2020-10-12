namespace Dorrent
{
    partial class Form_login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_join = new System.Windows.Forms.Button();
            this.bt_find = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(13, 13);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(24, 12);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "ID :";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Location = new System.Drawing.Point(13, 43);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(31, 12);
            this.lb_pw.TabIndex = 1;
            this.lb_pw.Text = "PW :";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(60, 10);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 2;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(60, 40);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(100, 21);
            this.tb_pw.TabIndex = 3;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(15, 70);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Log in";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_join
            // 
            this.bt_join.Location = new System.Drawing.Point(96, 70);
            this.bt_join.Name = "bt_join";
            this.bt_join.Size = new System.Drawing.Size(75, 23);
            this.bt_join.TabIndex = 5;
            this.bt_join.Text = "Join";
            this.bt_join.UseVisualStyleBackColor = true;
            this.bt_join.Click += new System.EventHandler(this.bt_join_Click);
            // 
            // bt_find
            // 
            this.bt_find.Location = new System.Drawing.Point(177, 70);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(75, 23);
            this.bt_find.TabIndex = 6;
            this.bt_find.Text = "Find";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(258, 70);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.bt_join);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_pw);
            this.Controls.Add(this.lb_id);
            this.Name = "Form_login";
            this.Text = "Dorrent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_join;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Button bt_cancel;
    }
}

