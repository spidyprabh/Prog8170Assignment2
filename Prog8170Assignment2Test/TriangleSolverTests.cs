using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170Assignment2;
using NUnit.Framework;

namespace Prog8170Assignment2Test
{
  public class TriangleSolverTests
  {
    [Test]
    public void BoundaryValueTestexpectInvalidTraingle ()
    {
      // Arrange
      int l = 200;
      int b = 3;
      int h = 1;
      //Act
      string report = TriangleSolver.Analyze(l, b, h);
      //Assert
      Assert.AreEqual("Triangle cannot be formed", report);
    }
    [Test]
    public void ThreeSidesEqual_expectEquilateralTriangle()
    {
      //Arrange
      int l = 6;
      int b = 6;
      int h = 6;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("This is an Equilateral Triangle", report);
    }
    [Test]
    public void TwoSidesEqual_expectIsoscelesTriangle()
    {
      //Arrange
      int l = 6;
      int b = 6;
      int h = 3;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("This is an Isosceles Triangle", report);

    }
    [Test]
    public void Threevalidside_expectScaleneTriangle()
    {
      //Arrange
      int l = 4;
      int b = 5;
      int h = 7;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("This is a Scalene Triangle", report);

    }
    [Test]
    public void InvalidInput_expectNotaTriangle()
    {
      //Arrange
      int l = 0;
      int b = 6;
      int h = 3;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("Triangle cannot be formed", report);

    }
    [Test]
    public void NegativeValues_expectNotaTriangle()
    {
      //Arrange
      int l = -1;
      int b = -1;
      int h = -1;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("Triangle cannot be formed", report);

    }
    [Test]
    public void Zerovalue_expectNotaTriangle()
    {
      //Arrange
      int l = 0;
      int b = 0;
      int h = 0;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("Triangle cannot be formed", report);

    }
    [Test]
    public void Sumoftwoside_expectNotaTriangle()
    {
      //Arrange
      int l = 2;
      int b = 2;
      int h = 4;

      //Act
      string report = TriangleSolver.Analyze(l, b, h);

      //Assert
      Assert.AreEqual("Triangle cannot be formed", report);

    }
  }

}
    

