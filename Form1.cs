using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
namespace DenLaba5
{
    public partial class Form1 : Form
    {
        List<Person> StudentList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }
        private void ViewStat_Click(object sender, EventArgs e)
        {
            StatSetClear();
            StudentList.Sort(delegate (Person x, Person y)
            {
                return x.Points.CompareTo(y.Points);
            });
            StudentList.Reverse();
            label2.Text = $"1-е место: {StudentList[0].Name} - {StudentList[0].Points} баллов";
            label3.Text = $"2-е место: {StudentList[1].Name} - {StudentList[1].Points} баллов";
            label4.Text = $"3-е место: {StudentList[2].Name} - {StudentList[2].Points} баллов";
            double AveragePoint = StudentList.Sum(x => x.Points) / StudentList.Count();
            label5.Text = $"Средний балл составляет - {AveragePoint}";
            label6.Text = $"Максимальный балл - {StudentList.Max(x => x.Points)}";
            label7.Text = $"Колличество участников, набравших балл \nвыше среднего значения - {StudentList.Count(p => p.Points > AveragePoint)}";
            foreach (var person in StudentList)
            {
                if (person.Points > 250)
                {
                    dataGridView2.Rows.Add(person.Name, person.Points);
                }
            }
            viewStat.Enabled = false;
        }
        private void StatSetClear()
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            dataGridView2.Rows.Clear();
        }
        private void CopyToJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSaveJson = new SaveFileDialog();
            dialogSaveJson.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            if (dialogSaveJson.ShowDialog() == DialogResult.Cancel) { return; }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //не экранируем символы в строках
            };
            string jsonBufferStr = JsonSerializer.Serialize(StudentList, options);
            File.WriteAllText(dialogSaveJson.FileName, jsonBufferStr);
        }
        private void FromCSV_Obtane_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpenCSV = new OpenFileDialog();
            dialogOpenCSV.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";
            if (dialogOpenCSV.ShowDialog() == DialogResult.Cancel) { return; }
            StatSetClear();
            StudentList.Clear();
            dataGridView1.Rows.Clear();
            StreamReader ListReader = new StreamReader(dialogOpenCSV.FileName, Encoding.GetEncoding(1251));
            string BufferStr = "";
            while (!ListReader.EndOfStream)
            {
                BufferStr = ListReader.ReadLine();
                StudentList.Add(new Person() { Name = BufferStr.Split(';')[0], Points = Convert.ToInt32(BufferStr.Split(';')[1]) });
            }
            ListReader.Close();
            foreach (var person in StudentList)
            {
                dataGridView1.Rows.Add(person.Name, person.Points);
            }
            copyToJson.Enabled = true;
            viewStat.Enabled = true;
        }
        private void FromJson_Obtane_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpenJson = new OpenFileDialog();
            dialogOpenJson.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
            if (dialogOpenJson.ShowDialog() == DialogResult.Cancel) { return; }
            StatSetClear();
            StudentList.Clear();
            dataGridView1.Rows.Clear();
            string jsonBufferStr = File.ReadAllText(dialogOpenJson.FileName);
            StudentList = JsonSerializer.Deserialize<List<Person>>(jsonBufferStr);
            foreach (var person in StudentList)
            {
                dataGridView1.Rows.Add(person.Name, person.Points);
            }
            copyToJson.Enabled = true;
            viewStat.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            viewStat.Enabled = false;
            copyToJson.Enabled = false;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
    }
}