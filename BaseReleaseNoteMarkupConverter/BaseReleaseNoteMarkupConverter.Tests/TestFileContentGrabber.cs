using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.IO;

namespace BaseReleaseNoteMarkupConverter.Tests
{
    [TestFixture]
    public class TestFileContentGrabber
    {

        // opens a file
        // stores all content in file
        private string filePath = "testFile.txt";
        private string expectedFileContent = "This is a test";
        private StreamWriter testFile;
        private FileContentGrabber fileContentGrabber;

        [SetUp]
        public void Setup()
        {
            /*
            if (!File.Exists(filePath))
            {
                testFile = File.CreateText(filePath);
            }*/

            testFile = File.CreateText(filePath);

            testFile.WriteLine(expectedFileContent);

            fileContentGrabber = new FileContentGrabber(filePath);

            testFile.Close();
            

        }



        [Test]
        public void GrabContentFromFile_WhenInvokedWithFileObject_StoresFileContentIntoAString()      
        {
            string grabbedContent = fileContentGrabber.GrabContent();

            Assert.That(grabbedContent, Is.EqualTo(expectedFileContent));
        }


    }
}
