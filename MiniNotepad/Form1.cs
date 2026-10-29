namespace MiniNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.Refresh();

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StreamReader streamReader;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                streamReader = File.OpenText(openFileDialog1.FileName);
                string fileContent;
                fileContent = streamReader.ReadToEnd();
                textBox1.Text = fileContent;
                streamReader.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File ka Wali Si Sax Ah kuma Soo furin!");
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Refresh();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            //DialogResult result = SaveFileDialog.ShowDialog();
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                streamWriter = File.CreateText(saveFileDialog1.FileName);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File ka Wali Ma Save Gareyn!");
            }
        }

        private void savToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            //DialogResult result = SaveFileDialog.ShowDialog();
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                streamWriter = File.CreateText(saveFileDialog1.FileName);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File ka Wali Ma Save Gareyn!");
            }

        }

        private void closeTapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            //DialogResult result = SaveFileDialog.ShowDialog();
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                streamWriter = File.AppendText(saveFileDialog1.FileName);
                streamWriter.WriteLine(textBox1.Text);
                streamWriter.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("File ka Wali Ma Updata Gareyn!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        float defaultFontSize = 12f;

        private void restoreDefualtZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(
                textBox1.Font.FontFamily,
                defaultFontSize
            );
        }
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize = textBox1.Font.Size;

            if (currentSize > 6)
            {
                textBox1.Font = new Font(
                    textBox1.Font.FontFamily,
                    currentSize - 2
                );
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize = textBox1.Font.Size;

            if (currentSize < 40)
            {
                textBox1.Font = new Font(
                    textBox1.Font.FontFamily,
                    currentSize + 2
                );
            }
        }
    }
}
