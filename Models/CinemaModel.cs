using System;
using System.ComponentModel.DataAnnotations;

namespace ticketbookingapp.Models
{
	public class CinemaModel
	{
		[Key]
		public int CineId { get; set; }

		[Display(Name="Cinema Logo")]
		public string Logo { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }


		public List<MovieModel> Movies { get; set; }
	}

}

