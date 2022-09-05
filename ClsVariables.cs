using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class ClsVariables
    {   
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Directory.GetCurrentDirectory() + "\\Company.mdf;Integrated Security=True";
        //public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\emreo\source\repos\Midterm\Company.mdf;Integrated Security=True";
    }
}
