using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace ticketbookingapp.Models
{
	public class Actor_MovieModel
	{
		public int MovieId { get; set; }

		[ForeignKey("MovieId")]
		public MovieModel Movie { get; set; }

		public int ActorId { get; set; }

		public ActorModel Actor { get; set; }




	}
}

