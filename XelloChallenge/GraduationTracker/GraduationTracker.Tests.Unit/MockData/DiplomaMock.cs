﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Tests.Unit.MockData
{
    public static class DiplomaMock
    {
        public static Diploma GetDiplomaMock()
        {
            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            return diploma;

        }

    }
}
