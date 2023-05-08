namespace DragTextFilesIntoRichTextBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dragDropRichTextBox1 = new DragTextFilesIntoRichTextBox.DragDropRichTextBox();
            this.SuspendLayout();
            // 
            // dragDropRichTextBox1
            // 
            this.dragDropRichTextBox1.AllowDrop = true;
            this.dragDropRichTextBox1.Location = new System.Drawing.Point(12, 12);
            this.dragDropRichTextBox1.Name = "dragDropRichTextBox1";
            this.dragDropRichTextBox1.Size = new System.Drawing.Size(383, 257);
            this.dragDropRichTextBox1.TabIndex = 0;
            this.dragDropRichTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 356);
            this.Controls.Add(this.dragDropRichTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DragDropRichTextBox dragDropRichTextBox1;
    }
}

