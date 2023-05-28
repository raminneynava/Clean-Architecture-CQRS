using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.DTO.External;
using Application.Services;
using Domain.ValueObjects;

namespace Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Destination destination)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
