using IvanTsvetkov11zh.Controller;
using IvanTsvetkov11zh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanTsvetkov11zh.View
{
	internal class Display
	{
		FlightController flightController = new FlightController();
		public Display() {
			Menu();
		}

		private void Menu()
		{
			Console.WriteLine(new string('*', 16) + "FLIGHTS" + new string('*', 16));
			Console.WriteLine("[1] Add flight");
			Console.WriteLine("[2] Update flight");
			Console.WriteLine("[3] Remove flight");
			Console.WriteLine("[4] Get flight");
			Console.WriteLine("[5] Get all flights");
			Console.WriteLine("[6] Exit");
			Console.WriteLine(new string('*', 39));
			Console.Write("Choose an option: ");
			int option = int.Parse(Console.ReadLine());
			switch (option)
			{
				case 1:
					Add();
					break;
				case 2:
					Update();
					break;
				case 3:
					Remove();
					break;
				case 4:
					Get();
					break;
				case 5:
					GetAll();
					break;
				case 6:
					break;
			}
			Menu();
		}

		private void Add()
		{
			Flight flight = new Flight();
			Console.Write("Enter flight destination: ");
			flight.DestinationName = Console.ReadLine();
			Console.Write("Enter flight duration: ");
			flight.Duration = ushort.Parse(Console.ReadLine());
			flightController.Add(flight);
		}

		private void Update()
		{
			Console.Write("Enter flight ID: ");
			int ID = int.Parse(Console.ReadLine());
			Flight flight = flightController.Get(ID);
			if (flight != null) {
				Console.Write("Enter flight destination: ");
				flight.DestinationName = Console.ReadLine();
				Console.Write("Enter flight duration: ");
				flight.Duration = ushort.Parse(Console.ReadLine());
				flightController.Update(flight);
			}
		}

		private void Remove()
		{
			Console.Write("Enter flight ID: ");
			int ID = int.Parse(Console.ReadLine());
			flightController.Remove(ID);
		}

		private void Get()
		{
			Console.Write("Enter flight ID: ");
			int ID = int.Parse(Console.ReadLine());
			Flight flight = flightController.Get(ID);
			Console.WriteLine(flight.ID);
			Console.WriteLine(flight.DestinationName);
			Console.WriteLine(flight.Duration);
		}

		private void GetAll()
		{
			List<Flight> flights = new List<Flight>();
			foreach(Flight flight in flightController.GetAll())
			{
				Console.WriteLine(flight.ID);
				Console.WriteLine(flight.DestinationName);
				Console.WriteLine(flight.Duration);
				Console.WriteLine();
			}
		}
	}
}
