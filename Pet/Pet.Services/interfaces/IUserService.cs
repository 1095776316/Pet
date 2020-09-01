using Pet.Core;
using Pet.Core.Data;
using Pet.Core.Domain.Identity;
using Pet.Core.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Services.interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<AppUser>> GetList();

        Task<List<AppUser>> GetListAsync(int[] ids);

        List<AppUser> GetListAsNoTracking();

        IPageList<UserPageModel> GetPageList(string search, int pageIndex, int pageSize, int total);

        Task<AppUser> FindAsync(int id);

        Task InsertAsync(AppUser entity);

        Task UpdateAsync(AppUser user);

        Task DeleteAsync(int id);

        Task DeleteAsync(AppUser user);

        Task DeleteAsync(List<AppUser> users);

        Task<bool> AnyAsync(string name);
    }
}
