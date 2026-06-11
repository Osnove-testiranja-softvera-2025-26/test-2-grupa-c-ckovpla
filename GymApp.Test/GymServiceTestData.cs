using System;
using GymApp.Models;
using System.Collections.Generic;

namespace GymApp.Test
{
    public static class GymServiceTestCaseData
    {
        public static IEnumerable<object[]> MembershipTypeCases
        {
            get
            {
                yield return new object[] { 5, true, 20.0, TrainingTime.WholeDay, MembershipType.TypeA };
                yield return new object[] { 4, false, 20.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 5, false, 10.0, TrainingTime.OnlyMorning, null };
                yield return new object[] { 12, true, 15.0, TrainingTime.OnlyMorning, MembershipType.TypeC };
                yield return new object[] { 13, false, 15.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 5, true, 30.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 4, false, 30.0, TrainingTime.WholeDay, null };
                yield return new object[] { 6, false, 30.0, TrainingTime.OnlyMorning, MembershipType.TypeC };
                yield return new object[] { 12, false, 20.0, TrainingTime.WholeDay, null };
                yield return new object[] { 4, true, 25.0, TrainingTime.OnlyMorning, null };
                yield return new object[] { 13, false, 25.0, TrainingTime.WholeDay, MembershipType.TypeB };
                yield return new object[] { 12, false, 30.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 5, true, 25.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 13, true, 30.0, TrainingTime.OnlyMorning, MembershipType.TypeC };
                yield return new object[] { 12, true, 25.0, TrainingTime.OnlyMorning, MembershipType.TypeC };
                yield return new object[] { 6, true, 15.0, TrainingTime.WholeDay, MembershipType.TypeB };
                yield return new object[] { 6, true, 10.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 5, false, 15.0, TrainingTime.WholeDay, MembershipType.TypeB };
                yield return new object[] { 4, false, 15.0, TrainingTime.WholeDay, null };
                yield return new object[] { 6, false, 25.0, TrainingTime.WholeDay, MembershipType.TypeB };
                yield return new object[] { 4, true, 10.0, TrainingTime.WholeDay, null };
                yield return new object[] { 6, false, 20.0, TrainingTime.OnlyMorning, MembershipType.TypeC };
                yield return new object[] { 13, false, 20.0, TrainingTime.OnlyNight, MembershipType.TypeD };
                yield return new object[] { 13, false, 10.0, TrainingTime.OnlyMorning, MembershipType.TypeC };
                yield return new object[] { 12, false, 10.0, TrainingTime.OnlyMorning, null };
            }
        }
    }
}


