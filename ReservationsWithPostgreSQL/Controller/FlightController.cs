using IvanTsvetkov11zh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanTsvetkov11zh.Controller
{
	internal class FlightController
	{
		Context context;
		public void Add(Flight flight)
		{
			using (context = new Context())
			{
				context.Flights.Add(flight);
				context.SaveChanges();
			}
		}
		public void Remove(int ID)
		{
			using (context = new Context())
			{
				Flight flight = context.Flights.Find(ID);
				if (flight != null)
				{
					context.Flights.Remove(flight);
				}
				context.SaveChanges();
			}
		}

		public void Update(Flight flight)
		{
			using (context = new Context()) {
				Flight item = context.Flights.Find(flight.ID);
				if (item != null)
				{
					context.Flights.Entry(item).CurrentValues.SetValues(flight);
					context.SaveChanges();
				}
			}
		}

		public Flight Get(int ID)
		{
			using (context = new Context())
			{
				return context.Flights.Find(ID);
			}
		}

		public List<Flight> GetAll()
		{
			using (context = new Context())
			{
				return context.Flights.ToList();
			}
		}

	}
}
