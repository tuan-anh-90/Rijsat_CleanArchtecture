using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain1.Master;

namespace Application.Common.Interfaces
{
        public interface IApplicationDBContext
        {
            DbSet<Appsetting> AppSettings { get; set; }
            Task<int> SaveChangesAsync();
        }
}
