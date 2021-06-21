using Microsoft.EntityFrameworkCore;
using ShadiHelperWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceForCC.Models
{
    public class VendorDataContext:DbContext
    {
        public VendorDataContext(DbContextOptions<VendorDataContext> options)
            : base(options)
        { }

        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<CategoryTypes> CategoryTypes { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<Countries> Countries { get; set; }

        public DbSet<Cities> Cities { get; set; }

        public DbSet<ZipCodes> ZipCodes { get; set; }

        public DbSet<StatesOrProvinces> StatesOrProvinces { get; set; }

        public DbSet<Colonies> Colonies { get; set; }

        public DbSet<Streets> Streets { get; set; }

        public DbSet<Blocks> Blocks { get; set; }
    }
}
