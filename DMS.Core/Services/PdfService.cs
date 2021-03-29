using DMS.Core.Interfaces;
using DMS.Domain.Models;
using DMS.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Core.Services
{
    public class PdfService : IPdfService
    {
        private readonly IRepository<Pdf> repository;

        public PdfService(IRepository<Pdf> repository)
        {
            this.repository = repository;
        }

        public void Delete(Pdf pdf)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pdf> GetAll()
        {
            try
            {
                var result = repository.All();
                return result;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Pdf> Reorder()
        {
            throw new NotImplementedException();
        }

        public Pdf Upload(Pdf pdf)
        {
            if (pdf != null)
            {
                try
                {
                    var result = repository.Add(pdf);
                    return result;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
