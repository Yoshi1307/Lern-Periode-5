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
            if (ShopForm == null || ShopForm.IsDisposed)
            {
                ShopForm = new Shop(this);
            }
            ShopForm.Show();
        }

        public void UpdateCookieCount()
        {
            cookies_count.Text = $"Cookies: {cookieCount}";
        }
        private void button_cookie_Click(object sender, EventArgs e)
        {


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
            var result = MessageBox.Show(
                "Möchten Sie den Spielstand wirklich speichern?",
                "Bestätigung",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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

                try
                {
                    SqliteCommand cmd = new SqliteCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Spielstand gespeichert!", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Speichern des Spielstands: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Möchten Sie den Spielstand wirklich laden?",
                "Bestätigung",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "SELECT CookieCount, AutoclickerEarnings, CursorEarnings, Level_Autoclicker, Level_Cursor, Countdown2x, AnzahlKäufe " +
                               "FROM Spielstand WHERE Spielstand_Name_Id = 'Save1'";

                try
                {
                    using (SqliteCommand cmd = new SqliteCommand(query, connection))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Werte laden
                            cookieCount = reader.GetInt32(0);
                            AutoclickerEarnings = reader.GetInt32(1);
                            CursorEarnings = reader.GetInt32(2);
                            Level_autoclicker = reader.GetInt32(3);
                            Level_cursor = reader.GetInt32(4);
                            Countdown = reader.GetInt32(5);
                            ShopForm.AnzahlKäufe = reader.GetInt32(6);

                            // Werte anzeigen
                            UpdateCookieCount();
                            ShopForm.UpdateShopCookieCount();
                            ShopForm.UpdateCookiesPer();
                            ShopForm.LevelUpdater();
                            ShopForm.timer.Start();

                            MessageBox.Show("Spielstand geladen", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kein Spielstand gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden des Spielstands: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Möchten Sie den Spielstand wirklich zurücksetzen?",
                "Bestätigung",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Werte zurücksetzen
                cookieCount = 0;
                AutoclickerEarnings = 1;
                CursorEarnings = 1;
                Level_autoclicker = 1;
                Level_cursor = 1;
                Countdown = 60;
                ShopForm.AnzahlKäufe = 0;
                ShopForm.Countdown = 60;
                ShopForm.ResetUpgradePreise();
                ShopForm.ResetAutoclicker();
                ShopForm.ResetDoubleCountdown(); 
                ShopForm.UpdateShopCookieCount();
                ShopForm.UpdateCookiesPer();
                ShopForm.LevelUpdater();
                UpdateCookieCount();

                MessageBox.Show("Spielstand wurde zurückgesetzt!", "Zurückgesetzt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
    }
}