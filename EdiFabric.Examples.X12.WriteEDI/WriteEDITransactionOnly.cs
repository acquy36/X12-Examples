﻿using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdiFabric.Examples.X12.Common;
using EdiFabric.Examples.X12.Templates.V4010;
using EdiFabric.Framework;
using EdiFabric.Framework.Writers;

namespace EdiFabric.Examples.X12.WriteEDI
{
    class WriteEDITransactionOnly
    {
        /// <summary>
        ///  Writes to stream without envelopes - no ISA, GS, GE or IEA
        /// </summary>
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            using (var stream = new MemoryStream())
            {
                //  Set the separators
                using (var writer = new X12Writer(stream, new X12WriterSettings() { Separators = Separators.X12 }))
                {
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("1"));
                    writer.Write(EF_X12_004010_810_Builder.BuildInvoice("2"));
                }

                Debug.Write(stream.LoadToString());
            }
        }
    }
}
