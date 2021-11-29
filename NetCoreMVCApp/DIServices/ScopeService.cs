using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.DIServices
{
    public interface IScopeService: IMicrosoftDIService
    {

    }
    public class ScopeService : IScopeService
    {
        public string Id { get; set; }

        public ScopeService()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
