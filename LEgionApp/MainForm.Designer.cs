namespace LEgionApp
{
    partial class TablForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьСхемуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьШаблонПодвескиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggerHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggerShortID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggerNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxHum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinHum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangerNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.создатьToolStripMenuItem.Text = "Создать...";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.печатьToolStripMenuItem.Text = "Печать...";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьСхемуToolStripMenuItem,
            this.открытьШаблонПодвескиToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // открытьСхемуToolStripMenuItem
            // 
            this.открытьСхемуToolStripMenuItem.Name = "открытьСхемуToolStripMenuItem";
            this.открытьСхемуToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.открытьСхемуToolStripMenuItem.Text = "Открыть схему";
            this.открытьСхемуToolStripMenuItem.Click += new System.EventHandler(this.открытьСхемуToolStripMenuItem_Click);
            // 
            // открытьШаблонПодвескиToolStripMenuItem
            // 
            this.открытьШаблонПодвескиToolStripMenuItem.Name = "открытьШаблонПодвескиToolStripMenuItem";
            this.открытьШаблонПодвескиToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.открытьШаблонПодвескиToolStripMenuItem.Text = "Открыть шаблон подвески";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.LoggerType,
            this.LoggerHeight,
            this.dataGridViewTextBoxColumn2,
            this.LoggerID,
            this.LoggerShortID,
            this.MaxT,
            this.MinT,
            this.AverageT,
            this.MaxH,
            this.MinH,
            this.AverageH,
            this.LimMin,
            this.LimMax});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Подвеска";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // LoggerType
            // 
            this.LoggerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoggerType.HeaderText = "Тип логгера";
            this.LoggerType.Name = "LoggerType";
            this.LoggerType.Width = 90;
            // 
            // LoggerHeight
            // 
            this.LoggerHeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoggerHeight.HeaderText = "Высота";
            this.LoggerHeight.Name = "LoggerHeight";
            this.LoggerHeight.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // LoggerID
            // 
            this.LoggerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoggerID.HeaderText = "ID";
            this.LoggerID.Name = "LoggerID";
            this.LoggerID.Width = 43;
            // 
            // LoggerShortID
            // 
            this.LoggerShortID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoggerShortID.HeaderText = "Short ID";
            this.LoggerShortID.Name = "LoggerShortID";
            this.LoggerShortID.Width = 69;
            // 
            // MaxT
            // 
            this.MaxT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaxT.HeaderText = "Макс. Т.";
            this.MaxT.Name = "MaxT";
            this.MaxT.Width = 70;
            // 
            // MinT
            // 
            this.MinT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinT.HeaderText = "Мин. Т.";
            this.MinT.Name = "MinT";
            this.MinT.Width = 67;
            // 
            // AverageT
            // 
            this.AverageT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AverageT.HeaderText = "Ср. Т.";
            this.AverageT.Name = "AverageT";
            this.AverageT.Width = 50;
            // 
            // MaxH
            // 
            this.MaxH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaxH.HeaderText = "Макс. Вл.";
            this.MaxH.Name = "MaxH";
            this.MaxH.Width = 78;
            // 
            // MinH
            // 
            this.MinH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinH.HeaderText = "Мин. Вл.";
            this.MinH.Name = "MinH";
            this.MinH.Width = 74;
            // 
            // AverageH
            // 
            this.AverageH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AverageH.HeaderText = "Ср. Вл.";
            this.AverageH.Name = "AverageH";
            this.AverageH.Width = 50;
            // 
            // LimMin
            // 
            this.LimMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LimMin.HeaderText = "Нижний  порог";
            this.LimMin.Name = "LimMin";
            this.LimMin.Width = 78;
            // 
            // LimMax
            // 
            this.LimMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LimMax.HeaderText = "Верхний порог";
            this.LimMax.Name = "LimMax";
            this.LimMax.Width = 106;
            // 
            // Num
            // 
            this.Num.HeaderText = "Подвеска";
            this.Num.Name = "Num";
            // 
            // LoggerNum
            // 
            this.LoggerNum.HeaderText = "Регистратор";
            this.LoggerNum.Name = "LoggerNum";
            // 
            // Hight
            // 
            this.Hight.HeaderText = "Высота";
            this.Hight.Name = "Hight";
            // 
            // MaxTemp
            // 
            this.MaxTemp.HeaderText = "Макс. темп.";
            this.MaxTemp.Name = "MaxTemp";
            // 
            // MinTemp
            // 
            this.MinTemp.HeaderText = "Мин. темп.";
            this.MinTemp.Name = "MinTemp";
            // 
            // Average
            // 
            this.Average.HeaderText = "Ср. темп.";
            this.Average.Name = "Average";
            // 
            // MaxHum
            // 
            this.MaxHum.HeaderText = "Макс. вл.";
            this.MaxHum.Name = "MaxHum";
            // 
            // MinHum
            // 
            this.MinHum.HeaderText = "Мин. вл.";
            this.MinHum.Name = "MinHum";
            // 
            // HangerNum
            // 
            this.HangerNum.HeaderText = "Подвеска";
            this.HangerNum.Name = "HangerNum";
            // 
            // TablForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 579);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TablForm";
            this.Text = "LegionApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem открытьСхемуToolStripMenuItem;
        private ToolStripMenuItem открытьШаблонПодвескиToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn LoggerNum;
        private DataGridViewTextBoxColumn Hight;
        private DataGridViewTextBoxColumn MaxTemp;
        private DataGridViewTextBoxColumn MinTemp;
        private DataGridViewTextBoxColumn Average;
        private DataGridViewTextBoxColumn MaxHum;
        private DataGridViewTextBoxColumn MinHum;
        private DataGridViewTextBoxColumn HangerNum;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn LoggerType;
        private DataGridViewTextBoxColumn LoggerHeight;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn LoggerID;
        private DataGridViewTextBoxColumn LoggerShortID;
        private DataGridViewTextBoxColumn MaxT;
        private DataGridViewTextBoxColumn MinT;
        private DataGridViewTextBoxColumn AverageT;
        private DataGridViewTextBoxColumn MaxH;
        private DataGridViewTextBoxColumn MinH;
        private DataGridViewTextBoxColumn AverageH;
        private DataGridViewTextBoxColumn LimMin;
        private DataGridViewTextBoxColumn LimMax;
    }
}