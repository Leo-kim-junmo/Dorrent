using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;

namespace Dorrent
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void bt_folder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if(dialog.ShowDialog()==CommonFileDialogResult.Ok)
            {
                lb_folder.Text = dialog.FileName;
                DataTable dt_filelist = FileList(dialog.FileName);
                ShowDataTable(dt_filelist, dgv);
            }
        }

        private DataTable FileList(string FolderName)
        {
            DirectoryInfo di = new DirectoryInfo(FolderName);
            DataTable dt = new DataTable();
            dt.Columns.Add("Folder", typeof(string));
            dt.Columns.Add("FileName", typeof(string));
            dt.Columns.Add("Extension", typeof(string));
            dt.Columns.Add("CreationTime", typeof(DateTime));
            dt.Columns.Add("LastWriteTime", typeof(DateTime));
            dt.Columns.Add("LastAccessTime", typeof(DateTime));

            foreach(FileInfo File in di.GetFiles())
            {
                dt.Rows.Add(File.DirectoryName, File.Name, File.Extension, File.CreationTime, File.LastWriteTime, File.LastAccessTime);
            }

            return dt;
        }

        private void ShowDataTable(DataTable dt, DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            foreach(DataColumn dc in dt.Columns)
            {
                dgv.Columns.Add(dc.ColumnName, dc.ColumnName);
            }

            int row_index = 0;
            foreach(DataRow dr in dt.Rows)
            {
                dgv.Rows.Add();
                foreach(DataColumn dc in dt.Columns)
                {
                    dgv.Rows[row_index].Cells[dc.ColumnName].Value = dr[dc.ColumnName];
                }
                row_index++;
            }

            foreach(DataGridViewColumn drvc in dgv.Columns)
            {
                drvc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
