using Microsoft.EntityFrameworkCore;
using Sheenam.API.Models.Foundations.Guest;

namespace Sheenam.API.Brokers.Storage;

public partial class StorageBroker
{
    public DbSet<Guest> Guests { get; set; }
}