using System;
using System.ComponentModel.DataAnnotations;

namespace ticketbookingapp.Models
{
	public class ActorModel

	{
		[Key]
		public int ActorId { get; set; }
		[Display(Name = "Profile Picture URL")]
		public string ProfilePictureURl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

		public List<Actor_MovieModel> Actor_Movies { get; set; }
	}
}

