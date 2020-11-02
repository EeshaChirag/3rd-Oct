using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class CourseDetails
    {
        int CId, CFees;
        string CName;
        internal static string institutename;
        static int collegeid = 1003;

        internal CourseDetails(int CId, string CName, int CFees)
        {
            this.CId = CId;
            this.CName = CName;
            this.CFees = CFees;
        }
        internal void Display()
        {
            Console.WriteLine("CId:{0} || CName:{1} || CFees:{2} || Institute Name:{3} || InstituteId:{4}", CId, CName, CFees, institutename,collegeid);
        }
        internal static int CollegeID()
        {
            return collegeid;
        }
    }

    class Day3Practice
    {
        static void Main()
        {
            Console.Write("Enter the institute Name:");
            CourseDetails.institutename = Console.ReadLine();
            int size, CId, CFees;
            string CName;
            Console.Write("Enter the size of array:");
            size = Convert.ToInt32(Console.ReadLine());
            CourseDetails[] course = new CourseDetails[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the Course Id:");
                CId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Course Name:");
                CName = Console.ReadLine();

                Console.Write("Enter the Course Fees:");
                CFees = Convert.ToInt32(Console.ReadLine());

                course[i] = new CourseDetails(CId, CName, CFees);
            }

            for (int i = 0; i < size; i++)
            {
                course[i].Display();
            }
            Console.ReadLine();
        }
    }
}
