namespace IndTaskCinema
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lHello = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAboutProg = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHello
            // 
            this.lHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lHello.AutoSize = true;
            this.lHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHello.Location = new System.Drawing.Point(12, 95);
            this.lHello.MaximumSize = new System.Drawing.Size(548, 40);
            this.lHello.MinimumSize = new System.Drawing.Size(548, 40);
            this.lHello.Name = "lHello";
            this.lHello.Size = new System.Drawing.Size(548, 40);
            this.lHello.TabIndex = 0;
            this.lHello.Text = "Здравствуйте! \r\nВас приветствует програма для заказа билетов в кинотеатр \"Аврора\"" +
    "";
            this.lHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(148, 165);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(278, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Приступить к оформлению";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStartClick);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(483, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // btnAboutProg
            // 
            this.btnAboutProg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutProg.Location = new System.Drawing.Point(12, 12);
            this.btnAboutProg.Name = "btnAboutProg";
            this.btnAboutProg.Size = new System.Drawing.Size(91, 23);
            this.btnAboutProg.TabIndex = 3;
            this.btnAboutProg.Text = "О программе";
            this.btnAboutProg.UseVisualStyleBackColor = true;
            this.btnAboutProg.Click += new System.EventHandler(this.btnAboutProgClick);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl.Controls.Add(this.btnExit);
            this.pnl.Controls.Add(this.btnAboutProg);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(570, 47);
            this.pnl.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 251);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lHello);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(586, 290);
            this.MinimumSize = new System.Drawing.Size(586, 290);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кинотеатр \"Аврора\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePageClosed);
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHello;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAboutProg;
        private System.Windows.Forms.Panel pnl;
    }
}

