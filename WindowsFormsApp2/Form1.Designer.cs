namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.эПДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.статусыЭПДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эПДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнаяВводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интеграцияС1СToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интеграцияСДругимиФорматамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эСИСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнойВводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиБазаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эПДToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // эПДToolStripMenuItem
            // 
            this.эПДToolStripMenuItem.Name = "эПДToolStripMenuItem";
            this.эПДToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.эПДToolStripMenuItem.Text = "ЭПД";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статусыЭПДToolStripMenuItem,
            this.эПДToolStripMenuItem1,
            this.эСИСToolStripMenuItem,
            this.подписаниеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.настройкиБазаДанныхToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // статусыЭПДToolStripMenuItem
            // 
            this.статусыЭПДToolStripMenuItem.Name = "статусыЭПДToolStripMenuItem";
            this.статусыЭПДToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.статусыЭПДToolStripMenuItem.Text = "Статусы ЭПД";
            // 
            // эПДToolStripMenuItem1
            // 
            this.эПДToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ручнаяВводToolStripMenuItem,
            this.интеграцияС1СToolStripMenuItem,
            this.интеграцияСДругимиФорматамиToolStripMenuItem});
            this.эПДToolStripMenuItem1.Name = "эПДToolStripMenuItem1";
            this.эПДToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.эПДToolStripMenuItem1.Text = "ЭПД";
            // 
            // ручнаяВводToolStripMenuItem
            // 
            this.ручнаяВводToolStripMenuItem.Name = "ручнаяВводToolStripMenuItem";
            this.ручнаяВводToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.ручнаяВводToolStripMenuItem.Text = "Ручной ввод";
            this.ручнаяВводToolStripMenuItem.Click += new System.EventHandler(this.ручнаяВводToolStripMenuItem_Click);
            // 
            // интеграцияС1СToolStripMenuItem
            // 
            this.интеграцияС1СToolStripMenuItem.Name = "интеграцияС1СToolStripMenuItem";
            this.интеграцияС1СToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.интеграцияС1СToolStripMenuItem.Text = "Обработка формата 1С";
            // 
            // интеграцияСДругимиФорматамиToolStripMenuItem
            // 
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Name = "интеграцияСДругимиФорматамиToolStripMenuItem";
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Text = "Обработка Swift";
            // 
            // эСИСToolStripMenuItem
            // 
            this.эСИСToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ручнойВводToolStripMenuItem,
            this.автоматическийToolStripMenuItem});
            this.эСИСToolStripMenuItem.Name = "эСИСToolStripMenuItem";
            this.эСИСToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.эСИСToolStripMenuItem.Text = "ЭСИС";
            // 
            // ручнойВводToolStripMenuItem
            // 
            this.ручнойВводToolStripMenuItem.Name = "ручнойВводToolStripMenuItem";
            this.ручнойВводToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ручнойВводToolStripMenuItem.Text = "Ручной ввод";
            this.ручнойВводToolStripMenuItem.Click += new System.EventHandler(this.ручнойВводToolStripMenuItem_Click);
            // 
            // автоматическийToolStripMenuItem
            // 
            this.автоматическийToolStripMenuItem.Name = "автоматическийToolStripMenuItem";
            this.автоматическийToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.автоматическийToolStripMenuItem.Text = "Автоматический";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Location = new System.Drawing.Point(37, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1075, 451);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Созданные",
            "Полученные"});
            this.comboBox1.Location = new System.Drawing.Point(37, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Обновить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Параметры поиска";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки сохранения";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // настройкиБазаДанныхToolStripMenuItem
            // 
            this.настройкиБазаДанныхToolStripMenuItem.Name = "настройкиБазаДанныхToolStripMenuItem";
            this.настройкиБазаДанныхToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.настройкиБазаДанныхToolStripMenuItem.Text = "Настройки база данных";
            this.настройкиБазаДанныхToolStripMenuItem.Click += new System.EventHandler(this.настройкиБазаДанныхToolStripMenuItem_Click);
            // 
            // подписаниеToolStripMenuItem
            // 
            this.подписаниеToolStripMenuItem.Name = "подписаниеToolStripMenuItem";
            this.подписаниеToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.подписаниеToolStripMenuItem.Text = "Подписание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Передатчик ПС БР";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem эПДToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem эПДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem эСИСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЭПДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнаяВводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интеграцияС1СToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интеграцияСДругимиФорматамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнойВводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоматическийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
       
      
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиБазаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подписаниеToolStripMenuItem;
    }
}

