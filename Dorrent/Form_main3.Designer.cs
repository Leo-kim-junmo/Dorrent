namespace Dorrent
{
    partial class Form_main3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.lb_port = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_host = new System.Windows.Forms.TextBox();
            this.lb_host = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lb_local = new System.Windows.Forms.Label();
            this.lb_server = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tv_local = new System.Windows.Forms.TreeView();
            this.lv_local = new System.Windows.Forms.ListView();
            this.lv_server = new System.Windows.Forms.ListView();
            this.tv_server = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_connect);
            this.splitContainer1.Panel1.Controls.Add(this.tb_port);
            this.splitContainer1.Panel1.Controls.Add(this.lb_port);
            this.splitContainer1.Panel1.Controls.Add(this.tb_pass);
            this.splitContainer1.Panel1.Controls.Add(this.lb_pass);
            this.splitContainer1.Panel1.Controls.Add(this.tb_name);
            this.splitContainer1.Panel1.Controls.Add(this.lb_name);
            this.splitContainer1.Panel1.Controls.Add(this.tb_host);
            this.splitContainer1.Panel1.Controls.Add(this.lb_host);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 761);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(680, 9);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(560, 10);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 21);
            this.tb_port.TabIndex = 7;
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(517, 15);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(37, 12);
            this.lb_port.TabIndex = 6;
            this.lb_port.Text = "포트 :";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(411, 10);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 21);
            this.tb_pass.TabIndex = 5;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(344, 15);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(61, 12);
            this.lb_pass.TabIndex = 4;
            this.lb_pass.Text = "비밀번호 :";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(238, 10);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 21);
            this.tb_name.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(171, 15);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(61, 12);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "사용자명 :";
            // 
            // tb_host
            // 
            this.tb_host.Location = new System.Drawing.Point(65, 10);
            this.tb_host.Name = "tb_host";
            this.tb_host.Size = new System.Drawing.Size(100, 21);
            this.tb_host.TabIndex = 1;
            // 
            // lb_host
            // 
            this.lb_host.AutoSize = true;
            this.lb_host.Location = new System.Drawing.Point(10, 15);
            this.lb_host.Name = "lb_host";
            this.lb_host.Size = new System.Drawing.Size(49, 12);
            this.lb_host.TabIndex = 0;
            this.lb_host.Text = "호스트 :";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tb_local);
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.lb_local);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel2.Controls.Add(this.tb_server);
            this.splitContainer2.Panel2.Controls.Add(this.lb_server);
            this.splitContainer2.Size = new System.Drawing.Size(784, 716);
            this.splitContainer2.SplitterDistance = 390;
            this.splitContainer2.TabIndex = 0;
            // 
            // lb_local
            // 
            this.lb_local.AutoSize = true;
            this.lb_local.Location = new System.Drawing.Point(5, 5);
            this.lb_local.Name = "lb_local";
            this.lb_local.Size = new System.Drawing.Size(65, 12);
            this.lb_local.TabIndex = 0;
            this.lb_local.Text = "로컬사이트";
            // 
            // lb_server
            // 
            this.lb_server.AutoSize = true;
            this.lb_server.Location = new System.Drawing.Point(5, 5);
            this.lb_server.Name = "lb_server";
            this.lb_server.Size = new System.Drawing.Size(65, 12);
            this.lb_server.TabIndex = 1;
            this.lb_server.Text = "서버사이트";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer3.Location = new System.Drawing.Point(0, 23);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tv_local);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lv_local);
            this.splitContainer3.Size = new System.Drawing.Size(390, 693);
            this.splitContainer3.SplitterDistance = 274;
            this.splitContainer3.TabIndex = 1;
            // 
            // tb_local
            // 
            this.tb_local.Location = new System.Drawing.Point(75, 1);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(312, 21);
            this.tb_local.TabIndex = 2;
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(75, 1);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(312, 21);
            this.tb_server.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer4.Location = new System.Drawing.Point(0, 23);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tv_server);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.lv_server);
            this.splitContainer4.Size = new System.Drawing.Size(390, 693);
            this.splitContainer4.SplitterDistance = 274;
            this.splitContainer4.TabIndex = 4;
            // 
            // tv_local
            // 
            this.tv_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_local.Location = new System.Drawing.Point(0, 0);
            this.tv_local.Name = "tv_local";
            this.tv_local.Size = new System.Drawing.Size(390, 274);
            this.tv_local.TabIndex = 0;
            // 
            // lv_local
            // 
            this.lv_local.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_local.HideSelection = false;
            this.lv_local.Location = new System.Drawing.Point(0, 0);
            this.lv_local.Name = "lv_local";
            this.lv_local.Size = new System.Drawing.Size(390, 415);
            this.lv_local.TabIndex = 0;
            this.lv_local.UseCompatibleStateImageBehavior = false;
            // 
            // lv_server
            // 
            this.lv_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_server.HideSelection = false;
            this.lv_server.Location = new System.Drawing.Point(0, 0);
            this.lv_server.Name = "lv_server";
            this.lv_server.Size = new System.Drawing.Size(390, 415);
            this.lv_server.TabIndex = 0;
            this.lv_server.UseCompatibleStateImageBehavior = false;
            // 
            // tv_server
            // 
            this.tv_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_server.Location = new System.Drawing.Point(0, 0);
            this.tv_server.Name = "tv_server";
            this.tv_server.Size = new System.Drawing.Size(390, 274);
            this.tv_server.TabIndex = 0;
            // 
            // Form_main3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_main3";
            this.Text = "Form_main3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_host;
        private System.Windows.Forms.Label lb_host;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lb_local;
        private System.Windows.Forms.Label lb_server;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView tv_local;
        private System.Windows.Forms.ListView lv_local;
        private System.Windows.Forms.ListView lv_server;
        private System.Windows.Forms.TreeView tv_server;
    }
}