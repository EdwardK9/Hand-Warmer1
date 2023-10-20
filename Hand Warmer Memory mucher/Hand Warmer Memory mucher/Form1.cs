using System.Windows.Forms;

namespace Hand_Warmer_Memory_mucher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Show();
            //System.Threading.Thread.Sleep(1000);
            List<string> list = new List<string>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                list2.Add(i);

            }
            for (int i = 0; i < 1000000; i++)
            {
                list.Add("hrllo");

            }
            dataGridView1.DataSource = list;
            System.Threading.Thread.Sleep(0);
            Form1 whoknows = new Form1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}