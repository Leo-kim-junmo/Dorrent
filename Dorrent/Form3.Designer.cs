namespace Dorrent
{
    partial class Form_join
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_pw2 = new System.Windows.Forms.TextBox();
            this.bt_join = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PW2 :";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(60, 10);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 3;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(60, 40);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(100, 21);
            this.tb_pw.TabIndex = 4;
            // 
            // tb_pw2
            // 
            this.tb_pw2.Location = new System.Drawing.Point(60, 70);
            this.tb_pw2.Name = "tb_pw2";
            this.tb_pw2.Size = new System.Drawing.Size(100, 21);
            this.tb_pw2.TabIndex = 5;
            // 
            // bt_join
            // 
            this.bt_join.Location = new System.Drawing.Point(13, 100);
            this.bt_join.Name = "bt_join";
            this.bt_join.Size = new System.Drawing.Size(75, 23);
            this.bt_join.TabIndex = 6;
            this.bt_join.Text = "Join";
            this.bt_join.UseVisualStyleBackColor = true;
            this.bt_join.Click += new System.EventHandler(this.bt_join_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(94, 100);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Form_join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_join);
            this.Controls.Add(this.tb_pw2);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_join";
            this.Text = "Join";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_pw2;
        private System.Windows.Forms.Button bt_join;
        private System.Windows.Forms.Button bt_cancel;
    }
}