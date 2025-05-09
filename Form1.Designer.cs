namespace Cookie_Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_cookie = new Button();
            cookies_count = new Label();
            button1 = new Button();
            Save_button = new Button();
            Load_Button = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button_cookie
            // 
            button_cookie.BackColor = Color.Transparent;
            button_cookie.Cursor = Cursors.Hand;
            button_cookie.FlatStyle = FlatStyle.Popup;
            button_cookie.Image = Properties.Resources.image1001890_removebg_preview;
            button_cookie.Location = new Point(179, 137);
            button_cookie.Name = "button_cookie";
            button_cookie.RightToLeft = RightToLeft.No;
            button_cookie.Size = new Size(273, 282);
            button_cookie.TabIndex = 0;
            button_cookie.UseVisualStyleBackColor = false;
            button_cookie.Click += button_cookie_Click;
            // 
            // cookies_count
            // 
            cookies_count.AutoSize = true;
            cookies_count.BackColor = Color.Transparent;
            cookies_count.Font = new Font("Rockwell Extra Bold", 19F, FontStyle.Bold);
            cookies_count.ForeColor = Color.Black;
            cookies_count.Location = new Point(202, 42);
            cookies_count.Name = "cookies_count";
            cookies_count.Size = new Size(226, 45);
            cookies_count.TabIndex = 2;
            cookies_count.Text = "Cookies: ";
            cookies_count.Click += cookies_count_Click;
            // 
            // button1
            // 
            button1.Location = new Point(790, 116);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Save_button
            // 
            Save_button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save_button.Location = new Point(-1, -1);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(163, 41);
            Save_button.TabIndex = 5;
            Save_button.Text = "SAVE GAME";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_button_Click;
            // 
            // Load_Button
            // 
            Load_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Load_Button.Location = new Point(-1, 42);
            Load_Button.Name = "Load_Button";
            Load_Button.Size = new Size(163, 41);
            Load_Button.TabIndex = 6;
            Load_Button.Text = "LOAD GAME";
            Load_Button.UseVisualStyleBackColor = true;
            Load_Button.Click += Load_Button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(-1, 85);
            button3.Name = "button3";
            button3.Size = new Size(163, 41);
            button3.TabIndex = 7;
            button3.Text = "RESET RUN";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.simple_background_textured_wood_texture_wallpaper_preview;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(659, 450);
            Controls.Add(button3);
            Controls.Add(Load_Button);
            Controls.Add(Save_button);
            Controls.Add(button1);
            Controls.Add(cookies_count);
            Controls.Add(button_cookie);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cookie;
        private Label cookies_count;
        private Button button1;
        private Button Save_button;
        private Button Load_Button;
        private Button button3;
    }
}
