namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;


    /// <summary>
    ///     Static class containing various string extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts string to hash  formatting hash bytes into their hexadecimal value
        /// </summary>
        /// <param name="input">The string value the method is called upon to.</param>
        /// <returns>Hexadecimal formated string</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Checks if the target string is contained in a collection of true-like strings.
        /// </summary>
        /// <param name="input">String input: supports [true, ok, yes, 1, да]</param>
        /// <returns>True if the string is found, False otherwise</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts string into its corresponding 16-bit value
        /// </summary>
        /// <param name="input">The target string</param>
        /// <returns>16-bit short value, correpsonding to the target string; Returns 0 if conversion fails </returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts string into its corresponding 32-bit value
        /// </summary>
        /// <param name="input">The target string</param>
        /// <returns>32-bit Integer value, correpsonding to the target string.Returns 0 if conversion fails.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts string into its corresponding 64-bit value
        /// </summary>
        /// <param name="input">The target string</param>
        /// <returns>64-bit Integer value, correpsonding to the target string.Returns 0 if conversion fails.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Parses a date-like string into DateTime object
        /// </summary>
        /// <param name="input">The target string the method is called upon</param>
        /// <returns>The resulting DateTimeObject; Returns <see cref="F:System.Int32.MinValue"/>  if  conversion fails</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalizes the first letter of the target string.
        /// </summary>
        /// <param name="input">The target string the method is called upon.</param>
        /// <returns>Resulting capitalized string</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Gets the substring between two substrings, starting from specified position
        /// </summary>
        /// <param name="input">The target string the method is called upon</param>
        /// <param name="startString">The start substring</param>
        /// <param name="endString">The end substring</param>
        /// <param name="startFrom">The starting position</param>
        /// <returns>The targeted substring. Empty string if no match found.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts cyrillic to latin letters looping through all the characters of the targeted string. Supports only lower case letters.
        /// </summary>
        /// <param name="input">The string the method is called upon</param>
        /// <returns>String, containing lower-case lating letters</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts the latin letters to cyrillic, looping through all the characters of the targeted string. Supports only lower case letters.
        /// </summary>
        /// <param name="input">The string the method is called upon</param>
        /// <returns>String, containing lower-case cyrillic letters</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Validates the targetes tring.Converting all cyrillic letter into their corresponding latin letters. 
        /// Then removes all non-alphabetical or non-numeric values.
        /// </summary>
        /// <param name="input">The string the method is called upon.</param>
        /// <returns>String in valid username format</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts string into valid filename: 
        /// -replaces whitespaces with '-';
        /// -replaces cyrillic letters with latin ones
        /// -removes any non-alphabetical or non-numeric character, except '.' and '-'
        /// </summary>
        /// <param name="input">The target string the method is called upon.</param>
        /// <returns>String in valid filename format </returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets the first N characters from a string
        /// </summary>
        /// <param name="input">The string the method is called upon.</param>
        /// <param name="charsCount">The length of the substring, starting from the first character</param>
        /// <returns>String with length N; Returns the initial string if the specified length 
        /// is greater than the initial length</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets the file extension of the targeted filename string.
        /// </summary>
        /// <param name="fileName">The target string</param>
        /// <returns>Substring, representing last characters after the '.' sign.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Gets the  content type which correponds the the targeted file extension
        /// </summary>
        /// <param name="fileExtension">String in valid file-extension format</param>
        /// <returns>String in valid content-type format; </returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts string into array of bytes
        /// </summary>
        /// <param name="input">The string the method is called upon</param>
        /// <returns>An array which contains  every character in the given string in its byte representation</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}