using BarcodeLib;
using System.Diagnostics;
using System;

namespace Barcode_Generator_Reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the API
            Barcode barcode = Process.CreateAndSaveBarcode("777");
            Console.WriteLine(Process.ReadBarcode(barcode));

            barcode = Process.CreateAndSaveBarcode("11");
            Console.WriteLine(Process.ReadBarcode(barcode));

            barcode = Process.CreateAndSaveBarcode("111");
            Console.WriteLine(Process.ReadBarcode(barcode));

            barcode = Process.CreateAndSaveBarcode("1111");
            Console.WriteLine(Process.ReadBarcode(barcode));
        }
    }
}
