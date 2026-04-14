namespace VendingMachine
{
    public partial class Form1 : Form
    {

        List<SpaceObjects> objectsList = new List<SpaceObjects>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.objectsList.Clear();
            var rnd = new Random();

            for (var i = 0; i < 10; i++)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.objectsList.Add(Planet.Generate());
                        break;
                    case 1:
                        this.objectsList.Add(Star.Generate());
                        break;
                    case 2:
                        this.objectsList.Add(Comet.Generate());
                        break;
                }
            }

            ShowInfo();
            ShowList();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.objectsList.Count == 0)
            {
                txtOut.Text = "Вселенная схлопнулась";
                return;
            }

            var spaceObject = this.objectsList[0];
            this.objectsList.RemoveAt(0);

            txtOut.Text = spaceObject.GetInfo();

            ShowInfo();
            ShowList();
        }
        public void ShowInfo()
        {
            var planetsCount = 0;
            var starsCount = 0;
            var cometsCount = 0;
            foreach (var obj in this.objectsList)
            {
                if (obj is Planet)
                {
                    planetsCount++;
                }
                else if (obj is Star)
                {
                    starsCount++;
                }
                else if (obj is Comet)
                {
                    cometsCount++;
                }
            }

            txtInfo.Text = "Планет\tЗвёзд\tКомет";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
        }
        
        public enum ObjectTypes { comet, planet, star };
        public void ShowList()
        {
            this.listView.Items.Clear();

            foreach (var obj in this.objectsList)
            {
                if (obj is Planet)
                {
                    listView.Items.Add("", (int)ObjectTypes.planet);
                }
                else if (obj is Star)
                {
                    listView.Items.Add("", (int)ObjectTypes.star);
                }
                else if (obj is Comet)
                {
                    listView.Items.Add("", (int)ObjectTypes.comet);
                }
            }
        }
    }
}
