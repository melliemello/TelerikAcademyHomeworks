using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighQualityClasses.ImproveCohesionAndCoupling
{
    internal class FileHelper
    {
        public static string GetFileExtension(string fileName)
        {
            Validator.ValidateNonEmptyString(fileName, "Cannot parse file extension; Filename cannot be empty");
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Cannot parse file extension. Dor is missing in the input filename");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            Validator.ValidateNonEmptyString(fileName, "Cannot parse filename; Filename cannot be empty");
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
