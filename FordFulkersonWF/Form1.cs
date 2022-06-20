using System.Text.Json;
using System.Text;
namespace FordFulkersonWF
{
    public partial class Form1 : Form
    {
        private Vertex[]? vertices;
        private int source;
        private int target;
        StringBuilder sb = new StringBuilder();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxSource.Enabled = false;
            textBoxTarget.Enabled = false;
            buttonMaxGraphFlow.Enabled = false;
            GetData();
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        public void GetData()
        {
            // Init vertices in Vert.cs
            using (var reader = new StreamReader("vertices.json"))
            {
                var json = reader.ReadToEnd();
                vertices = JsonSerializer.Deserialize<Vertex[]>(json);
            }
            labelJson.Text = "Correct";
            labelJson.ForeColor = Color.Green;
            textBoxSource.Enabled = true;
            textBoxTarget.Enabled = true;
            buttonMaxGraphFlow.Enabled = true;
        }
        
        public String GetMaxGraphFlow()
        {
            List<Way> Ways = new List<Way>();
            int j = source;
            while (j != -1)
            {
                int v = source;                               // стартовая вершина
                List<int> visited = new List<int>();           // использованные вершины
                visited.Add(v);
                List<VertexMark> marks = new List<VertexMark>();    // метки маршрута


                while (v != target)                            // выполняем пока не дошли до стока
                {
                    j = GetMaxVertex(v, visited);
                    if (j == -1)                                     // если не удалось выбрать следующую вершину
                    {
                        if (v == source)                       // если мы еще в истоке, то заканчиваем работу алгоритма
                        {
                            break;
                        }
                        visited.Add(v);                        // добавляем вершину в просмотренную, чтобы ее дальше не рассматривать
                        v = marks.Last().From;                      // переходим на пердыдущую вершину
                        marks.Remove(marks.Last());                 // удаляем метку вершины
                        continue;
                    }

                    marks.Add(new VertexMark                        // добавляем метку маршрута
                    {
                        From = v,
                        CurrentVertex = j,
                        Volume = vertices![j - 1].Connections!.Where(k => k.VertexNumber == v).First().ThroughputFrom
                    });
                    visited.Add(v);                            // добавляем вершину в просмотренную, чтобы ее дальше не рассматривать

                    if (j == target)                           // если дошли до стока
                    {
                        int maxFlow = GetMaxWayFlow(marks);                     // ищем максимальную пропускную способность в маршруте

                        Ways?.Add(new Way
                        {
                            MaxThroughput = maxFlow,
                            Vertices = new List<int>()
                        });
                        Ways?.Last().Vertices?.Add(source);
                        foreach (var mark in marks)
                        {
                            Ways?.Last().Vertices?.Add(mark.CurrentVertex);
                        }
                        sb.Append(Ways?.Last());
                        Update(marks, maxFlow);
                        break;
                    }

                    v = j;

                }
            }
            int res = 0;
            foreach (var Way in Ways!)
            {
                res += Way.MaxThroughput;
            }
            return $"Максимальный поток сети: {res}.\n Маршруты:\n {sb.ToString()}";
        }

        private void Update(List<VertexMark> marks, int maxWayFlow)       // обновляем пропускнуые способности для потоков
        {
            foreach (var mark in marks)                 // проходим по всем меткам
            {
                int startVertex = mark.From;            // начальная вершина потока
                int endVertex = mark.CurrentVertex;     // конечная вершина потока
                int counter = 0;
                foreach (var vertex in vertices!)
                {
                    if (vertex.VertexNumber == startVertex)
                    {
                        foreach (var p in vertex.Connections!)
                        {
                            if (p.VertexNumber == endVertex)
                            {
                                // обновляем пропускную способность для потока
                                try
                                {
                                    vertices[counter].Connections!.Where(point => point.VertexNumber == p.VertexNumber).First().ThroughputTo += maxWayFlow;
                                    vertices[counter].Connections!.Where(point => point.VertexNumber == p.VertexNumber).First().ThroughputFrom -= maxWayFlow;

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }

                    else if (vertex.VertexNumber == endVertex)
                    {
                        foreach (var p in vertex.Connections!)
                        {
                            if (p.VertexNumber == startVertex)
                            {
                                // обновляем пропускную способность для потока
                                try
                                {
                                    vertices[counter].Connections!.Where(point => point.VertexNumber == p.VertexNumber).First().ThroughputTo += maxWayFlow;
                                    vertices[counter].Connections!.Where(point => point.VertexNumber == p.VertexNumber).First().ThroughputFrom -= maxWayFlow;

                                } catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }

                    counter++;
                }
            }
        }

        // ищем вершину с максимальной пропускной способностью
        private int GetMaxVertex(int currentVertex, List<int> visited)
        {
            if (currentVertex == target)
                return -1;
            // сортируем доступные вершины по пропускной спобности
            var Vs = vertices![currentVertex - 1].Connections!.OrderByDescending(v => v.ThroughputTo);
            // проходим по всем вершинам и ищем вершину с максимальной пропускной способностью
            foreach (var V in Vs)
            {
                // если вершина не просмотрена и ее пропускная способность больше нуля
                if (visited.Contains(V.VertexNumber))
                    continue;
                if (V.ThroughputTo > 0)
                    return V.VertexNumber;
            }
            return -1;
        }

        // ищем максимальную пропускную способность в маршруте
        private int GetMaxWayFlow(List<VertexMark> points)
        {
            return points.OrderBy(p => p.Volume).First().Volume;

        }

        // вершина, которая связана с рассматриваемой вершиной
        class ConnectedVertex                     
        {
            public int VertexNumber { get; set; }       // номер вершины
            public int ThroughputFrom { get; set; }     // пропускная способность от вершины
            public int ThroughputTo { get; set; }       // пропускная способность к вершине

        }

        // вершина
        class Vertex
        {
            public int VertexNumber { get; set; }                   // номер вершины
            public List<ConnectedVertex>? Connections { get; set; } // отношения с другими вершинами
        }

        // описание метки вершины
        class VertexMark                           
        {
            public int Volume { get; set; }          // пропускная способность
            public int From { get; set; }               // предыдущая вершина
            public int CurrentVertex { get; set; }      // текущая вершина
        }

        // Маршрут
        class Way                                
        {
            public List<int>? Vertices { get; set; }            // список вершин
            public int MaxThroughput { get; set; }              // максимальный поток маршрута

            public override string ToString()
            {
                String res = String.Empty;
                foreach (var it in Vertices!)
                {
                    res += it + " ➤ ";
                }
                res += "Максимальный поток на этом маршруте: " + MaxThroughput + "\n";
                return res;
            }

        }

        private void buttonMaxGraphFlow_Click(object sender, EventArgs e)
        {
            int s = 0;
            int t = 0;
            if (int.TryParse(textBoxSource.Text, out s))
            {
                s = Convert.ToInt32(textBoxSource.Text);
            }
            else
            {
                MessageBox.Show("Incorrect source number");
                return;
            }

            if (int.TryParse(textBoxTarget.Text, out t))
            {
                t = Convert.ToInt32(textBoxTarget.Text);
            }
            else
            {
                MessageBox.Show("Incorrect target number");
                return;
            }

            if (s == 0 || t == 0)
            {
                MessageBox.Show("Incorrect source or target number");
                return;
            }
            else
            {
                source = s;
                target = t;
                textBoxSource.Enabled = false;
                textBoxTarget.Enabled = false;
                buttonMaxGraphFlow.Enabled = false;
            }
            richTextBox1.Text = GetMaxGraphFlow();
        }

    }
}