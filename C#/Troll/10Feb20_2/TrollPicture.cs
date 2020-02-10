﻿using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace _10Feb20_2
{
	public class TrollPicture
	{
		public TrollPicture()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetWindowSize(150, 53);
			//Console.SetBufferSize(200, 60);
			//Console.SetWindowPosition(0, 0);
			Bitmap image = GetBitmapFromUrl(_remoteImageUrl);

			string ascii = ConvertImageToAsciiArt(image);
			Console.Write(ascii);
		}


		public const string _remoteImageUrl = "C:\\Users\\erau\\Desktop\\troll.png";
		//private const string _remoteImageUrl = "C:\\Users\\erau\\Desktop\\the finger.jfif";
		//private const string _remoteImageUrl = "C:\\Users\\erau\\Desktop\\cat.jfif";
		//private const string _remoteImageUrl = "https://media.tenor.com/images/8eeb2bb588da089d054352bcaa849513/tenor.png";


		public const int _asciiWidth = 125;

		public static string[] _asciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };





		//from http://stackoverflow.com/questions/12142634/download-image-and-create-bitmap
		public static Bitmap GetBitmapFromUrl(string remoteImageUrl)
		{
			WebRequest request = WebRequest.Create(remoteImageUrl);
			WebResponse response = request.GetResponse();
			Stream responseStream = response.GetResponseStream();
			Bitmap bitmap = new Bitmap(responseStream);
			return bitmap;
		}


		//from http://www.c-sharpcorner.com/uploadfile/dheenu27/imagetoasciiconverter03022007164455pm/imagetoasciiconverter.aspx
		public static string ConvertImageToAsciiArt(Bitmap image)
		{
			image = GetReSizedImage(image, _asciiWidth);

			//Convert the resized image into ASCII
			string ascii = ConvertToAscii(image);
			return ascii;
		}



		public static Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
		{
			int asciiHeight = 0;
			//Calculate the new Height of the image from its width
			asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);

			//Create a new Bitmap and define its resolution
			Bitmap result = new Bitmap(asciiWidth, asciiHeight);
			Graphics g = Graphics.FromImage((Image)result);
			//The interpolation mode produces high quality images 
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
			g.Dispose();
			return result;
		}


		public static string ConvertToAscii(Bitmap image)
		{
			Boolean toggle = false;
			StringBuilder sb = new StringBuilder();

			for (int h = 0; h < image.Height; h++)
			{
				for (int w = 0; w < image.Width; w++)
				{
					Color pixelColor = image.GetPixel(w, h);
					//Average out the RGB components to find the Gray Color
					int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
					Color grayColor = Color.FromArgb(red, green, blue);

					//Use the toggle flag to minimize height-wise stretch
					if (!toggle)
					{
						int index = (grayColor.R * 10) / 255;
						sb.Append(_asciiChars[index]);
					}
				}

				if (!toggle)
				{
					sb.Append(Environment.NewLine);
					toggle = true;
				}
				else
				{
					toggle = false;
				}
			}

			return sb.ToString();
		}


	}
}
