using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS4_BO3_GSC
{
    class SourceTokenDef
    {
        public string FilePath;
        public int LineStart;
        public int LineEnd;
        public int CharStart;
        public int CharEnd;
        public Dictionary<int, (int CStart, int CEnd)> LineMappings = new Dictionary<int, (int CStart, int CEnd)>();
    }
}
