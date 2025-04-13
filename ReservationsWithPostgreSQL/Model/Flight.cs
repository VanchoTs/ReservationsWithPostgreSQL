using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanTsvetkov11zh.Model
{
	internal class Flight
	{
		[Key]
		public int ID { get; set; }
		[MaxLength(100)]
		public string DestinationName { get; set; }
		[Range(1, 1500, ErrorMessage = "Duration must be between 1 and 1500 minutes!")]
		public ushort Duration { get; set; }
		public List<Reservation> Reservations { get; set; }
	}
}
