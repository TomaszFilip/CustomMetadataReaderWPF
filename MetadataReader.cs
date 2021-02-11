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
            Document = new PdfLoadedDocument(path);
            string custommetadata = Document.DocumentInformation.CustomMetadata["TestData"];
            Document.Close(true);

            path=path.Replace(".pdf", ".json");
            StreamWriter txt = new StreamWriter(path);
            txt.WriteLine(custommetadata);
        }
    }
}
