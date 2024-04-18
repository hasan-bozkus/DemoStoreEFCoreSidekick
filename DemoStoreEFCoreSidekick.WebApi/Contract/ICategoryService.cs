using DemoStoreEFCoreSidekick.WebApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoStoreEFCoreSidekick.WebApi
{
    public interface ICategoryService : IEntityServiceBase<Category, int>
    {
    }
}
