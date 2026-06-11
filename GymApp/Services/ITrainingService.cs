using GymApp.Models;
using System;
using System.Collections.Generic;

namespace GymApp.Services
{
    public interface ITrainingService
    {
        List<Trainer> GetTrainingsInTheLastMonth(Guid trainerId);
    }
}
