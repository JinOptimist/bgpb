using System.Collections.Generic;
using System.IO;

namespace ForBGPB.MyFile
{
    public class ComparerByLastWriteTime : IComparer<MyFilePath>
    {
        public int Compare(MyFilePath x, MyFilePath y)
        {
            var xCreateTime = File.GetLastWriteTime(x.FilePath);
            var yCreateTime = File.GetLastWriteTime(y.FilePath);
            return (int)(xCreateTime.Ticks - yCreateTime.Ticks);
        }
    }
}