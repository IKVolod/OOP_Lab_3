using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOP_Lab_3
{
    internal class Task2
    {
        public static void Start()
        {
            string[] fileNames = Directory.GetFiles("C:\\Users\\Little Warudo\\RiderProjects\\ConsoleApplication1\\Photo");

            Regex regexExtForImage = new Regex("^((.bmp)|(.gif)|(.tiff?)|(.jpe?g)|(.png)|(.ico)|(.exif)|(.emf)|(.wmf)|(.jpg)|(.tga)|(.dds)|(.dib))$", RegexOptions.IgnoreCase);
            
            foreach (string file in fileNames)
            {
                try
                {
                    using (Bitmap originalImage = new Bitmap(file))
                    {
                        originalImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        originalImage.Save(file.Remove(file.IndexOf('.')) + "-mirrored.gif");
                    }
                }
                catch
                {
                    Console.WriteLine($"catch: {file}");
                    if (regexExtForImage.IsMatch(Path.GetExtension(file)))
                    {
                        MessageBox.Show($"Something wrong with this file: {file.Substring(file.LastIndexOf('\\') + 1)}");
                    }
                }
            }
        }
    }
}