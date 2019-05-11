using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Signature
{
    class DataHandler
    {
        public static string Directions(List<Point> points)
        {
            string sequence = "";
            for (int i=0;i<points.Count-1; i++)
            {
                sequence += Direction(points[i], points[i + 1]);
            }
            string results = "";
            foreach (var letter in sequence)
            {
                if (results.Length == 0 || results.Last() != letter)
                    results+=letter;
            }
            return results;
        }
        private static int Direction(Point point1, Point point2)
        {
            double angle = Math.Atan2(point1.Y - point2.Y, point2.X - point1.X);
            double direction = angle * 4 / Math.PI;
            if (direction < -0.5)
                direction += 8;
            return (int)direction;
        }
        private static int LevensteinDistance(string string1, string string2)
        {
            if (string1 == null) throw new ArgumentNullException("string1");
            if (string2 == null) throw new ArgumentNullException("string2");
            int diff;
            int[,] m = new int[string1.Length + 1, string2.Length + 1];

            for (int i = 0; i <= string1.Length; i++) { m[i, 0] = i; }
            for (int j = 0; j <= string2.Length; j++) { m[0, j] = j; }

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    diff = (string1[i - 1] == string2[j - 1]) ? 0 : 1;

                    m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1,
                                             m[i, j - 1] + 1),
                                             m[i - 1, j - 1] + diff);
                }
            }
            return m[string1.Length, string2.Length];
        }
        public static double LevensteinMatch(string string1, string string2)
        {
            return 100*(1.0 - ((double)LevensteinDistance(string1, string2) / (double)Math.Max(string1.Length, string2.Length)));
        }
        public static string hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToLower();
        }
        public static string GenerateRandomString(int length)
        { //Убраны O, o, 0, l, 1 для лучшего чтения
            string allowedLetterChars = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
            string allowedNumberChars = "23456789";
            char[] chars = new char[length];
            Random rd = new Random();
            bool useLetter = true;
            for (int i = 0; i < length; i++)
            {
                if (useLetter)
                {
                    chars[i] = allowedLetterChars[rd.Next(0, allowedLetterChars.Length)];
                    useLetter = false;
                }
                else
                {
                    chars[i] = allowedNumberChars[rd.Next(0, allowedNumberChars.Length)]; useLetter = true;
                }
            }
            return new string(chars);
        }
    }
}
