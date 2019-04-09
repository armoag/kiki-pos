using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DYMO.Label;
using DYMO.Label.Framework;

namespace Kiki
{
    public class LabelPrinter
    {
        #region Fields

        private Label _codeLabel;
        private Label _priceLabel;

        #endregion

        #region Properties

        public Label CodeLabel
        {
            get { return _codeLabel; }
            set { _codeLabel = value; }
        }

        public Label PriceLabel
        {
            get { return _codeLabel; }
            set { _codeLabel = value; }
        }

        #endregion

        #region Constructors

        public LabelPrinter(string codeLabelFullPath, string )
        {
            var label = Label.Open(@"C:\Projects\wibsar-pos-solution\Kiki\Labels\smallLabel.label");
            label.SetObjectText("BARCODE", "809765430");
            if (label.AddressObjectCount > 0)
            {
                label.SetAddressText(0, "132");              
            }

            IPrintParams param = new LabelWriterPrintParams();
            param.Copies = 2;
            
            
            label.Print("DYMO LabelWriter 450 Turbo", param);
            label.SetObjectText("BARCODE","4385CRN1M");
            param.Copies = 1;
            label.Print("DYMO LabelWriter 450 Turbo", param);
            //var printers = Framework.GetLabelWriterPrinters();
            //printers.First().CreatePrintJob(new LabelWriterPrintParams(1, "213345", FlowDirection.LeftToRight,
            //    RollSelection.Auto, LabelWriterPrintQuality.Auto));

            //var printer = Framework.Open(printers.ToString());

        }

        #endregion

        #region Instance Methods

        #endregion

        #region Static Methods

        #endregion

    }
}
