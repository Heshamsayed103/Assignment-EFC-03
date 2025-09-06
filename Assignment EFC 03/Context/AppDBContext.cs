using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFC_03.Context
{
    internal class AppDBContext
    {
        #region TPC
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion

        #region TPH
        //public DbSet<Employee> Employees { get; set; }
        #endregion

        #region TPCC
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        #endregion

        #region TPH
        //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
        //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
        #endregion

        #region TPC
        //modelBuilder.Entity<Employee>().ToTable("Employees");
        //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
        //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");
        #endregion
    }
}

