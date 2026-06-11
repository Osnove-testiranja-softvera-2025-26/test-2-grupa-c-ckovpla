using GymApp.Models;
using GymApp.Services;
using System;

namespace GymApp.Test
{
    public class FakeTrainerPerformanceService : ITrainerPerformanceService
    {
        public PerformanceReport PerformanceReport { get; set; }
        public Exception ExceptionWillOccur { get; set; }

        public PerformanceReport GetTrainerPerformanceReport(Guid trainerId)
        {
            if (ExceptionWillOccur != null)
                throw ExceptionWillOccur;

            return PerformanceReport;
        }
    }
}
