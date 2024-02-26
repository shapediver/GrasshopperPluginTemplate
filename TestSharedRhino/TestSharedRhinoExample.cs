using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Rhino.Geometry;
using PluginTemplate.SharedRhino;

namespace PluginTemplate.Tests.SharedRhino
{
    [TestClass]
    public class TestSharedRhinoExample
    {
        /// <summary>
        /// Test setup for complete class, will be called once for all tests contained herein
        /// Change signature to "async static Task" in case of async tests
        /// </summary>
        /// <param name="context"></param>
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // TODO 
        }

        /// <summary>
        /// Test setup per test, will be called once for each test
        /// Change signature to "async Task" in case of async tests
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            // TODO
        }

        /// <summary>
        /// Test method
        /// Change signature to "async Task" in case of async tests
        /// </summary>
        [TestMethod]
        public void Test_PlaneLineIntersection_00()
        {
            var sharedRhinoExample = new SharedRhinoExample();
            var point = sharedRhinoExample.PlaneLineIntersection(Plane.WorldXY, new Line(new Point3d(1,1,-1), new Point3d(1,1,1)));
            Assert.AreEqual(0, point.DistanceToSquared(new Point3d(1,1,0)));
        }

        /// <summary>
        /// Test cleanup per test, will be called once for each test
        /// Change signature to "async Task" in case of async tests
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            // TODO 
        }

        /// <summary>
        /// Test cleanup for complete class, will be called once for all tests contained herein
        /// Change signature to "async static Task" in case of async tests
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            // TODO 
        }
    }
}