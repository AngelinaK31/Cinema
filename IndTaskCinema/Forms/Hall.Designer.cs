namespace IndTaskCinema
{
    partial class Hall
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
            this.imgCross = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCross)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCross
            // 
            this.imgCross.BackgroundImage = global::IndTaskCinema.Properties.Resources.cross;
            this.imgCross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCross.Location = new System.Drawing.Point(660, 1);
            this.imgCross.Name = "imgCross";
            this.imgCross.Size = new System.Drawing.Size(24, 25);
            this.imgCross.TabIndex = 0;
            this.imgCross.TabStop = false;
            this.imgCross.Click += new System.EventHandler(this.imgCrossClick);
            // 
            // Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IndTaskCinema.Properties.Resources.hall1;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.imgCross);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(686, 450);
            this.MinimumSize = new System.Drawing.Size(686, 450);
            this.Name = "Hall";
            this.Text = "Hall";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HallMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HallMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCross;
    }
}