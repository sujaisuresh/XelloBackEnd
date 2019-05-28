using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using GraduationTracker.Tests.Unit.MockData;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void TestHasCredits()
        {
            var tracker = new GraduationTracker();

            var graduated = new List<Tuple<bool, STANDING>>();

            foreach(var student in StudentMock.GetStudentMock())
            {
                graduated.Add(tracker.HasGraduated(DiplomaMock.GetDiplomaMock(), student));      
            }
            
            Assert.IsFalse(!graduated.Where(x=>x.Item1 == false).Any());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithInvalidDiplomaThrowsException()
        {
            var tracker = new GraduationTracker();

            var graduated = new List<Tuple<bool, STANDING>>();

            foreach (var student in StudentMock.GetStudentMock())
            {
                graduated.Add(tracker.HasGraduated(null, student));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestWithInvalidStudentThrowsException()
        {
                var tracker = new GraduationTracker();

                var graduated = new List<Tuple<bool, STANDING>>();
                var studentMock = StudentMock.GetInvalidStudentMock();

                foreach (var student in studentMock)
                {
                    graduated.Add(tracker.HasGraduated(DiplomaMock.GetDiplomaMock(), student));
                }
        }
    }
}
