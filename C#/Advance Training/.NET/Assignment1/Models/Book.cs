using System.ComponentModel.DataAnnotations;
namespace RazorPagesBook.Models;

public class Book
{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string? Description { get; set; }

		public string? Author { get; set; }

}
