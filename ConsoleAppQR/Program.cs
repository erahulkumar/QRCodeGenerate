using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
namespace ConsoleAppQR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Text to encode in QR code
            //string text = "https://engineerboyz.in/";
            string text;
            Console.WriteLine("Enter qr code name ");
            text = Console.ReadLine();
            // Create QR code generator object
            QRCodeGenerator qrGenerator = new QRCodeGenerator();

            // Generate QR code
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

            // Create QR code object
            QRCode qrCode = new QRCode(qrCodeData);

            // Convert QR code to bitmap image
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Save QR code image to file
            string txtimg;
            Console.WriteLine("Enter qr code image name include (.png) ");
            txtimg = Console.ReadLine();
            qrCodeImage.Save(txtimg, ImageFormat.Png);
            //qrCodeImage.Save("EngineerBoyz", ImageFormat.Png);
            // Display success message
            Console.WriteLine("QR code generated successfully.");
            Console.ReadKey();
        }
    }
}
