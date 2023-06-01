using HyBe.Domain.Entities.Members;
using HyBe.SharedKernel.Repositories;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Application.Abstractions.Services
{
    public interface IMemberService
    {
        IDataResult<Member> Get(Expression<Func<Member, bool>> filter);
        IDataResult<List<Member>> GetAll(Expression<Func<Member, bool>> filter = null);
        IResult Add(Member entity);
        IResult Update(Member entity);
        IResult Delete(Guid entityId);
    }
}
