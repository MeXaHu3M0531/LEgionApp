namespace LegionApp
{
    partial class RoomForm
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
            this.PBoxHanger = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PBoxWall = new System.Windows.Forms.PictureBox();
            this.PBoxMap = new System.Windows.Forms.PictureBox();
            this.ScaleUpBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScaleDowBut = new System.Windows.Forms.Button();
            this.StartBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxHanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // PBoxHanger
            // 
            this.PBoxHanger.Location = new System.Drawing.Point(12, 12);
            this.PBoxHanger.Name = "PBoxHanger";
            this.PBoxHanger.Size = new System.Drawing.Size(55, 55);
            this.PBoxHanger.TabIndex = 0;
            this.PBoxHanger.TabStop = false;
            this.PBoxHanger.Click += new System.EventHandler(this.PBoxHanger_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PBoxWall
            // 
            this.PBoxWall.Location = new System.Drawing.Point(99, 12);
            this.PBoxWall.Name = "PBoxWall";
            this.PBoxWall.Size = new System.Drawing.Size(55, 55);
            this.PBoxWall.TabIndex = 2;
            this.PBoxWall.TabStop = false;
            // 
            // PBoxMap
            // 
            this.PBoxMap.Location = new System.Drawing.Point(12, 101);
            this.PBoxMap.Name = "PBoxMap";
            this.PBoxMap.Size = new System.Drawing.Size(800, 400);
            this.PBoxMap.TabIndex = 3;
            this.PBoxMap.TabStop = false;
            // 
            // ScaleUpBut
            // 
            this.ScaleUpBut.Location = new System.Drawing.Point(644, 72);
            this.ScaleUpBut.Name = "ScaleUpBut";
            this.ScaleUpBut.Size = new System.Drawing.Size(75, 23);
            this.ScaleUpBut.TabIndex = 5;
            this.ScaleUpBut.Text = "Увеличить";
            this.ScaleUpBut.UseVisualStyleBackColor = true;
            this.ScaleUpBut.Click += new System.EventHandler(this.ScaleUpBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Подвеска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Стена";
            // 
            // ScaleDowBut
            // 
            this.ScaleDowBut.Location = new System.Drawing.Point(725, 72);
            this.ScaleDowBut.Name = "ScaleDowBut";
            this.ScaleDowBut.Size = new System.Drawing.Size(87, 23);
            this.ScaleDowBut.TabIndex = 8;
            this.ScaleDowBut.Text = "Уменьшить";
            this.ScaleDowBut.UseVisualStyleBackColor = true;
            this.ScaleDowBut.Click += new System.EventHandler(this.ScaleDowBut_Click);
            // 
            // StartBut
            // 
            this.StartBut.Location = new System.Drawing.Point(333, 72);
            this.StartBut.Name = "StartBut";
            this.StartBut.Size = new System.Drawing.Size(75, 23);
            this.StartBut.TabIndex = 9;
            this.StartBut.Text = "Старт";
            this.StartBut.UseVisualStyleBackColor = true;
            this.StartBut.Click += new System.EventHandler(this.StartBut_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.StartBut);
            this.Controls.Add(this.ScaleDowBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleUpBut);
            this.Controls.Add(this.PBoxMap);
            this.Controls.Add(this.PBoxWall);
            this.Controls.Add(this.PBoxHanger);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.PBoxHanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PBoxHanger;
        private MenuStrip menuStrip1;
        private PictureBox PBoxWall;
        private PictureBox PBoxMap;
        private Button ScaleUpBut;
        private Label label1;
        private Label label2;
        private Button ScaleDowBut;
        private double scale;
        const int dist = 25;
        private Button StartBut;
    }
}