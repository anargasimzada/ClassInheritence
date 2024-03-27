
using ClassInheritence.Models;

namespace ClassInheritence.Models
{
    internal class Program
    {
         public static void Main(string[] args)
         {
            Student student = new Student("Anar","Gasimzada","AB106",90) ;

            student.GetInfo();
            student.GetDiplomDegree();
            student.CheckGraduation();


         }
    }
}
