using HyBe.Application.Abstractions.Services;
using HyBe.Domain.Entities.Formations;
using HyBe.Domain.Entities.Members;
using HyBe.Persistence.Contexts;
using HyBe.Persistence.Repositories;
using HyBe.SharedKernel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HyBe.Persistence.Services
{
    public class MemberService : IMemberService
    {
        private readonly HypanceDbContext _hypanceDbContext;

        public MemberService(HypanceDbContext hypanceDbContext)
        {
            _hypanceDbContext = hypanceDbContext;
        }

        public IDataResult<List<Member>> GetAll(Expression<Func<Member, bool>> filter)
        {
            try
            {
                var data = filter == null ?
                _hypanceDbContext.Set<Member>().ToList() :
                _hypanceDbContext.Set<Member>().Where(filter).ToList();
                return new SuccessDataResult<List<Member>>(data);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<List<Member>>(ex.Message);
            }
        }

        public IDataResult<Member> Get(Expression<Func<Member, bool>> filter)
        {
            try
            {
                var query = _hypanceDbContext.Set<Member>().FirstOrDefault(filter);
                if (query == null)
                    throw new NullReferenceException("Data is not found!..");
                return new SuccessDataResult<Member>(query);
            }
            catch (System.Exception ex)
            {
                return new ErrorDataResult<Member>(ex.Message);
            }
        }

        public IResult Add(Member entity)
        {
            try
            {
                _hypanceDbContext.Add<Member>(entity);
                _hypanceDbContext.SaveChanges();
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }

        }

        public IResult Update(Member entity)
        {
            try
            {
                _hypanceDbContext.Update<Member>(entity);
                _hypanceDbContext.SaveChanges();
                return new SuccessResult();
            }
            catch (System.Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(Guid entityId)
        {
            try
            {
                var entity = Get(s => s.Id == entityId.ToString());
                if (!entity.Success)
                    throw new NullReferenceException(entity.Message);

                _hypanceDbContext.Remove<Member>(entity.Data);
                _hypanceDbContext.SaveChanges();
                return new SuccessResult();
            }
            catch (System.Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }
    }
}
