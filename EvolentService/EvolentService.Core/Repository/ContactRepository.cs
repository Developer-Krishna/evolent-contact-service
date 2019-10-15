using EvolentService.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvolentService.Core.Repository
{
    public class ContactRepository: RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {
        }
    }
}
