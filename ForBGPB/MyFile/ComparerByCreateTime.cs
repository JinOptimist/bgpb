using System.Collections.Generic;
using System.IO;

namespace ForBGPB.MyFile
{
    public class ComparerByCreateTime : IComparer<MyFilePath>
    {
        public int Compare(MyFilePath x, MyFilePath y)
        {
            var xCreateTime = File.GetCreationTime(x.FilePath);
            var yCreateTime = File.GetCreationTime(y.FilePath);
            return (int)(xCreateTime.Ticks - yCreateTime.Ticks);
        }
    }
}