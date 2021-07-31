using ExampleCleanArchitecture.Business.Common.Interfaces;
using System;

namespace ExampleCleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
