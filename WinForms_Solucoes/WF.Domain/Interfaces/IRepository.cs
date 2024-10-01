using System;
using System.Collections.Generic;
using System.Text;

namespace WF.Domain.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(object id);
    }
}
