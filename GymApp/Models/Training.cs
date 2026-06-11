using System;


namespace GymApp.Models
{
    public class Trainer
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid TrainerId { get; set; }
        public TrainingType Type { get; set; }
        public bool Held { get; set; }

    }
}
