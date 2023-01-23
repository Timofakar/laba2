namespace Графический_редактор
{
    partial class BitMap
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СоздатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnColorChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLastic = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSpray = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.tbSizeBrush = new System.Windows.Forms.TrackBar();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeBrush)).BeginInit();
            this.panelDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1668, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СоздатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // СоздатьToolStripMenuItem
            // 
            this.СоздатьToolStripMenuItem.Name = "СоздатьToolStripMenuItem";
            this.СоздатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.СоздатьToolStripMenuItem.Text = "Создать";
            this.СоздатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходКакToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // panelTools
            // 
            this.panelTools.AutoScroll = true;
            this.panelTools.Controls.Add(this.btnColorChange);
            this.panelTools.Controls.Add(this.groupBox1);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTools.Location = new System.Drawing.Point(0, 30);
            this.panelTools.Margin = new System.Windows.Forms.Padding(4);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(411, 646);
            this.panelTools.TabIndex = 1;
            // 
            // btnColorChange
            // 
            this.btnColorChange.Location = new System.Drawing.Point(13, 199);
            this.btnColorChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(145, 28);
            this.btnColorChange.TabIndex = 1;
            this.btnColorChange.Text = "Выбор цвета";
            this.btnColorChange.UseVisualStyleBackColor = true;
            this.btnColorChange.Click += new System.EventHandler(this.btnColorChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLastic);
            this.groupBox1.Controls.Add(this.btnCircle);
            this.groupBox1.Controls.Add(this.btnSpray);
            this.groupBox1.Controls.Add(this.btnSquare);
            this.groupBox1.Controls.Add(this.tbSizeBrush);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(411, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор кисти";
            // 
            // btnLastic
            // 
            this.btnLastic.Location = new System.Drawing.Point(13, 87);
            this.btnLastic.Margin = new System.Windows.Forms.Padding(4);
            this.btnLastic.Name = "btnLastic";
            this.btnLastic.Size = new System.Drawing.Size(100, 28);
            this.btnLastic.TabIndex = 4;
            this.btnLastic.Text = "Ластик";
            this.btnLastic.UseVisualStyleBackColor = true;
            this.btnLastic.Click += new System.EventHandler(this.btnLastic_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(269, 52);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(100, 28);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Круг";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnSpray
            // 
            this.btnSpray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpray.Location = new System.Drawing.Point(124, 52);
            this.btnSpray.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpray.Name = "btnSpray";
            this.btnSpray.Size = new System.Drawing.Size(137, 28);
            this.btnSpray.TabIndex = 2;
            this.btnSpray.Text = "Спрей";
            this.btnSpray.UseVisualStyleBackColor = true;
            this.btnSpray.Click += new System.EventHandler(this.btnSpray_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(16, 52);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(100, 28);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSizeBrush
            // 
            this.tbSizeBrush.AutoSize = false;
            this.tbSizeBrush.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSizeBrush.Location = new System.Drawing.Point(4, 19);
            this.tbSizeBrush.Margin = new System.Windows.Forms.Padding(4);
            this.tbSizeBrush.Maximum = 20;
            this.tbSizeBrush.MaximumSize = new System.Drawing.Size(400, 25);
            this.tbSizeBrush.Minimum = 1;
            this.tbSizeBrush.Name = "tbSizeBrush";
            this.tbSizeBrush.Size = new System.Drawing.Size(400, 25);
            this.tbSizeBrush.TabIndex = 0;
            this.tbSizeBrush.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSizeBrush.Value = 1;
            this.tbSizeBrush.Scroll += new System.EventHandler(this.tbSizeBrush_Scroll);
            // 
            // panelDraw
            // 
            this.panelDraw.AutoScroll = true;
            this.panelDraw.Controls.Add(this.pictureBox1);
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(411, 30);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(4);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1257, 646);
            this.panelDraw.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1257, 646);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_mouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // BitMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 676);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BitMap";
            this.Text = "Bitmap Picture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeBrush)).EndInit();
            this.panelDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.ToolStripMenuItem СоздатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbSizeBrush;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSpray;
        private System.Windows.Forms.Button btnChrist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnLastic;
    }
}

