using Microsoft.Win32;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CustomMetadataReaderWPF
{
    public class MetadataReader
    {
        private PdfLoadedDocument Document;

        public void Open()
        {
            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                DefaultExt = "pdf",
                Filter = "Pdf (*.pdf)|*.pdf",
            };
            openFileDlg.ShowDialog();
            var path = openFileDlg.FileName;
            Stream stream = File.Open(path, FileMode.Open);
            Document = new PdfLoadedDocument(stream);
            string custommetadata = Document.DocumentInformation.CustomMetadata["TestData"];
        }
    }
}
