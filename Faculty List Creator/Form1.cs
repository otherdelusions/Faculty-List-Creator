namespace Faculty_List_Creator
{
    public partial class Form1 : Form
    {
        public static string mode = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "faculty";
            DialogResult response = new facultyForm().ShowDialog();

            if (response == DialogResult.OK)
            {
                facultyBox.Text = facultyForm.facultyString;
            }
        }

        private void deansNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "dean";
            DialogResult response = new facultyForm().ShowDialog();

            if (response == DialogResult.OK)
            {
                nameBox.Text = facultyForm.facultyString;
            }
        }

        private void abbreviationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "abbrev";
            DialogResult response = new facultyForm().ShowDialog();

            if (response == DialogResult.OK)
            {
                abbrevBox.Text = facultyForm.facultyString;
            }
        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] lines = { "Факультет: " + facultyBox.Text, "Декан: " + nameBox.Text, "Аббревиатура: " + abbrevBox.Text, "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" };
            File.AppendAllLines(Path.Combine(docPath, outputBox.Text), lines);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
