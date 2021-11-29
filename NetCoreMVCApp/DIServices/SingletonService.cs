using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.DIServices
{
    public interface ISingletonService: IMicrosoftDIService
    {

    }

    public class SingletonService: ISingletonService
    {
        public string Id { get; set; }

        public SingletonService()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
