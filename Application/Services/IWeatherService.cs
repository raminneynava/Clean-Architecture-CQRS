using Application.DTO.External;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Destination localization);
    }
}
