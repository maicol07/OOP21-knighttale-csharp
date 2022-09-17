using AKnightsTale.MaicolBattistini.utils;
using NUnit.Framework;
using FluentAssertions;

namespace AKnightsTale.MaicolBattistini.Tests.Utils
{
    /// <summary>
    /// Tests for the <see cref="utils.AppPaths"/> class.
    /// </summary>
    [TestFixture]
    public class AppPaths
    {
        /// <summary>
        /// Tests the <see cref="utils.AppPaths.GetFilePath"/> method.
        /// </summary>
        [Test]
        public void TestGetPath()
        {
            var appdata = Environment.GetCommandLineArgs().Contains("headless")
                ? Path.GetFullPath("build")
                : Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                    , "unibo", App.AppName, App.AppVersion);

            var path = appdata + Path.DirectorySeparatorChar + "test.txt";

            utils.AppPaths.GetFilePath("test.txt").Should().BeEquivalentTo(path);
        }
    }
}