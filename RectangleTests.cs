using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using assignment2;
using NUnit.Framework;
namespace assignment2.Test
{
    [TestFixture]
    public class RectangleTests
    {
        //arrange
        int length = 48;
        int width = 88;

        //act
        Rectangle rectangle = new Rectangle();

        [Test]
        public void TestGetLength()
        {
            //assert
            Assert.IsNotNull(this.rectangle.GetLength());
        }
        [Test]
        public void TestSetLength()
        {
            //assert
            Assert.AreEqual(2,this.rectangle.SetLength(2));
        }

        [Test]
        public void TestGetWidth()
        {
            //assert
            Assert.IsNotNull(this.rectangle.GetWidth());
        }
        [Test]
        public void TestSetWidth()
        {
            //assert
            Assert.AreEqual(21, this.rectangle.SetWidth(21));
        }
        [Test]
        public void TestGetPerimeter()
        {
            //assert
            Assert.IsNotNull(this.rectangle.GetPerimeter());
        }
        [Test]
        public void TestGetArea()
        {
            //assert
            Assert.IsNotNull(this.rectangle.GetArea());
        }
        //End of testing default

        [Test]
        public void TestGetLength_2()
        {
            //arrange
            Rectangle newRectangle = new Rectangle(this.length, this.width);
            int lens;

            //act
            lens = newRectangle.GetLength();
            //assert
            Assert.AreNotEqual(lens,this.rectangle.GetLength());
        }
        [Test]
        public void TestSetLength_2()
        {

            //arrange
            int lens;

            //act
            lens = this.rectangle.SetLength(this.length);

            //assert
            Assert.AreEqual(lens, this.rectangle.GetLength());
        }

        [Test]
        public void TestGetWidth_2()
        {

            //arrange
            Rectangle newRectangle = new Rectangle(this.length, this.width);
            int widths;

            //act
            widths = newRectangle.GetLength();
            //assert
            Assert.AreNotEqual(widths,this.rectangle.GetWidth());
        }
        [Test]
        public void TestSetWidth_2()
        {
            //assert
            Assert.AreNotEqual(this.rectangle.SetLength(this.length), this.rectangle.GetWidth());
        }
        [Test]
        public void TestGetPerimeter_2()
        {
            //arrange 
            int perimeter;

            //act
            perimeter = 2 * (this.width + this.length);
            //assert
            Assert.AreNotEqual(perimeter,this.rectangle.GetPerimeter());
        }
        [Test]
        public void TestGetArea_2()
        {
            //arrange 
            int area;

            //act
            area = this.width * this.length;
            //assert
            Assert.AreNotEqual(area,this.rectangle.GetArea());
        }
        // Final tests

        [Test]
        public void TestGetLength_3()
        {
            //arrange
            int lengths = 93;
            int widths = 60;
            int theLength;
            
            Rectangle newRectangle = new Rectangle(lengths, widths);

            //act
            theLength = newRectangle.GetLength();
            //assert
            Assert.AreEqual(lengths, theLength);
        }
        [Test]
        public void TestSetLength_3()
        {

            //arrange
            int lengths = 93;
            int widths = 60;
            int theLength;
            int newLength = 8798;

            Rectangle newRectangle = new Rectangle(lengths, widths);

            //act
            theLength = newRectangle.SetLength(newLength);

            //assert
            Assert.AreEqual(theLength, newLength);
        }

        [Test]
        public void TestGetWidth_3()
        {

            //arrange
            int lengths = 19;
            int widths = 76;
            int theWidth;

            Rectangle newRectangle = new Rectangle(lengths, widths);

            //act
            theWidth = newRectangle.GetLength();
            //assert
            Assert.AreNotEqual(widths, theWidth);
        }
        [Test]
        public void TestSetWidth_3()
        {

            //arrange
            int lengths = 193;
            int widths = 6;
            int theWidths;
            int newWidths = 898;

            Rectangle newRectangle = new Rectangle(lengths, widths);

            //act
            theWidths = newRectangle.SetLength(newWidths);

            //assert
            Assert.AreEqual(theWidths, newWidths);
        }
        [Test]
        public void TestGetPerimeter_3()
        {
            //arrange 
            int perimeter;
            int new_width = 76;
            int new_height = 13;
            Rectangle newRectangle = new Rectangle(new_width, new_height);

            //act
            perimeter = 2 * (new_height + new_width);
            //assert
            Assert.AreEqual(perimeter, newRectangle.GetPerimeter());
        }
        [Test]
        public void TestGetArea_3()
        {
            //arrange 
            int area;
            int new_width = 76;
            int new_height = 13;
            Rectangle newRectangle = new Rectangle(new_width, new_height);

            //act
            area = new_width * new_height;
            //assert
            Assert.AreEqual(area, newRectangle.GetArea());
        }
    }
}
