using System;
using DAL;

namespace TestDapperConsole {
	class Program {
		static void Main(string[] args) {

			IRepository repo = new DapperRepository();
			var entity = repo.GetEntity(1);
			Console.ReadLine();
		}
	}
}
