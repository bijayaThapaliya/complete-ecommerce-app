using System;
using ticketbookingapp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ticketbookingapp.Models
{
	public class MovieModel
	{
		[Key]
		public int MovieId { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public double Price { get; set; }

		public string ImageURL { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public MovieCatagory MovieCatagory { get; set; }


		//rel

		public List<Actor_MovieModel> Actor_Movie { get; set; }


		public int CinemaId { get; set; }

		[ForeignKey("CinemaId")]
		public CinemaModel Cinema { get; set; }

        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public ProducerModel Producer { get; set; }


    }
}

