using System;
using System.ComponentModel.DataAnnotations;

namespace ticketbookingapp.Models
{
	public class CinemaModel
	{
		[Key]
		public int CineId { get; set; }

		public string Logo { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }
	}

}

