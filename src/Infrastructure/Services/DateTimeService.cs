using FoodApp.Application.Common.Interfaces;
using System;

namespace FoodApp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
