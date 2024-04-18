using DemoStoreEFCoreSidekick.WebApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoStoreEFCoreSidekick.WebApi
{
    public interface IEmployeeService : IEntityServiceBase<Employee, int>
    {
    }
}
