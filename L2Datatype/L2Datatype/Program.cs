using System;

namespace L2Datatype
{
	/// <summary>
	/// Main class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			Student student = new Student ();
			student._age = 28;

			Calculate (student);

			Console.WriteLine (student._age);
			Console.ReadLine ();
		}

		/// <summary>
		/// Calculate the specified student.
		/// </summary>
		/// <param name="student">Student.</param>
		static void Calculate(Student student)
		{
			student._age += 1;
		}
	}
}