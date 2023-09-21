using System;
namespace ticketbookingapp.Models
{
	public class Actor_MovieModel
	{
		public int MoviesId { get; set; }

		public MovieModel MovieModel { get; set; }

		public int ActorId { get; set; }

		public ActorModel Actor { get; set; }




	}
}

