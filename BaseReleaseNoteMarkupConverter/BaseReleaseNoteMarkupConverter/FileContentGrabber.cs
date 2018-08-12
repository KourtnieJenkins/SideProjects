using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaseReleaseNoteMarkupConverter
{
    public class FileContentGrabber
    {
        private string filePath;

        public FileContentGrabber(string filePath)
        {
            this.filePath = filePath;
        }

        public string GrabContent()
        {
            string content = "";

            try
            {
                string lineOfText;
                StreamReader streamWriter = new StreamReader(filePath);

                lineOfText = streamWriter.ReadLine();

                while (lineOfText != null)
                {
                    content += lineOfText;
                    lineOfText = streamWriter.ReadLine();

                }

                streamWriter.Close();

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return content;
        }

    }
}
