using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT
{
    public class VATFile
    {
        private readonly string fullpath;
        public string Fullpath 
        { 
            get { return this.fullpath; } 
            set; 
        }
        private readonly string name;
        public string Name
        {
            get { return this.name; }
            set;
        }
        private readonly string extension;
        public string Extension 
        {
            get { return this.extension; }
            set;
        }

        /// <summary>
        /// Creates a VatFile. 
        /// Checks if file exists.Throws ArgumentException if not.
        /// </summary>
        /// <param name="path"></param>
        public VATFile(string path)
        {

            if (File.Exists(@path))
            {
                this.fullpath = @path;
                this.extension = Path.GetExtension(this.Fullpath);
                this.name = Path.GetFileName(this.Fullpath);
            }
            else
            {
                throw new ArgumentException("File does not exist");
            }
        }
    }
}
