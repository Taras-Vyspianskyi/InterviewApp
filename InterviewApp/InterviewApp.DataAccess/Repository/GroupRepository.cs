using InterviewApp.Common.Entity;
using InterviewApp.Common.Repository;
using InterviewApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.DataAccess.Repository
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(ApplicationContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Group>> GetAllAsync() => await dbContext.Set<Group>().Include(x => x.Users).ToListAsync();

        public override async Task<IEnumerable<Group>> FilterByAsync(Expression<Func<Group, bool>> predicate) => await dbContext.Set<Group>().Include(x => x.Users).Where(predicate).ToListAsync();
    }
}
