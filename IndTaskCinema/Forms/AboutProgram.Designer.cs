namespace IndTaskCinema
{
    partial class AboutProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgram));
            this.lAboutProg = new System.Windows.Forms.Label();
            this.lAbout = new System.Windows.Forms.Label();
            this.lVersoin = new System.Windows.Forms.Label();
            this.lDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lAboutProg
            // 
            this.lAboutProg.AutoSize = true;
            this.lAboutProg.Location = new System.Drawing.Point(43, 39);
            this.lAboutProg.Name = "lAboutProg";
            this.lAboutProg.Size = new System.Drawing.Size(407, 13);
            this.lAboutProg.TabIndex = 0;
            this.lAboutProg.Text = "Данная программа предназначена для заказа билетов в кинотеатр \"Аврора\".";
            // 
            // lAbout
            // 
            this.lAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lAbout.AutoSize = true;
            this.lAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAbout.Location = new System.Drawing.Point(186, 9);
            this.lAbout.Name = "lAbout";
            this.lAbout.Size = new System.Drawing.Size(119, 20);
            this.lAbout.TabIndex = 1;
            this.lAbout.Text = "О программе";
            this.lAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVersoin
            // 
            this.lVersoin.AutoSize = true;
            this.lVersoin.Location = new System.Drawing.Point(43, 61);
            this.lVersoin.Name = "lVersoin";
            this.lVersoin.Size = new System.Drawing.Size(65, 13);
            this.lVersoin.TabIndex = 2;
            this.lVersoin.Text = "Версия: 1.1";
            // 
            // lDeveloper
            // 
            this.lDeveloper.AutoSize = true;
            this.lDeveloper.Location = new System.Drawing.Point(43, 83);
            this.lDeveloper.Name = "lDeveloper";
            this.lDeveloper.Size = new System.Drawing.Size(178, 13);
            this.lDeveloper.TabIndex = 3;
            this.lDeveloper.Text = "Разработчик: Калинина Ангелина";
            // 
            // AboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 128);
            this.Controls.Add(this.lDeveloper);
            this.Controls.Add(this.lVersoin);
            this.Controls.Add(this.lAbout);
            this.Controls.Add(this.lAboutProg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(503, 167);
            this.MinimumSize = new System.Drawing.Size(503, 167);
            this.Name = "AboutProgram";
            this.Text = "Кинотеатр \"Аврора\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAboutProg;
        private System.Windows.Forms.Label lAbout;
        private System.Windows.Forms.Label lVersoin;
        private System.Windows.Forms.Label lDeveloper;
    }
}