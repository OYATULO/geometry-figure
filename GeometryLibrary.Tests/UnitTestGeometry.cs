using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Geometry_Library;
using System.Windows;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class UnitTestGeometry
    {
        [TestMethod]
        public  void  TestSumTwo()
        {
            int a = 2;
            int b = 3;
            int  summ = a + b;
            Assert.AreEqual(ClassGeometry.SumTwo(a, b), summ);        
        }
        [TestMethod]
        public void TestPloshadKrugaPoRadiusa()
        {
            double r = 2.0;
            double result = Math.PI * Math.Pow(r, 2.0);
            Assert.AreEqual(ClassGeometry.PloKruPoRadiusa(r), result);
        }
        [TestMethod]
         public void TestPloshadTreugolnikaPoTriStr()
        {
            double a=3, b=4, c=5;
            double p = (a + b + c) / 2;
            double result= Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Assert.AreEqual(ClassGeometry.PloTriPoTriSto(a, b, c), result);
        }

    }
}
