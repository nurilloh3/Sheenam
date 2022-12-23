using System;

namespace Sheenam.API.Models.Foundations.Guest;

public class Guest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTimeOffset DateOfBrith { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Adress { get; set; }
    public GenderType Gender { get; set; }
}