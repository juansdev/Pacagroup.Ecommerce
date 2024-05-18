﻿namespace Pacagroup.Ecommerce.Infrastructure.Interface
{
    public interface IUnitOfWork: IDisposable
    {
        ICustomersRepository Customers { get; }
        IUsersRepository Users { get; }
        ICategoriesRepository Categories { get; }
    }
}
