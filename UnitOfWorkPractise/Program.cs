using System;
using UnitOfWorkPractise.Models;
using UnitOfWorkPractise.Repositories.Concretes;

class Program
{
	static void Main()
	{
		var unitOfWork = new UnitOfWork();

		Student student1 = new Student()
		{
			FirstName = "Mirtalib",
			LastName = "Huseynzade",
			Id_Group = 259
		};

		unitOfWork.StudentRepository.Add(student1);
		//Console.WriteLine(student1.FirstName);
		unitOfWork.StudentRepository.Remove(student1);
		//Console.WriteLine(student1.LastName);

		unitOfWork.Save();

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("\nDone!");
	}
}