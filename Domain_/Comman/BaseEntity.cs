using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_.Comman
{
    public abstract class BaseEntity<T>
    {
        public virtual T id { get; set; }
    }
}