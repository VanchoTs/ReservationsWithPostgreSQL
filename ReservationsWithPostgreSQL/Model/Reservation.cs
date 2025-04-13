using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanTsvetkov11zh.Model
{
	internal class Reservation
	{
		[Key]
		public int ID { get; set; }
		[Range(1, 400, ErrorMessage = "Number of tickets must be between 1 and 400!")]
		public int NumberOfTickets { get; set; }
		[Range(1, double.MaxValue, ErrorMessage = "Price must be a positive number!")]
		public double Price { get; set; }
		[Required]
		public Flight Flight { get; set; }
	}
}
