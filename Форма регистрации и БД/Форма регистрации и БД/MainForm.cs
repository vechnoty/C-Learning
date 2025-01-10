using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Форма_регистрации_и_БД
{
    public partial class MainForm : Form
    {
        private Color activeBackgroundColor = Color.FromArgb(52, 52, 52);
        private Color activeForegroundColor = Color.FromArgb(94, 148, 255);

        private Color defoultBackgroundColor = Color.FromArgb(46, 46, 50);
        private Color defoultForegroundColor = Color.FromArgb(200, 200, 200);

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private Form activeForm = null;


        private void OpenForm(Form childForm)
        {
            if(activeForm!=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetButtonColors(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void account_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);

            leftPanel1.Visible = true;

            SetButtonColors(calendar, defoultBackgroundColor, defoultForegroundColor);
            SetButtonColors(settings, defoultBackgroundColor, defoultForegroundColor);

            leftPanel2.Visible = false;
            leftPanel3.Visible = false;

            OpenForm(new PersonalAccount());
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);

            leftPanel2.Visible = true;

            SetButtonColors(account, defoultBackgroundColor, defoultForegroundColor);
            SetButtonColors(settings, defoultBackgroundColor, defoultForegroundColor);

            leftPanel1.Visible = false;
            leftPanel3.Visible = false;

            OpenForm(new FormCalendar());
        }

        private void settings_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);

            leftPanel3.Visible = true;

            SetButtonColors(calendar, defoultBackgroundColor, defoultForegroundColor);
            SetButtonColors(account, defoultBackgroundColor, defoultForegroundColor);

            leftPanel2.Visible = false;
            leftPanel1.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void WindowSize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
                WindowSize.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                WindowSize.IconChar = IconChar.WindowRestore;
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
                WindowSize.IconChar = IconChar.WindowMaximize;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                WindowSize.IconChar = IconChar.WindowRestore;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location; 
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging) 
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}
