using AutoMapper;
using Pet.Core;
using Pet.Core.Data;
using Pet.Core.Domain.Identity;
using Pet.Core.Models.Users;
using Pet.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;
        public UserService(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await FindAsync(id);
            await DeleteAsync(user);
        }

        public async Task DeleteAsync(AppUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user");
            }
            await _repository.DeleteAsync(user);
        }

        public async Task<AppUser> FindAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<AppUser>> GetList()
        {
            return await _repository.GetList();
        }

        public async Task<List<AppUser>> GetListAsync(int[] ids)
        {
            var users = await _repository.GetListAsync(p => ids.Contains(p.Id));
            return users;
        }

        public List<AppUser> GetListAsNoTracking()
        {
            return _repository.TableNoTracking.ToList();
        }

        public IPageList<UserPageModel> GetPageList(string search, int pageIndex, int pageSize, int total)
        {
            var query = _repository.TableNoTracking.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Name.Contains(search));
            }
            var source = new PagedList<AppUser>(query, pageIndex, pageSize, total);
            var dtos = _mapper.Map<List<AppUser>, List<UserPageModel>>(source.List);
            var pages = new PagedList<UserPageModel>(dtos, source.PageIndex, source.PageSize, source.TotalCount);
            return pages;
        }

        public async Task InsertAsync(AppUser entity)
        {
            await _repository.InsertAsync(entity);
        }

        public async Task UpdateAsync(AppUser user)
        {
            await _repository.UpdateAsync(user);
        }

        public async Task DeleteAsync(List<AppUser> users)
        {
            await _repository.DeleteAsync(users);
        }

        public async Task<bool> AnyAsync(string name)
        {
            return await _repository.AnyAsync(p => p.Name == name);
        }
    }
}
