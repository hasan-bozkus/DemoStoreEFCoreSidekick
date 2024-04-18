using DemoStoreEFCoreSidekick.WebApi;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace DemoStoreEFCoreSidekick.WebApi
{
    public class EmployeeService : EntityServiceBase<Employee, int>, IEmployeeService
    {
        private readonly ICurrentUser _currentUser;

        public EmployeeService(IUnitOfWork unitOfWork, ICurrentUser currentUser) : base(unitOfWork)
        {
            _currentUser = currentUser;
        }
    }
}
