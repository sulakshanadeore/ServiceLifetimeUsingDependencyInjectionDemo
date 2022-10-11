using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifetimeUsingDependencyInjectionDemo.Models
{
 public   interface ITransientService
    {
        Guid GetOperationID();
        
    }

  public  interface IScopedService
    {
        Guid GetOperationID();
    }
    public interface ISingletonService 
    {
        Guid GetOperationID();
        int GenerateRandomNumber();

    }
}
