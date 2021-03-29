using DMS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Infrastructure.Repositories
{
    public class PdfRepository : GenericRepository<Pdf>
    {
        public PdfRepository(DmsDbContext context) : base(context)
        {
        }

        public override Pdf Get(Guid id)
        {
            var pdf = context.Pdfs.Single(pdf => pdf.PdfId == id);
            return base.Get(id);
        }

        public override IEnumerable<Pdf> All()
        {
            return base.All();
        }

        public override Pdf Update(Pdf entity)
        {
            return base.Update(entity);
        }
    }
}
