using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Cookie_Clicker
{
    public partial class Shop : Form
    {

        private Form1 mainForm;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Timer DoubleTimer;
        private System.Windows.Forms.Timer CountdownTimer;

        

        public int AnzahlKäufe = 0;
        public int Countdown = 60;



        public Shop()
        {
            InitializeComponent();
        }
        public Shop(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            //Autoclicker Interval Timer
            timer = new System.Windows.Forms.Timer { Interval = 2000 };
            timer.Tick += UpdateAutoclicker;

            //2x Upgrade Timer
            DoubleTimer = new System.Windows.Forms.Timer { Interval = 60000 };
            DoubleTimer.Tick += DoubleEarningsStop;


            UpdateShopCookieCount();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        public void UpdateShopCookieCount()
        {
            cookie_count_shop.Text = $"Cookies: {mainForm.cookieCount}";
        }

        public void UpdateCookiesPer()
        {
            CPA.Text = $"CPA: {mainForm.AutoclickerEarnings}";
            CPC.Text = $"CPC: {mainForm.CursorEarnings}";
        }


        public void LevelUpdater()
        {
            Level_Autoclicker.Text = $"Level {mainForm.Level_autoclicker}";
            Level_Cursor.Text = $"Level {mainForm.Level_cursor}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateCookieCount()
        {
            cookie_count_shop.Text = $"Cookies: {mainForm.cookieCount}";
        }
        public void Autoclicker_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_Autoklicker.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);


            if (mainForm.cookieCount >= currentPrice)
            {
                mainForm.cookieCount -= currentPrice;
                if (currentPrice >= 500 && currentPrice < 2000)
                {
                    currentPrice += 150;
                    mainForm.AutoclickerEarnings += 1;
                }
                else if (currentPrice >= 2000 && currentPrice < 5000)
                {
                    currentPrice += 200;
                    mainForm.AutoclickerEarnings += 2;
                }
                else if (currentPrice >= 5000)
                {
                    currentPrice += 300;
                    mainForm.AutoclickerEarnings += 3;
                }

                Preis_Autoklicker.Text = currentPrice.ToString() + " 🍪";

                UpdateShopCookieCount();

                mainForm.UpdateCookieCount();
                if (!timer.Enabled)
                {

                    timer.Start();
                }


                mainForm.Level_autoclicker++;
                Level_Autoclicker.Text = $"Level {mainForm.Level_autoclicker}";
                UpdateCookiesPer();
            }


        }
        public void UpdateAutoclicker(object sender, EventArgs e)
        {
            mainForm.cookieCount += mainForm.AutoclickerEarnings;
            mainForm.UpdateCookieCount();

            UpdateShopCookieCount();
        }

        public void Cursor_Upgrade_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_Cursor.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);

            if (mainForm.cookieCount >= currentPrice)
            {
                mainForm.cookieCount -= currentPrice;
                if (currentPrice == 50)
                {
                    currentPrice += 50;
                    mainForm.CursorEarnings += 1;
                }
                else if (currentPrice > 51 && currentPrice < 500)
                {
                    currentPrice += 100;
                    mainForm.CursorEarnings += 1;
                }
                else if (currentPrice >= 500 && currentPrice < 2000)
                {
                    currentPrice += 150;
                    mainForm.CursorEarnings += 1;
                }
                else if (currentPrice >= 2000 && currentPrice < 5000)
                {
                    currentPrice += 200;
                    mainForm.CursorEarnings += 2;
                }
                else if (currentPrice >= 5000)
                {
                    currentPrice += 300;
                    mainForm.CursorEarnings += 3;
                }

                Preis_Cursor.Text = currentPrice.ToString() + " 🍪";

                UpdateShopCookieCount();
                mainForm.UpdateCookieCount();


                mainForm.Level_cursor++;
                Level_Cursor.Text = $"Level {mainForm.Level_cursor}";
                UpdateCookiesPer();
            }
        }

        private void Shop_Sign_Click(object sender, EventArgs e)
        {

        }

        public void cookie_count_shop_Click(object sender, EventArgs e)
        {

        }

        public void Level_Autoclicker_Click(object sender, EventArgs e)
        {

        }

        private void Level_Cursor_Click(object sender, EventArgs e)
        {

        }

        public void Upgrade_2x_Click(object sender, EventArgs e)
        {
            string[] parts = Preis_2x.Text.Split(' ');
            int currentPrice = 0;
            int.TryParse(parts[0], out currentPrice);

            if (mainForm.cookieCount >= currentPrice)
            {
                mainForm.cookieCount -= currentPrice;
                if (currentPrice < 4000)
                {
                    currentPrice += 500;
                }
                else if (currentPrice >= 4000)
                {
                    currentPrice += 1000;
                }

                Preis_2x.Text = currentPrice.ToString() + " 🍪";

                UpdateShopCookieCount();
                mainForm.UpdateCookieCount();


                AnzahlKäufe += 1;

                StartDoubleTimer1();
                StartDoubleTimer();
                UpdateCookiesPer();
            }


        }
        public void StartDoubleTimer()
        {
            if (AnzahlKäufe >= 1)
            {
                if (CountdownTimer == null)
                {
                    CountdownTimer = new System.Windows.Forms.Timer() { Interval = 1000 };
                    CountdownTimer.Tick += UpdateCountdown;
                }

                Countdown = 60;
                CountdownTimer.Start();
            }
        }
        public void UpdateCountdown(object sender, EventArgs e)
        {
            if (Countdown > 0)
            {
                Countdown--;
                Countdown_.Text = $"{Countdown} Sec";
            }
            else
            {
                CountdownTimer.Stop();
            }
        }
        public void StartDoubleTimer1()
        {

            if (!DoubleTimer.Enabled)
            {
                mainForm.AutoclickerEarnings *= 2;
                mainForm.CursorEarnings *= 2;

                DoubleTimer.Start();
            }

        }
        public void DoubleEarningsStop(object sender, EventArgs e)
        {
            mainForm.AutoclickerEarnings /= 2;
            mainForm.CursorEarnings /= 2;

            DoubleTimer.Stop();

        }

        public void Preis_2x_Click(object sender, EventArgs e)
        {

        }

        public void Shop_Load(object sender, EventArgs e)
        {

        }

        public void ResetUpgradePreise()
        {
            Preis_Autoklicker.Text = "500 🍪";
            Preis_Cursor.Text = "50 🍪";
            Preis_2x.Text = "1000 🍪";
        }
        public void ResetAutoclicker()
        {
            if (timer != null)
            {
                timer.Stop();
            }

        }

    }

}
