using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;

namespace TryingAnnotations
{
   
    public class TryingAnnotations
    {
        [TestFixture]
        public class TryingAnnotations1
        {
            [Test]

            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            // Meet Sheth's Test
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);

            }

        }
       
    }
}