using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifetimeUsingDependencyInjectionDemo.Models
{
    public class OperationServices : ISingletonService
        //ISingletonService,ITransientService,IScopedService
    {
        Guid id;
        
        int no;
        public OperationServices()
        {
            
            id = Guid.NewGuid();
            Random r = new Random();
            no =r.Next(1200);
        }

        public int GenerateRandomNumber()
        {
            return no;
        }

        public Guid GetOperationID()
        {
            //throw new NotImplementedException();
            return id;
        }
    }
}
