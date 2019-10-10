namespace oop3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.redColor = new System.Windows.Forms.ToolStripMenuItem();
            this.greenColor = new System.Windows.Forms.ToolStripMenuItem();
            this.жёлтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(13, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 310);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеToolStripMenuItem,
            this.цветаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главноеToolStripMenuItem
            // 
            this.главноеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.главноеToolStripMenuItem.Name = "главноеToolStripMenuItem";
            this.главноеToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.главноеToolStripMenuItem.Text = "Главное";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.btnClearClick);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.btnExitClick);
            // 
            // цветаToolStripMenuItem
            // 
            this.цветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackColor,
            this.redColor,
            this.greenColor,
            this.жёлтыйToolStripMenuItem});
            this.цветаToolStripMenuItem.Name = "цветаToolStripMenuItem";
            this.цветаToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.цветаToolStripMenuItem.Text = "Цвета";
            // 
            // blackColor
            // 
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(224, 26);
            this.blackColor.Text = "Чёрный";
            this.blackColor.Click += new System.EventHandler(this.btnChangeColor);
            // 
            // redColor
            // 
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(224, 26);
            this.redColor.Text = "Красный";
            this.redColor.Click += new System.EventHandler(this.btnChangeColor);
            // 
            // greenColor
            // 
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(224, 26);
            this.greenColor.Text = "Зелёный";
            this.greenColor.Click += new System.EventHandler(this.btnChangeColor);
            // 
            // жёлтыйToolStripMenuItem
            // 
            this.жёлтыйToolStripMenuItem.Name = "жёлтыйToolStripMenuItem";
            this.жёлтыйToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.жёлтыйToolStripMenuItem.Text = "Жёлтый";
            this.жёлтыйToolStripMenuItem.Click += new System.EventHandler(this.btnChangeColor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackColor;
        private System.Windows.Forms.ToolStripMenuItem redColor;
        private System.Windows.Forms.ToolStripMenuItem greenColor;
        private System.Windows.Forms.ToolStripMenuItem жёлтыйToolStripMenuItem;
    }
}

