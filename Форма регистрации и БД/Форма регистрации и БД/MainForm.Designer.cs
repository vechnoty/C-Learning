namespace Форма_регистрации_и_БД
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeWindow = new FontAwesome.Sharp.IconButton();
            this.WindowSize = new FontAwesome.Sharp.IconButton();
            this.CloseProgram = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.settings = new FontAwesome.Sharp.IconButton();
            this.leftPanel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.calendar = new FontAwesome.Sharp.IconButton();
            this.leftPanel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.account = new FontAwesome.Sharp.IconButton();
            this.leftPanel1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.MinimizeWindow);
            this.panel1.Controls.Add(this.WindowSize);
            this.panel1.Controls.Add(this.CloseProgram);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // MinimizeWindow
            // 
            this.MinimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeWindow.FlatAppearance.BorderSize = 0;
            this.MinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinimizeWindow.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeWindow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinimizeWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeWindow.IconSize = 22;
            this.MinimizeWindow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.MinimizeWindow.Location = new System.Drawing.Point(803, -1);
            this.MinimizeWindow.Name = "MinimizeWindow";
            this.MinimizeWindow.Size = new System.Drawing.Size(30, 30);
            this.MinimizeWindow.TabIndex = 3;
            this.MinimizeWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimizeWindow.UseVisualStyleBackColor = true;
            this.MinimizeWindow.Click += new System.EventHandler(this.MinimizeWindow_Click);
            // 
            // WindowSize
            // 
            this.WindowSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WindowSize.FlatAppearance.BorderSize = 0;
            this.WindowSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.WindowSize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.WindowSize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.WindowSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WindowSize.IconSize = 22;
            this.WindowSize.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.WindowSize.Location = new System.Drawing.Point(828, 0);
            this.WindowSize.Name = "WindowSize";
            this.WindowSize.Size = new System.Drawing.Size(30, 30);
            this.WindowSize.TabIndex = 3;
            this.WindowSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WindowSize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WindowSize.UseVisualStyleBackColor = true;
            this.WindowSize.Click += new System.EventHandler(this.WindowSize_Click);
            // 
            // CloseProgram
            // 
            this.CloseProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseProgram.FlatAppearance.BorderSize = 0;
            this.CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseProgram.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.CloseProgram.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseProgram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseProgram.IconSize = 25;
            this.CloseProgram.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseProgram.Location = new System.Drawing.Point(855, 0);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(30, 30);
            this.CloseProgram.TabIndex = 2;
            this.CloseProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseProgram.UseVisualStyleBackColor = true;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 524);
            this.panel2.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ExitButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 481);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(186, 43);
            this.panel10.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.ExitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.IconSize = 30;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(186, 43);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.settings);
            this.panel8.Controls.Add(this.leftPanel3);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(186, 43);
            this.panel8.TabIndex = 2;
            // 
            // settings
            // 
            this.settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.settings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.settings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settings.IconSize = 30;
            this.settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.Location = new System.Drawing.Point(6, 0);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(180, 43);
            this.settings.TabIndex = 1;
            this.settings.Text = "Найстройки";
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // leftPanel3
            // 
            this.leftPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.leftPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel3.Location = new System.Drawing.Point(0, 0);
            this.leftPanel3.Name = "leftPanel3";
            this.leftPanel3.Size = new System.Drawing.Size(6, 43);
            this.leftPanel3.TabIndex = 0;
            this.leftPanel3.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.calendar);
            this.panel6.Controls.Add(this.leftPanel2);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 43);
            this.panel6.TabIndex = 1;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.FlatAppearance.BorderSize = 0;
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.calendar.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.calendar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.calendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.calendar.IconSize = 30;
            this.calendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendar.Location = new System.Drawing.Point(6, 0);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(180, 43);
            this.calendar.TabIndex = 1;
            this.calendar.Text = "Расписание";
            this.calendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calendar.UseVisualStyleBackColor = true;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // leftPanel2
            // 
            this.leftPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.leftPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel2.Location = new System.Drawing.Point(0, 0);
            this.leftPanel2.Name = "leftPanel2";
            this.leftPanel2.Size = new System.Drawing.Size(6, 43);
            this.leftPanel2.TabIndex = 0;
            this.leftPanel2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.account);
            this.panel4.Controls.Add(this.leftPanel1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 43);
            this.panel4.TabIndex = 0;
            // 
            // account
            // 
            this.account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.account.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.account.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.account.IconSize = 30;
            this.account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account.Location = new System.Drawing.Point(6, 0);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(180, 43);
            this.account.TabIndex = 1;
            this.account.Text = "Личный кабинет";
            this.account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // leftPanel1
            // 
            this.leftPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.leftPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel1.Location = new System.Drawing.Point(0, 0);
            this.leftPanel1.Name = "leftPanel1";
            this.leftPanel1.Size = new System.Drawing.Size(6, 43);
            this.leftPanel1.TabIndex = 0;
            this.leftPanel1.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(186, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(701, 524);
            this.mainPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 556);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton account;
        private System.Windows.Forms.Panel leftPanel1;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton calendar;
        private System.Windows.Forms.Panel leftPanel2;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton settings;
        private System.Windows.Forms.Panel leftPanel3;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton CloseProgram;
        private FontAwesome.Sharp.IconButton WindowSize;
        private FontAwesome.Sharp.IconButton MinimizeWindow;
    }
}