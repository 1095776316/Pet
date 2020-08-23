using Microsoft.EntityFrameworkCore;
using Pet.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Data
{
    public interface IDbContext
    {
        DbSet<T> Set<T>() where T : BaseEntity;

        int SaveChanges();
    }
}
