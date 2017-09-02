using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ApprovalTests;
using ApprovalTests.Reporters;


namespace Trivia
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    class TriviaTest
    {
        [Test]
        public void DeterministicTest()
        {
//            Assert.AreEqual(1,1);
        }
    }
}
