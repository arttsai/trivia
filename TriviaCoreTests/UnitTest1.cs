using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.Windows;
using NUnit.Framework;
using Trivia;



namespace TriviaCoreTests
{
    [TestFixture]
    [UseReporter(typeof(VisualStudioReporter))]
    public class TriviaCoreTests
    {
        [Test]
        public void Test1()
        {
            var path = "GameResult.txt";
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            Console.SetOut(sw);

            GameRunner.PlayGame(); 

            sw.Close();

            // https://docs.microsoft.com/zh-tw/dotnet/api/system.console.setout?view=netframework-4.8
            var standardOutput = new StreamWriter(Console.OpenStandardOutput()) {AutoFlush = true};
            Console.SetOut(standardOutput);

            Approvals.VerifyFile(path);
        }
    }
}