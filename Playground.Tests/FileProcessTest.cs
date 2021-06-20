using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Infrastructure;

namespace Playground.Tests
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileExist()
        {
            //arrange
            var fp = new FileProcess();
            bool fromCall;

            //act
            fromCall = fp.FileExists(@"D:\Users\Gamal Elsherbiny\Desktop\code.cs");

            //assert
            Assert.IsTrue(fromCall); 
        }


        [TestMethod]
        public void FileDoesNotExist()
        {
            //arrange
            var fp = new FileProcess();
            bool fromCall;

            //act
            fromCall = fp.FileExists(@"D:\Users\Gamal Elsherbiny\Desktop\coco.cs");

            //assert
            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            //arrange
            var fp = new FileProcess();

            //act
            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            //arrange
            var fb = new FileProcess();

            //act
            try
            {
                fb.FileExists("");
            }
            catch (ArgumentNullException)
            {

                return;
            }

            //assert
            //Assert.Fail("file exists did not throw ArgumentNullException");
        }
    }
}
