using System;
using System.ComponentModel.DataAnnotations;

namespace ticketbookingapp.Models
{
	public class ActorModel

	{
		[Key]
		public int ActorId { get; set; }

		public string ProfilePictureURl { get; set; }

		public string FullName { get; set; }

		public string Bio { get; set; }
	}
}

