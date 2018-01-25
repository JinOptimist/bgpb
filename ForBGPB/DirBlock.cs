using System.Collections.Generic;
using System.Windows.Forms;

namespace ForBGPB
{
    public class DirBlock
    {
        public DirBlock()
        {
            
        }

        public DirBlock(Label label, TextBox textBox, string path, List<string> fileList)
        {
            Label = label;
            TextBox = textBox;
            Path = path;
            FileList = fileList;
        }

        public Label Label { get; set; }

        public TextBox TextBox { get; set; }

        public string Path { get; set; }

        public List<string> FileList { get; set; }
    }
}