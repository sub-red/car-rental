using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime Now { get; }
    }
}
