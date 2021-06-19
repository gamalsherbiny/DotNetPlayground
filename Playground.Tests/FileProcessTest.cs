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
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingAttribute()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FileNameNullOrEmpty_UsingTryCatch()
        {
            Assert.Inconclusive();
        }
    }
}
