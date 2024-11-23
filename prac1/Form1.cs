namespace prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            this.MuestraTabla();
        }

        private void MuestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxnum.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                tabla = tabla + n + "x" + i + "=" + (n * i) + "\n";
            }
            this.richTextBoxresultados.AppendText(tabla);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Clean();
        }
        private void Clean()
        {
            this.richTextBoxresultados.Clear();
            this.textBoxnum.Clear();
        }
    }
}
