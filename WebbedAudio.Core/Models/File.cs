using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbedAudio.Core.Models
{
    public class AudioFile
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateOnly FileDate { get; set; }
        public string FileSize { get; set; }
    }
}
