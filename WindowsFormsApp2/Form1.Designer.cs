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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.статусыЭПДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправленныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эПДToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнаяВводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнойВводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интеграцияС1СToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.интеграцияСДругимиФорматамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эСИСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eD999ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВED101ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВED501СПФСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитВMT101SwiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиБазаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статусыЭПДToolStripMenuItem,
            this.эПДToolStripMenuItem1,
            this.эСИСToolStripMenuItem,
            this.toolStripMenuItem1,
            this.подписаниеToolStripMenuItem,
            this.настройкиБазаДанныхToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.toolStripMenuItem2,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // статусыЭПДToolStripMenuItem
            // 
            this.статусыЭПДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданныеToolStripMenuItem,
            this.отправленныеToolStripMenuItem});
            this.статусыЭПДToolStripMenuItem.Name = "статусыЭПДToolStripMenuItem";
            this.статусыЭПДToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.статусыЭПДToolStripMenuItem.Text = "Статусы ЭПД";
            this.статусыЭПДToolStripMenuItem.Click += new System.EventHandler(this.статусыЭПДToolStripMenuItem_Click);
            // 
            // созданныеToolStripMenuItem
            // 
            this.созданныеToolStripMenuItem.Name = "созданныеToolStripMenuItem";
            this.созданныеToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.созданныеToolStripMenuItem.Text = "Созданные";
            this.созданныеToolStripMenuItem.Click += new System.EventHandler(this.созданныеToolStripMenuItem_Click);
            // 
            // отправленныеToolStripMenuItem
            // 
            this.отправленныеToolStripMenuItem.Name = "отправленныеToolStripMenuItem";
            this.отправленныеToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.отправленныеToolStripMenuItem.Text = "Принятые";
            this.отправленныеToolStripMenuItem.Click += new System.EventHandler(this.отправленныеToolStripMenuItem_Click);
            // 
            // эПДToolStripMenuItem1
            // 
            this.эПДToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ручнаяВводToolStripMenuItem,
            this.ручнойВводToolStripMenuItem,
            this.интеграцияС1СToolStripMenuItem,
            this.интеграцияСДругимиФорматамиToolStripMenuItem});
            this.эПДToolStripMenuItem1.Name = "эПДToolStripMenuItem1";
            this.эПДToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.эПДToolStripMenuItem1.Text = "ЭПД";
            // 
            // ручнаяВводToolStripMenuItem
            // 
            this.ручнаяВводToolStripMenuItem.Name = "ручнаяВводToolStripMenuItem";
            this.ручнаяВводToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.ручнаяВводToolStripMenuItem.Text = "Ручной ввод (автозаполнение)";
            this.ручнаяВводToolStripMenuItem.Click += new System.EventHandler(this.ручнаяВводToolStripMenuItem_Click);
            // 
            // ручнойВводToolStripMenuItem
            // 
            this.ручнойВводToolStripMenuItem.Name = "ручнойВводToolStripMenuItem";
            this.ручнойВводToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.ручнойВводToolStripMenuItem.Text = "Ручной ввод";
            this.ручнойВводToolStripMenuItem.Click += new System.EventHandler(this.ручнойВводToolStripMenuItem_Click_1);
            // 
            // интеграцияС1СToolStripMenuItem
            // 
            this.интеграцияС1СToolStripMenuItem.Name = "интеграцияС1СToolStripMenuItem";
            this.интеграцияС1СToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.интеграцияС1СToolStripMenuItem.Text = "Обработка формата 1С";
            this.интеграцияС1СToolStripMenuItem.Visible = false;
            // 
            // интеграцияСДругимиФорматамиToolStripMenuItem
            // 
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Name = "интеграцияСДругимиФорматамиToolStripMenuItem";
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Text = "Обработка Swift";
            this.интеграцияСДругимиФорматамиToolStripMenuItem.Visible = false;
            // 
            // эСИСToolStripMenuItem
            // 
            this.эСИСToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eD999ToolStripMenuItem});
            this.эСИСToolStripMenuItem.Name = "эСИСToolStripMenuItem";
            this.эСИСToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.эСИСToolStripMenuItem.Text = "ЭСИС";
            this.эСИСToolStripMenuItem.Visible = false;
            // 
            // eD999ToolStripMenuItem
            // 
            this.eD999ToolStripMenuItem.Name = "eD999ToolStripMenuItem";
            this.eD999ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.eD999ToolStripMenuItem.Text = "ED999";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВPdfToolStripMenuItem,
            this.сохранитьВED101ToolStripMenuItem,
            this.сохранитьВED501СПФСToolStripMenuItem,
            this.сохранитВMT101SwiftToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Сохранить";
            this.toolStripMenuItem1.Visible = false;
            // 
            // сохранитьВPdfToolStripMenuItem
            // 
            this.сохранитьВPdfToolStripMenuItem.Name = "сохранитьВPdfToolStripMenuItem";
            this.сохранитьВPdfToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.сохранитьВPdfToolStripMenuItem.Text = "Сохранить в pdf";
            this.сохранитьВPdfToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВPdfToolStripMenuItem_Click);
            // 
            // сохранитьВED101ToolStripMenuItem
            // 
            this.сохранитьВED101ToolStripMenuItem.Name = "сохранитьВED101ToolStripMenuItem";
            this.сохранитьВED101ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.сохранитьВED101ToolStripMenuItem.Text = "Сохранить в ED101";
            // 
            // сохранитьВED501СПФСToolStripMenuItem
            // 
            this.сохранитьВED501СПФСToolStripMenuItem.Name = "сохранитьВED501СПФСToolStripMenuItem";
            this.сохранитьВED501СПФСToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.сохранитьВED501СПФСToolStripMenuItem.Text = "Сохранить в ED501 (СПФС)";
            // 
            // сохранитВMT101SwiftToolStripMenuItem
            // 
            this.сохранитВMT101SwiftToolStripMenuItem.Name = "сохранитВMT101SwiftToolStripMenuItem";
            this.сохранитВMT101SwiftToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.сохранитВMT101SwiftToolStripMenuItem.Text = "Сохранит в MT101 (Swift)";
            // 
            // подписаниеToolStripMenuItem
            // 
            this.подписаниеToolStripMenuItem.Name = "подписаниеToolStripMenuItem";
            this.подписаниеToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.подписаниеToolStripMenuItem.Text = "Подписание";
            this.подписаниеToolStripMenuItem.Visible = false;
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem2.Text = "Настройки";
            this.toolStripMenuItem2.Visible = false;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Visible = false;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(185, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Текущий операционный день";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(307, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Отображать документы за все дни";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 578);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Передатчик ПС БР";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem эПДToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem эСИСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыЭПДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнаяВводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интеграцияС1СToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem интеграцияСДругимиФорматамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиБазаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подписаниеToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem созданныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправленныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВED101ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВED501СПФСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитВMT101SwiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eD999ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнойВводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

