using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTextFilesIntoRichTextBox
{
    class DragDropRichTextBox : RichTextBox
    {
        public DragDropRichTextBox()
        {
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(DragDropRichTextBox_DragDrop);
        }

        private void DragDropRichTextBox_DragDrop(object sender, DragEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = e.Data.GetData(DataFormats.FileDrop) as string[];

                if (fileNames != null)
                {
                    foreach (string name in fileNames)
                    {
                        try
                        {
                            this.AppendText(File.ReadAllText(name) + "\n\n");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
