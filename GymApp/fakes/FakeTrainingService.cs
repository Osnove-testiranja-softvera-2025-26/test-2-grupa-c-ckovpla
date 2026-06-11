
using GymApp.Models;
using GymApp.Services;
using System;
using System.Collections.Generic;

namespace GymApp.Test
{
    public class FakeTrainingService : ITrainingService
    {
        public List<Trainer> Trainings { get; set; } = new List<Trainer>();
        public Exception ExceptionWillOccur { get; set; }

        public List<Trainer> GetTrainingsInTheLastMonth(Guid trainerId)
        {
            if (ExceptionWillOccur != null)
                throw ExceptionWillOccur;

            return Trainings;
        }
    }
}


