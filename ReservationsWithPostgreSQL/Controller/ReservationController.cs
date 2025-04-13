using IvanTsvetkov11zh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanTsvetkov11zh.Controller
{
	internal class ReservationController
	{
		Context context;
		public void Add(Reservation reservation)
		{
			using (context = new Context())
			{
				context.Reservations.Add(reservation);
				context.SaveChanges();
			}
		}
		public void Remove(int ID)
		{
			using (context = new Context())
			{
				Reservation reservation = context.Reservations.Find(ID);
				if (reservation != null)
				{
					context.Reservations.Remove(reservation);
				}
				context.SaveChanges();
			}
		}

		public void Update(Reservation reservation)
		{
			using (context = new Context())
			{
				if (context.Reservations.Find(reservation.ID) != null)
				{
					context.Reservations.Update(reservation);
				}
			}
		}

		public Reservation Get(int ID)
		{
			using (context = new Context())
			{
				return context.Reservations.Find(ID);
			}
		}

		public List<Reservation> GetAll()
		{
			using (context = new Context())
			{
				return context.Reservations.ToList();
			}
		}
	}
}
