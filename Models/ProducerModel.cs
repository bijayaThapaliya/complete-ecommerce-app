using System;
using System.ComponentModel.DataAnnotations;

namespace ticketbookingapp.Models
{
	public class ProducerModel
	{
        [Key]
		public int ProId { get; set; }

        public string ProfilePictureURl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relatioship with movies

        public List<MovieModel> Movies { get; set; }
    }
}

