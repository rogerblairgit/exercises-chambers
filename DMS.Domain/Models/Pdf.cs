using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Domain.Models
{
    public class Pdf
    {
        public Guid PdfId { get; private set; }
        public string Filename { get; set; }
        public int Size { get; set; }
        public string Location { get; set; }
    }
}
