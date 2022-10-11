using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifetimeUsingDependencyInjectionDemo.Models
{
    public class OperationServices : ISingletonService,ITransientService,IScopedService
    {
        Guid id;

        public OperationServices()
        {
            id = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            //throw new NotImplementedException();
            return id;
        }
    }
}
