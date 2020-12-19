using System;
using System.ComponentModel.DataAnnotations;

namespace BloggingEngine
{
	public class User
	{
		[Key]
		public string UserId { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		public string EmailAddress { get; set; }
		public string StateOfOrigin { get; set; }
		public string Gender { get; set; }
		public string ResidentialAddress { get; set; }
		public string University { get; set; }
		public string StateOfResidence { get; set; }
		public string DateOfBirth { get; set; }
		[Required]
		public DateTime DateCreated { get; set; }
	}
}
