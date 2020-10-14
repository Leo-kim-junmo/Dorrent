namespace Dorrent
{
    partial class Form_main
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
            this.bt_folder = new System.Windows.Forms.Button();
            this.lb_choosen = new System.Windows.Forms.Label();
            this.lb_folder = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_folder
            // 
            this.bt_folder.Location = new System.Drawing.Point(13, 13);
            this.bt_folder.Name = "bt_folder";
            this.bt_folder.Size = new System.Drawing.Size(75, 23);
            this.bt_folder.TabIndex = 0;
            this.bt_folder.Text = "폴더 선택";
            this.bt_folder.UseVisualStyleBackColor = true;
            this.bt_folder.Click += new System.EventHandler(this.bt_folder_Click);
            // 
            // lb_choosen
            // 
            this.lb_choosen.AutoSize = true;
            this.lb_choosen.Location = new System.Drawing.Point(13, 50);
            this.lb_choosen.Name = "lb_choosen";
            this.lb_choosen.Size = new System.Drawing.Size(77, 12);
            this.lb_choosen.TabIndex = 1;
            this.lb_choosen.Text = "선택된 폴더 :";
            // 
            // lb_folder
            // 
            this.lb_folder.AutoSize = true;
            this.lb_folder.Location = new System.Drawing.Point(96, 50);
            this.lb_folder.Name = "lb_folder";
            this.lb_folder.Size = new System.Drawing.Size(29, 12);
            this.lb_folder.TabIndex = 2;
            this.lb_folder.Text = "없음";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 70);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(960, 380);
            this.dgv.TabIndex = 3;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lb_folder);
            this.Controls.Add(this.lb_choosen);
            this.Controls.Add(this.bt_folder);
            this.Name = "Form_main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_folder;
        private System.Windows.Forms.Label lb_choosen;
        private System.Windows.Forms.Label lb_folder;
        private System.Windows.Forms.DataGridView dgv;
    }
}