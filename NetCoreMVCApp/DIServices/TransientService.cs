using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.DIServices
{
    public interface ITransientService: IMicrosoftDIService
    {

    }
    public class TransientService : ITransientService
    {
        public string Id { get; set; }

        public TransientService()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
