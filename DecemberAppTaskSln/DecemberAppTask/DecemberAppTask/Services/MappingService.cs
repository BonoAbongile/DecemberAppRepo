using DecemberAppTask.Models;
using DecemberAppTask.Services.Interfaces;
using Xamarin.Forms.Maps;

namespace DecemberAppTask.Services
{
    public class MappingService : IMapping
    {
        int _pinCreatedCount = 0;


        public Location GetNewLocation()
        {
            _pinCreatedCount++;
            return new Location(
                $"Pin {_pinCreatedCount}",
                $"Desc {_pinCreatedCount}",
                RandomPosition.Next(new Position(-33.933329, 18.6333308), 4, 10));
        }
    }
}
