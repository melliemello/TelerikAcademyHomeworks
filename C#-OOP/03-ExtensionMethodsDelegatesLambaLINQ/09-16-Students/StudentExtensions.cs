using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16_Students
{
    public static class StudentExtensions
    {
        public static Dictionary<int, List<Student>> OrderByGroupNumber(this List<Student> students) 
        {
            Dictionary<int, List<Student>> result = new Dictionary<int, List<Student>>();
            var groupedByGroup = from student in students
                                 group student by student.GroupNumber into grouped
                                 select new { groupID = grouped.Key, st = grouped.ToList() };
            foreach (var group in groupedByGroup)
            {
                result[group.groupID] =  new List<Student>();
                foreach(var student in group.st )
                {
                    result[group.groupID].Add(student);
                }
                
            }
            return result;
        }
    }
}
