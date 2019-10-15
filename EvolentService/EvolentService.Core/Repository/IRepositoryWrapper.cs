using System;
using System.Collections.Generic;
using System.Text;

namespace EvolentService.Core.Repository
{
    public interface IRepositoryWrapper
    {
        IContactRepository Contact { get; }
        void Save();
    }
}
