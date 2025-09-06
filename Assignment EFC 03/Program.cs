namespace Assignment_EFC_03
{
    internal class Program
    {
        static void Main()
        {
            #region Run SQL Query

            #region Select Statement
            // 1. Select Statement:
            //var Result = context.Categories.FromSqlRaw
            //    ("Select * From Categories");
            //var Result = context.Products.FromSqlRaw
            //    ("Select * From Products Where UnitsInStock = 0");
            //var Result = context.Products.FromSqlInterpolated
            //  ($"Select * From Products Where UnitsInStock = 0");
            //foreach (var product in Result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region DML Operation
            // 2. DML Operation [Insert , Update , Delete]:
            //context.Database.ExecuteSqlRaw
            //    ("Update Products Set UnitsInStock = 40 Where ProductID = 1");
            #endregion

            #endregion


            #region Tracking Vs No Tracking// Tracking
            #region Tracking
            //var first = context.Employees.FirstOrDefault(E => E.Id == 10);
            //first.Name = "AYa";~
            //context.SaveChanges(); 
            #endregion

            #region No Tracking
            // No Tracking:
            //var first01 = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);
            //Console.WriteLine(context.Entry(first01).State); // Detached
            //context.SaveChanges(); 
            #endregion

            #endregion
            #region Remote Vs Local

            #region Remote
            //context.Employees.Any();
            //context.Employees.Any();
            #endregion

            #region Local
            //context.Employees.Load(); // Cashe Data
            //context.Employees.Local.Any(); // Work Local
            #endregion
            #endregion

            #region Join Operators
            //var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            //{
            //    EmpId = E.Id,
            //    DeptId = D.Id,
            //    EmpName = E.Name,
            //    DeptName = D.Name
            //}).Where(D => D.DeptName == "HR");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            #endregion

        }
    }
}
