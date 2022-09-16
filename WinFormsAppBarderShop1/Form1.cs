namespace WinFormsAppBarderShop1
{
    public partial class Form1 : Form
    {
        List<DateTime> time = new List<DateTime>();
        DateTime[] input = new DateTime[100];
        DateTime[] output = new DateTime[100];
        int[] impatience = new int[100];
        int N;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to load Data from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Load_Click(object sender, EventArgs e)
        {
            Barber.FillTheOriginalArrays(out input, out N, out impatience);
            listView1.Items.Clear();
            for (int i = 0; i < input.Length; i++)
            {
                time.Add(input[i]);
                listView1.Items.Add(new ListViewItem(new String[] { time[i].Hour.ToString(), time[i].Minute.ToString() }));
            }

        }
        /// <summary>
        /// Method to count how many people will go to Hairdres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2SaveAndSolve_Click(object sender, EventArgs e)
        {
            try
            {
                Barber.FillTheFinallAray(out output, input, N, impatience);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < N; i++)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = output[i].Hour.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = output[i].Minute.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
        /// <summary>
        /// Method to solve all exercise;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Data_Click(object sender, EventArgs e)
        {
            Barber.FillTheOriginalArrays(out input, out N, out impatience);
            Barber.FillTheFinallAray(out output, input, N, impatience);
            Barber.SaveData(output);
            dataGridView2.Rows.Clear();
            for (int i = 0; i < N; i++)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = input[i].Hour.ToString() + ":" + input[i].Minute.ToString();
                dataGridView2.Rows[n].Cells[1].Value = impatience[i];
                dataGridView2.Rows[n].Cells[2].Value = output[i].ToShortTimeString();
            }


        }
    }
}