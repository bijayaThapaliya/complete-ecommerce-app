using System;
using ticketbookingapp.Data;

namespace ticketbookingapp.Models
{
	public class MovieModel
	{
		public int MovieId { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public string ImageURL { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public MovieCatagory MovieCatagory { get; set; }
	}
}

