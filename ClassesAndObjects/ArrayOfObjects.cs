using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class ArrayOfObject
    {
		class Movie
		{
			int id;
			string moviename;

			internal Movie(int id, string moviename)
			{
				this.id = id;
				this.moviename = moviename;
				//this.year = year;
			}
			internal void DisplayMovie()
			{
				Console.WriteLine("Id: {0} || MovieName: {1}", id, moviename);
			}
		}

		static void Main()
		{
			/*Movie movie = new Movie(101, "Dangal");
			movie.DisplayMovie();*/
			//applying array to objects to fetch movie info
			//array of object
			//datatype[] arrayname = new datatype[size];
			//Static
			/*Movie[] mov = new Movie[2];
			mov[0]=new Movie(102, "Avengers");
			mov[1]=new Movie(103, "ZNMD");*/
			int id;
			string moviename;
			Console.Write("Enter the size:");
   			int size = Convert.ToInt32(Console.ReadLine());
			Movie[] mov = new Movie[size];

			for(int i = 0; i<size;i++)
            {
                Console.Write("Enter the Id:");
				id= Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter the moviename:");
				moviename = Console.ReadLine();
				mov[i] = new Movie(id, moviename);

			}
			
			for (int i = 0; i < size; i++)
			{
				mov[i].DisplayMovie();
			}
			Console.Read();
		}
	}
}
