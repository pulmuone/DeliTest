using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace DeliTest
{
    public class BarcodeGenerator
    {
        static readonly BarcodeGenerator instance = new BarcodeGenerator();

        private ZXing.BarcodeWriter barcodeWriter;

        private BarcodeGenerator()
        {
            barcodeWriter = new BarcodeWriter();
        }

        public static BarcodeGenerator Instance
        {
            get
            {
                return instance;
            }
        }

        public ZXing.BarcodeWriter Writer
        {
            get
            {
                return barcodeWriter;
            }
        }
    }
}
