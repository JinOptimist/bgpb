using System.Collections.Generic;
using System.IO;

namespace ForBGPB.MyFile
{
    public class ComparerByLastAccessTime : IComparer<MyFilePath>
    {
        public int Compare(MyFilePath x, MyFilePath y)
        {
            var xCreateTime = File.GetLastAccessTime(x.FilePath);
            var yCreateTime = File.GetLastAccessTime(y.FilePath);
            return (int)(xCreateTime.Ticks - yCreateTime.Ticks);
        }
    }
}