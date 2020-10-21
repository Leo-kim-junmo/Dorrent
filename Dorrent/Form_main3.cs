using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorrent
{
    public delegate void FTPDownloadTotalSizeHandle(long totalSize);
    public delegate void FTPDownloadReceivedSizeHandle(int rcvSize);

    public partial class Form_main3 : Form
    {
        public event FTPDownloadTotalSizeHandle ftpDNTotalSizeEvt;
        public event FTPDownloadReceivedSizeHandle ftpDNRcvSizeEvt;

        string ftpServerIP = null;
        string ftpUserID = null;
        string ftpPassword = null;
        string ftpPort = null;
        bool usePassive = false;

        public Form_main3()
        {
            InitializeComponent();
        }

        public Boolean Upload(string folder, string filename)
        {
            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://" + ftpServerIP + ":" + ftpPort + "/" + folder + "/" + fileInf.Name;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;
            reqFTP.UsePassive = usePassive;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while(contentLen!=0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();

                return true;
            }

            catch
            {
                MessageBox.Show("FTP 전송중 문제가 발생하였습니다. 네트워크 상황 또는 접속정보를 살펴 보시기 바랍니다.");
                return false;
            }
            // catch(Exception ex) {MessageBox.Show(ex.MEssage, "Upload Error");}
        }

        public void DeleteFTP(string fileNAme)
        {
            try
            {
                string uri = "ftp://" + ftpServerIP + "/" + fileNAme;
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + fileNAme));

                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
            }
            catch
            {
                return;
            }
            // catch(Exception ex) {MessageBox.Show(ex.Message, "FTP 2.0 Delete);}
        }

        public bool GetFilesInfo(string filename, ref DateTime dt)
        {
            try
            {
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + filename));
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = usePassive;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.GetDateTimestamp;

                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                dt = response.LastModified;

                response.Close();
                return true;
            }
            catch
            {
                return false;
            }
            // catch(Exception ex) {Ststem.Windows.Forms.MessageBox.Show(ex.Message); return false;}
        }

        public List<string> GetFilesDetailList(string subFolder)
        {
            List<string> files = new List<string>();
            string line = null;

            try
            {
                // StringBuilder result=new StringBuilder();

                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + subFolder));
                ftp.UseBinary = true;
                ftp.UsePassive = usePassive;
                ftp.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                WebResponse response = ftp.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.Default);

                while((line=reader.ReadLine())!=null)
                {
                    files.Add(line);
                }

                reader.Close();
                response.Close();
                return files;
                // MessageBox.Show(result.ToString().Split('\n'));
            }
            catch
            {
                return files;
            }
            // catch(Exception ex) {System.Windows.Forms.MessageBox.Show(ex.Message); return files;}
        }

        public string[] GetFileList(string subFolder)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;

            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + subFolder));
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = usePassive;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                // MEssageBox.Show(reader.ReadToEnd());
                string line = reader.ReadLine();
                while(line!=null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                // MessageBox.Show(response.StatusDescription);
                return result.ToString().Split('\n');
            }
            catch
            {
                downloadFiles = null;
                return downloadFiles;
            }
            /*
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                downloadFiles=null;
                return downloadFiles;
            }
            */
        }

        public bool checkDir(string localFullPathFile)
        {
            FileInfo fInfo = new FileInfo(localFullPathFile);

            if(!fInfo.Exists)
            {
                DirectoryInfo dInfo = new DirectoryInfo(fInfo.DirectoryName);
                if(!dInfo.Exists)
                {
                    dInfo.Create();
                }
                // dInfo.Delete();
            }
            // fInfo.Delete();
            return true;
        }

        public bool Download(string localFullPathFile, string serverFullPathFile)
        {
            FtpWebRequest reqFTP;
            try
            {
                // filePath=<<The full path where the file is to be created.>>,
                // fileName=<<Name of the file to be created(Need not be the name of the file in FTP server).>>
                checkDir(localFullPathFile);
                FileStream outputStream = new FileStream(localFullPathFile, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + serverFullPathFile));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = usePassive;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;

                if(ftpDNTotalSizeEvt!=null)
                {
                    ftpDNTotalSizeEvt(cl);
                }

                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while(readCount>0)
                {
                    if(ftpDNRcvSizeEvt!=null)
                    {
                        ftpDNRcvSizeEvt(readCount);
                    }

                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch
            {
                return false;
            }
            /*
            catch(Exception ex)
            {
                MessageBox.Show("download()"+ex.Message);
                return false;
            }
            */
        }

        private long GetFileSize(string filename)
        {
            FtpWebRequest reqFTP;
            long fileSize = 0;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + filename));
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = usePassive;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                fileSize = response.ContentLength;

                ftpStream.Close();
                response.Close();

                return fileSize;
            }
            catch
            {
                return fileSize;
            }
            /*
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fileSize;
            */
        }

        public void Rename(string currentFilename, string newFilename)
        {
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/"+currentFilename));
                reqFTP.Method = WebRequestMethods.Ftp.Rename;
                reqFTP.RenameTo = newFilename;
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = usePassive;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch { }
            /*
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        public void MakeDir(string dirName)
        {
            FtpWebRequest reqFTP;
            try
            {
                // dirName=name of the directory to create.
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + dirName));
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = usePassive;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                ftpStream.Close();
                response.Close();
            }
            catch { }
            /*
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            // 연결 버튼
            ftpServerIP = tb_host.Text;
            ftpUserID = tb_name.Text;
            ftpPassword = tb_pass.Text;
            ftpPort = tb_port.Text;
            usePassive = true;
        }

        private void Form_main3_Load(object sender, EventArgs e)
        {
            // System.Security.Principal.WindowsIdentity identity = System.Security.Principal.WindowsIdentity.GetCurrent();
            
            // 현재 로컬 컴퓨터에 존재하는 드라이브 정보 검색하여 트리노드에 추가
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach(DriveInfo dname in allDrives)
            {
                if(dname.DriveType==DriveType.Fixed)
                {
                    if(dname.Name==@"C:\")
                    {
                        TreeNode rootNode = new TreeNode(dname.Name);
                        rootNode.ImageIndex = 0;
                        rootNode.SelectedImageIndex = 0;
                        tv_local.Nodes.Add(rootNode);
                        Fill(rootNode);
                    }
                    else
                    {
                        TreeNode rootNode = new TreeNode(dname.Name);
                        rootNode.ImageIndex = 1;
                        rootNode.SelectedImageIndex = 1;
                        tv_local.Nodes.Add(rootNode);
                        Fill(rootNode);
                    }
                }
            }
            // 첫번째 노드 확장
            tv_local.Nodes[0].Expand();

            // ListView 보기 속성 설정
            lv_local.View = View.Details;

            // ListView Details 속성을 위한 헤더 추가
            lv_local.Columns.Add("이름", lv_local.Width / 4, HorizontalAlignment.Left);
            lv_local.Columns.Add("크기", lv_local.Width / 4, HorizontalAlignment.Left);
            lv_local.Columns.Add("유형", lv_local.Width / 4, HorizontalAlignment.Left);
            lv_local.Columns.Add("수정한 날짜", lv_local.Width / 4, HorizontalAlignment.Left);

            // 행 단위 선택 가능
            lv_local.FullRowSelect = true;
        }

        private void Fill(TreeNode dirNode)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(dirNode.FullPath);
                // 드라이브의 하위 폴더 추가
                foreach(DirectoryInfo dirItem in dir.GetDirectories())
                {
                    TreeNode newNode = new TreeNode(dirItem.Name);
                    newNode.ImageIndex = 2;
                    newNode.SelectedImageIndex = 2;
                    dirNode.Nodes.Add(newNode);
                    newNode.Nodes.Add("*");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.Message);
            }
        }

        private void tv_local_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Nodes[0].Text=="*")
            {
                e.Node.Nodes.Clear();
                e.Node.ImageIndex = 3;
                e.Node.SelectedImageIndex = 3;
                Fill(e.Node);
            }
        }

        private void tv_local_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Node.Nodes[0].Text=="*")
            {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 2;
            }
        }

        private void tv_local_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SettingListView(e.Node.FullPath);
        }

        private void SettingListView(string sFullPath)
        {
            tb_local.Text = sFullPath;

            try
            {
                // 기존의 파일 목록 제거
                lv_local.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(sFullPath);

                int DirectCount = 0;
                // 하부 디텍토리 보여주기
                foreach(DirectoryInfo dirItem in dir.GetDirectories())
                {
                    // 하부 디렉토리가 존재할 경우 ListView에 추가
                    // ListViewItem 객체를 생성
                    ListViewItem lsvitem = new ListViewItem();

                    // 생성된 ListViewItem 객체에 똑같은 이미지를 할당
                    lsvitem.ImageIndex = 2;
                    lsvitem.Text = dirItem.Name;

                    // 아이템을 ListView(lv_local)에 추가
                    lv_local.Items.Add(lsvitem);
                    lv_local.Items[DirectCount].SubItems.Add(dirItem.GetFiles().Length.ToString() + " files");
                    lv_local.Items[DirectCount].SubItems.Add("폴더");
                    lv_local.Items[DirectCount].SubItems.Add(dirItem.CreationTime.ToString());
                    DirectCount++;
                }

                // 디렉토리에 존재하는 파일목록 보여주기
                FileInfo[] files = dir.GetFiles();
                int Count = 0;
                foreach(FileInfo fileinfo in files)
                {
                    lv_local.Items.Add(fileinfo.Name);
                    lv_local.Items[Count].SubItems.Add(fileinfo.Length.ToString()+" kb");
                    lv_local.Items[Count].SubItems.Add(fileinfo.Attributes.ToString());
                    if (fileinfo.LastWriteTime!=null)
                    {
                        lv_local.Items[Count].SubItems.Add(fileinfo.LastWriteTime.ToString());
                    }
                    else
                    {
                        lv_local.Items[Count].SubItems.Add(fileinfo.CreationTime.ToString());
                    }
                    Count++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.Message);
            }
        }
    }
}
