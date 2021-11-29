using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.DIServices
{
    public class BTransientService: ITransientService
    {
        //
        public string Id { get; set; }

        public BTransientService()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
