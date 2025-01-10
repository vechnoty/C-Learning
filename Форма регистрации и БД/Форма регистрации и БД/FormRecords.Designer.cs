namespace Форма_регистрации_и_БД
{
    partial class FormRecords
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
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.RecordPanel = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.upperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerPanel
            // 
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(0, 570);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(974, 33);
            this.lowerPanel.TabIndex = 0;
            // 
            // upperPanel
            // 
            this.upperPanel.Controls.Add(this.iconButton1);
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(974, 32);
            this.upperPanel.TabIndex = 1;
            // 
            // RecordPanel
            // 
            this.RecordPanel.AllowUserToAddRows = false;
            this.RecordPanel.AllowUserToDeleteRows = false;
            this.RecordPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.clientInfo});
            this.RecordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordPanel.Location = new System.Drawing.Point(0, 32);
            this.RecordPanel.Name = "RecordPanel";
            this.RecordPanel.ReadOnly = true;
            this.RecordPanel.Size = new System.Drawing.Size(974, 538);
            this.RecordPanel.TabIndex = 2;
            // 
            // time
            // 
            this.time.Frozen = true;
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 50;
            // 
            // clientInfo
            // 
            this.clientInfo.Frozen = true;
            this.clientInfo.HeaderText = "Клиент";
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.ReadOnly = true;
            this.clientInfo.Width = 1000;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(941, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 30);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 603);
            this.Controls.Add(this.RecordPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.lowerPanel);
            this.Name = "FormRecords";
            this.Text = "FormRecords";
            this.Load += new System.EventHandler(this.FormRecords_Load);
            this.upperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.DataGridView RecordPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientInfo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}