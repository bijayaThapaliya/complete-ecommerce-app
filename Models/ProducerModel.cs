using System;
using System.ComponentModel.DataAnnotations;

namespace ticketbookingapp.Models
{
	public class ProducerModel
	{
        [Key]
		public int ProId { get; set; }

        [Display(Name ="Profile Picture")]
        public string ProfilePictureURl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relatioship with movies

        public List<MovieModel> Movies { get; set; }
    }
}

