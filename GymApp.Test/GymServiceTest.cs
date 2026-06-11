using GymApp.Exceptions;
using GymApp.Models;
using System.Collections.Generic;
using GymApp.Services;
using NSubstitute;
using NUnit.Framework;
using System;
using GymApp.Services.GymApp;

namespace GymApp.Test
{
    //Guid example: "00000000-0000-0000-0000-000000000001"
    [TestFixture]

    public class GymServiceTest
    {

            private FakePaymentService fakePaymentService;
            private FakeTrainerPerformanceService fakeTrainerPerformanceService;
            private FakeTrainingService fakeTrainingService;
            private GymService gymService;

            [SetUp]
            public void SetUp()
            {
                fakePaymentService = new FakePaymentService();
                fakeTrainerPerformanceService = new FakeTrainerPerformanceService();
                fakeTrainingService = new FakeTrainingService();

                gymService = new GymService(fakePaymentService, fakeTrainerPerformanceService,fakeTrainingService);
            }


            [Test]
        public void DoStaffBonusPaymentCalculation_ValidTrainer_NSubstitutePaymentServiceReceivedCall()
        {
            var paymentService = Substitute.For<IPaymentService>();
            var trainingService = Substitute.For<ITrainingService>();
            var performanceService = Substitute.For<ITrainerPerformanceService>();

            var service = new GymService(paymentService, trainingService, performanceService);

            Trainer trainer = new Trainer() { Id = Guid.NewGuid() };
            trainingService.GetTrainingsInTheLastMonth(trainer.Id).Returns(new List<Trainer>
            {
                new Trainer { Type = TrainingType.Group, Held = true }
            });

            performanceService.GetTrainerPerformanceReport(trainer.Id).Returns(new PerformanceReport
            {
                PerformanceRank = PerformanceRank.Second,
                PercentOfTrainingsNotHeld = 5,
                NumberOfFreeDaysLeft = 10
            });

            service.DoStaffBonusPaymentCalculation(trainer);

            paymentService.Received().UpdateTrainerBonusPayment(trainer.Id, Arg.Any<BonusPayment>());
        }
        [Test, TestCaseSource(typeof(GymServiceTestCaseData), nameof(GymServiceTestCaseData.MembershipTypeCases))]
        public void GetMembershipType_BlackBoxCases(int numberOfMonths, bool groupTrainings, double monthlyPriceBudget, TrainingTime trainingTime, MembershipType? expected)
        {
            var result = gymService.GetMemberhipType(numberOfMonths, groupTrainings, monthlyPriceBudget, trainingTime);
            Assert.That(result, Is.EqualTo(expected));
        }



    }
}
