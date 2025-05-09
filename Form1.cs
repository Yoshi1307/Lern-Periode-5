using Microsoft.Data.Sqlite;

namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        public int cookieCount = 0;
        public int Countdown = 60;
        private System.Windows.Forms.Timer CountdownTimer;
        private Shop ShopForm;
        public int AutoclickerEarnings = 1;
        public int CursorEarnings = 1;
        public int Level_autoclicker = 1;
        public int Level_cursor = 1;
        public SqliteConnection connection;



        public Form1()
        {
            InitializeComponent();
            connection = new SqliteConnection("Data Source=..\\..\\..\\Datenbank.db");
            connection.Open();

        }

        public void UpdateCookieCount()
        {
            cookies_count.Text = $"Cookies: {cookieCount}";
        }
        private void button_cookie_Click(object sender, EventArgs e)
        {
            if (ShopForm == null || ShopForm.IsDisposed)
            {
                ShopForm = new Shop(this);
            }

            ShopForm.Show();
            ShopForm.UpdateShopCookieCount();

            int cookiesToAdd = CursorEarnings;


            cookieCount += CursorEarnings;

            cookies_count.Text = $"Cookies: {cookieCount}";
            ShopForm.UpdateShopCookieCount();
            ShopForm.UpdateCookiesPer();
            ShopForm.LevelUpdater();


        }

        private void button_shop_Click(object sender, EventArgs e)
        {
            Shop shopForm = new Shop(this);
            shopForm.Show();
            ShopForm.UpdateShopCookieCount();
        }

        private void cookies_count_Click(object sender, EventArgs e)
        {

        }



        private void Double_Countdown_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cookieCount += 10000;
            ShopForm.UpdateShopCookieCount();
            UpdateCookieCount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Spielstand SET " +
                   "CookieCount = " + cookieCount + ", " +
                   "AutoclickerEarnings = " + AutoclickerEarnings + ", " +
                   "CursorEarnings = " + CursorEarnings + ", " +
                   "Level_Autoclicker = " + Level_autoclicker + ", " +
                   "Level_Cursor = " + Level_cursor + ", " +
                   "Countdown2x = " + Countdown + ", " +
                   "Zeitpunkt = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                   "AnzahlKäufe = " + ShopForm.AnzahlKäufe + " " +
                   "WHERE Spielstand_Name_Id = 'Save1'";
            SqliteCommand cmd = new SqliteCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {


        }

    }
}