using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Diagnostics;

namespace VAT
{
    [DebuggerDisplay("{Name}")]
    public class VATFile
    {
        public string Fullpath { get; private set; }
        public string Name {get;private set;}
        public string Extension { get; private set; }
        public TimeSpan Duration { get; private set; }

        /// <summary>
        /// Creates a VatFile. 
        /// Checks if file exists.Throws ArgumentException if not.
        /// </summary>
        /// <param name="path"></param>
        public VATFile(string path)
        {

            if (File.Exists(@path))
            {
                this.Fullpath = @path;
                this.Extension = Path.GetExtension(this.Fullpath);
                this.Name = Path.GetFileName(this.Fullpath);
                this.Duration = TimeSpan.FromSeconds(new WindowsMediaPlayer().newMedia(this.Fullpath).duration);
            }
            else
            {
                throw new ArgumentException("File does not exist");
            }
        }
    }
}
