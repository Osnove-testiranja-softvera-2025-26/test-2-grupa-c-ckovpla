using GymApp.Models;
using GymApp.Services;
using System;

namespace GymApp.Test
{
    public class FakePaymentService : IPaymentService
    {
        public BonusPayment BonusPayment { get; private set; }
        public Guid TrainerId { get; private set; }
        public Exception ExceptionWillOccur { get; set; }

        public void UpdateTrainerBonusPayment(Guid trainerId, BonusPayment payment)
        {
            if (ExceptionWillOccur != null)
                throw ExceptionWillOccur;

            TrainerId = trainerId;
            BonusPayment = payment;
        }
    }
}
