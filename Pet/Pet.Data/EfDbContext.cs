using Microsoft.EntityFrameworkCore;
using Pet.Core;
using Pet.Core.Domain.Identity;
using Pet.Core.Domain.System;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pet.Data
{
    public class EfDbContext : DbContext, IDbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }

        public virtual DbSet<AppRole> AppRoles { get; set; }

        public virtual DbSet<AppPermission> AppPermissions { get; set; }

        public virtual DbSet<AppUserRole> AppUserRoles { get; set; }

        public virtual DbSet<AppRolePermission> AppRolePermissions { get; set; }

        public virtual DbSet<AppRoleMenu> AppRoleMenus { get; set; }

        public virtual DbSet<SysMenu> SysMenus { get; set; }

        public virtual DbSet<SysMenuPermission> SysMenuPermissions { get; set; }

        public virtual new DbSet<T> Set<T>() where T : BaseEntity
        {
            return base.Set<T>();
        }
    }
}
