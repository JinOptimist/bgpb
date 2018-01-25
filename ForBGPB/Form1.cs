using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ForBGPB.MyFile;
using ForBGPB.Properties;

namespace ForBGPB
{
    public partial class Form1 : Form
    {
        private readonly List<DirBlock> _blockList;

        private int _lastUpdateWas = 0;

        private static int _allBlockTop = 36;

        public Form1()
        {
            InitializeComponent();

            var directoriesPath = Settings.Default.FilesPath;

            this.Text = Settings.Default.FormName;

            this.Width = Settings.Default.WidthOneBlock * directoriesPath.Count + 10 * (directoriesPath.Count + 3); // + 3 нужно для отступов до первого и после последнего блока
            this.Height = Settings.Default.HeightOneBlock + _allBlockTop + 50;

            _blockList = new List<DirBlock>();

            var i = 0;
            foreach (var dirPath in directoriesPath)
            {
                var txtBoxDir = CreateTxtBoxDir(i);
                var lblDir = CreateLabelDir(dirPath, i++);

                var pair = new DirBlock(lblDir, txtBoxDir, dirPath, new List<string>());
                _blockList.Add(pair);

                this.Controls.Add(txtBoxDir);
                this.Controls.Add(lblDir);
            }

            lblLastUpdate.Text = string.Format(Settings.Default.LastUpdateMessange, _lastUpdateWas);

            switch (Settings.Default.SortType)
            {
                case 1:
                    {
                        rdBtnSort1.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdBtnSort2.Checked = true;
                        break;
                    }
                case 3:
                    {
                        rdBtnSort3.Checked = true;
                        break;
                    }
            }

            switch (Settings.Default.SortDirect)
            {
                case 1:
                    {
                        rdBtnDirectTop.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdBtnDirectBot.Checked = true;
                        break;
                    }
            }

            UpdateFolders();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_lastUpdateWas >= Settings.Default.TimeUpdate)
            {
                UpdateFolders();
            }

            _lastUpdateWas++;
            lblLastUpdate.Text = string.Format(Settings.Default.LastUpdateMessange, _lastUpdateWas);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateFolders();
        }

        private static TextBox CreateTxtBoxDir(int i)
        {
            var txtBox = new TextBox
            {
                Text = string.Empty,
                Width = Settings.Default.WidthOneBlock,
                Height = Settings.Default.HeightOneBlock,
                Top = _allBlockTop,
                Left = 10 + (Settings.Default.WidthOneBlock + 10) * i,
                Multiline = true,
                ReadOnly = true,
                BackColor = Settings.Default.BgBlockColor
            };

            return txtBox;
        }

        private static Label CreateLabelDir(string path, int i)
        {
            var labelDir = new Label();

            SubstringTextToLabel(labelDir, path);

            labelDir.Width = Settings.Default.WidthOneBlock;
            labelDir.Top = _allBlockTop - 16;
            labelDir.Left = 10 + (Settings.Default.WidthOneBlock + 10) * i;
            return labelDir;
        }

        private static void SubstringTextToLabel(Control label, string text)
        {
            if (text.Last() == '\\') {
                text = text.Substring(0, text.Length - 1);
            }

            var graphics = label.CreateGraphics();
            var measure = graphics.MeasureString(text, label.Font);
            var isSubstring = measure.Width > Settings.Default.WidthOneBlock;
            var diskName = string.Empty;
            var txtResult = text;

            if (isSubstring)
            {
                diskName = text.Substring(0, 3);
                text = text.Substring(3 + 3); // 3 символа на D:\ и ещё 3 символа на троеточие
            }
            else
            {
                label.Text = txtResult;
                return;
            }

            while (measure.Width + 2 > Settings.Default.WidthOneBlock)
            {
                text = text.Substring(1);
                txtResult = diskName + "..." + text;
                measure = graphics.MeasureString(txtResult, label.Font);
            }

            label.Text = txtResult;
        }

        private void UpdateFolders()
        {
            foreach (var block in _blockList)
            {
                var path = block.Path;

                if (!Directory.Exists(path))
                {
                    block.TextBox.Text = string.Format(Settings.Default.ErrorPath, path);
                    continue;
                }

                var newFileList = Directory.GetFiles(path);
                
                UpdateFiles(block, newFileList);

                //var myFilePaths = new List<MyFilePath>(newFileList.Select(x => new MyFilePath(x)));
                //SortFileList(myFilePaths);

                var i = 0;
                StringBuilder sb = new StringBuilder();
                foreach (var myFile in block.FileList)
                {
                    var fileName = Path.GetFileName(myFile);
                    if (Settings.Default.IsNumberLine)
                    {
                        sb.Append(++i + ") ");
                    }

                    sb.Append(fileName);
                    sb.Append(Environment.NewLine);
                }

                block.TextBox.Text = sb.ToString();
            }

            _lastUpdateWas = -1;
        }

        private void UpdateFiles(DirBlock block, string[] filesInFolder)
        {
            if (block.FileList == null || !block.FileList.Any())
            {
                block.FileList = new List<string>(filesInFolder);
                return;
            }

            //remove deleted file
            block.FileList = block.FileList.Where(filesInFolder.Contains).ToList();

            var newFile = filesInFolder.Where(x => !block.FileList.Contains(x));

            if (rdBtnDirectBot.Checked)
            {
                block.FileList.AddRange(newFile);
            }
            else
            {
                var oldFileList = block.FileList;
                block.FileList = new List<string>(newFile);
                block.FileList.AddRange(oldFileList);
            }
        }

        private void SortFileList(List<MyFilePath> filePaths)
        {
            if (rdBtnSort1.Checked)
            {
                filePaths.Sort(new ComparerByCreateTime());
            }
            else if (rdBtnSort2.Checked)
            {
                filePaths.Sort(new ComparerByLastWriteTime());
            }
            else if (rdBtnSort3.Checked)
            {
                filePaths.Sort(new ComparerByLastAccessTime());
            }

            if (rdBtnDirectBot.Checked)
            {
                filePaths.Reverse();
            }
        }

        private void rdBtnSort1_Click(object sender, EventArgs e)
        {
            UpdateFolders();
        }

        private void rdBtnDirectTop_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var dirBlock in _blockList)
            {
                dirBlock.FileList.Reverse();
            }

            UpdateFolders();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}