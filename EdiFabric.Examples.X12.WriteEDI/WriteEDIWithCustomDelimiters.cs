﻿using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Examples.X12.Templates.V4010;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDIWithCustomDelimiters
    {
        /// <summary>
        /// Write with custom separators, by default it uses the standard separators.
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            var invoice = EF_X12_004010_810_Builder.BuildInvoice("1");

            using (var stream = new MemoryStream())
            {
                using (var writer = new X12Writer(stream))
                {
                    //  Set a custom segment separator.
                    var separators = new Separators('|', Separators.X12.ComponentDataElement,
                        Separators.X12.DataElement, Separators.X12.RepetitionDataElement, Separators.X12.Escape);

                    //  Write the ISA with the custom separator set
                    writer.Write(SegmentBuilders.BuildIsa("1"), separators);
                    writer.Write(SegmentBuilders.BuildGs("1"));
                    writer.Write(invoice);
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
