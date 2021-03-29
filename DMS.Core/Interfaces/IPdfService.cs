using DMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Core.Interfaces
{
    public interface IPdfService
    {
        IEnumerable<Pdf> GetAll();
        void Delete(Pdf pdf);
        Pdf Upload(Pdf pdf);
        IEnumerable<Pdf> Reorder();
    }
}
