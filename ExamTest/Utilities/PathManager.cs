using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTest.Utilities
{
    public static class PathManager
    {
        const string basepath = "./././wwwroot";
       public const string fullNumPath = basepath + "/Number.json";
        public const string fullTextPath = basepath + "/Text.json";
        public const string fullBinaryPath = basepath + "/Binary.json";
    }
}
