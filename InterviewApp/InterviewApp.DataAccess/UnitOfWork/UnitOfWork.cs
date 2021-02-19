using InterviewApp.Common.Repository;
using InterviewApp.Common.UnitOfWork;
using InterviewApp.DataAccess.Context;
using InterviewApp.DataAccess.Repository;
using System;
using System.Threading.Tasks;

namespace InterviewApp.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext context;

        public UnitOfWork(ApplicationContext context)
        {
            this.context = context;
            this.UserRepository = new UserRepository(context);
            this.GroupRepository = new GroupRepository(context);
        }

        public IUserRepository UserRepository { get; }

        public IGroupRepository GroupRepository { get; }

        public void Dispose()
        {
            this.context?.Dispose();
        }

        public async Task SaveAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
