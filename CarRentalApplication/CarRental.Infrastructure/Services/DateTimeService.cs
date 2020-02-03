using CarRental.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now { get => DateTime.Now; }
    }
}
