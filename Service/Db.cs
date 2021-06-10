using System;
using Microsoft.EntityFrameworkCore;
namespace source7.Service
{
    public class Db: DbContext
    {
        public DbSet<source7.Models.Todo> Todo { get; set; }        
    }
}