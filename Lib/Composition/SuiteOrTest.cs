﻿using System.Collections.Generic;
using System.Linq;

namespace Lib.Composition
{
    public class SuiteOrTest
    {
        public int Id;
        public int ParentId;
        public bool IsSuite;
        public string Name;
        public bool Skipped;
        public bool Failure;
        public double Duration;
        public List<MessageAndStack> Failures;
        public List<SuiteOrTest> Nested;
        public List<MessageAndStack> Logs;

        public SuiteOrTest Clone()
        {
            return new SuiteOrTest()
            {
                Id = Id,
                ParentId = ParentId,
                IsSuite = IsSuite,
                Name = Name,
                Skipped = Skipped,
                Failure = Failure,
                Duration = Duration,
                Failures = Failures.ToList(),
                Nested = Nested != null ? new List<SuiteOrTest>(Nested.Select(n => n.Clone())) : null,
                Logs = Logs.ToList()
            };
        }
    }
}
