﻿//using ServiceStack.DataAnnotations;
//using System.ComponentModel.DataAnnotations;
using SQLite;

namespace ContactBook
{
	public class Contact
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(255)]
		public string FirstName { get; set; }

		[MaxLength(255)]
		public string LastName { get; set; }

		[MaxLength(255)]
		public string Phone { get; set; }

		[MaxLength(255)]
		public string Email { get; set; }

		public bool IsBlocked { get; set; }
	}
}
