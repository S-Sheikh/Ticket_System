using System;
using System.ComponentModel.DataAnnotations;

public class Ticket
{
	[Key]
	public int TicketID { get; set; }

	[Required]
	public string Title { get; set; }

	[Required]
	public DateTime Date { get; set; }

	[Required]
	public string Description { get; set; }

	[Required]
	public string Effort { get; set; }
	public string Product { get; set; }
	public string ClientDescription { get; set; }
	[Required]
	public int State { get; set; }
}
