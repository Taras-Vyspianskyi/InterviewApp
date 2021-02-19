using InterviewApp.Common.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Common.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task SaveAsync();

        IUserRepository UserRepository { get; }

        IGroupRepository GroupRepository { get; }
    }
}
