namespace IndTaskCinema
{
    partial class SelectPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPlace));
            this.pnlTicket = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lPlace = new System.Windows.Forms.Label();
            this.lRow = new System.Windows.Forms.Label();
            this.lHall = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lFilm = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelHall = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            this.lTicket = new System.Windows.Forms.Label();
            this.comboBoxRows = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaces = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lChoose = new System.Windows.Forms.Label();
            this.lChooseRow = new System.Windows.Forms.Label();
            this.lChoosePlace = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imgHall = new System.Windows.Forms.PictureBox();
            this.pnlTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHall)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTicket
            // 
            this.pnlTicket.BackColor = System.Drawing.Color.Moccasin;
            this.pnlTicket.Controls.Add(this.btnContinue);
            this.pnlTicket.Controls.Add(this.lPlace);
            this.pnlTicket.Controls.Add(this.lRow);
            this.pnlTicket.Controls.Add(this.lHall);
            this.pnlTicket.Controls.Add(this.lTime);
            this.pnlTicket.Controls.Add(this.lDate);
            this.pnlTicket.Controls.Add(this.lFilm);
            this.pnlTicket.Controls.Add(this.labelRow);
            this.pnlTicket.Controls.Add(this.labelPlace);
            this.pnlTicket.Controls.Add(this.labelHall);
            this.pnlTicket.Controls.Add(this.labelTime);
            this.pnlTicket.Controls.Add(this.labelData);
            this.pnlTicket.Controls.Add(this.labelFilm);
            this.pnlTicket.Controls.Add(this.lTicket);
            this.pnlTicket.Location = new System.Drawing.Point(405, 67);
            this.pnlTicket.Name = "pnlTicket";
            this.pnlTicket.Size = new System.Drawing.Size(188, 284);
            this.pnlTicket.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(34, 216);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(112, 42);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinueClick);
            // 
            // lPlace
            // 
            this.lPlace.AutoSize = true;
            this.lPlace.Location = new System.Drawing.Point(80, 174);
            this.lPlace.Name = "lPlace";
            this.lPlace.Size = new System.Drawing.Size(40, 13);
            this.lPlace.TabIndex = 12;
            this.lPlace.Text = "(Place)";
            this.lPlace.Visible = false;
            // 
            // lRow
            // 
            this.lRow.AutoSize = true;
            this.lRow.Location = new System.Drawing.Point(80, 144);
            this.lRow.Name = "lRow";
            this.lRow.Size = new System.Drawing.Size(35, 13);
            this.lRow.TabIndex = 11;
            this.lRow.Text = "(Row)";
            this.lRow.Visible = false;
            // 
            // lHall
            // 
            this.lHall.AutoSize = true;
            this.lHall.Location = new System.Drawing.Point(80, 115);
            this.lHall.Name = "lHall";
            this.lHall.Size = new System.Drawing.Size(13, 13);
            this.lHall.TabIndex = 10;
            this.lHall.Text = "1";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(80, 91);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(36, 13);
            this.lTime.TabIndex = 9;
            this.lTime.Text = "(Time)";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(80, 65);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(36, 13);
            this.lDate.TabIndex = 8;
            this.lDate.Text = "(Date)";
            // 
            // lFilm
            // 
            this.lFilm.AutoSize = true;
            this.lFilm.Location = new System.Drawing.Point(80, 41);
            this.lFilm.Name = "lFilm";
            this.lFilm.Size = new System.Drawing.Size(31, 13);
            this.lFilm.TabIndex = 7;
            this.lFilm.Text = "(Film)";
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRow.Location = new System.Drawing.Point(14, 144);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(32, 15);
            this.labelRow.TabIndex = 6;
            this.labelRow.Text = "Ряд:";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(14, 172);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(48, 15);
            this.labelPlace.TabIndex = 5;
            this.labelPlace.Text = "Место:";
            // 
            // labelHall
            // 
            this.labelHall.AutoSize = true;
            this.labelHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHall.Location = new System.Drawing.Point(14, 115);
            this.labelHall.Name = "labelHall";
            this.labelHall.Size = new System.Drawing.Size(32, 15);
            this.labelHall.TabIndex = 4;
            this.labelHall.Text = "Зал:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(14, 90);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(48, 15);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Время:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(14, 65);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(40, 15);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Дата:";
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilm.Location = new System.Drawing.Point(14, 41);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(51, 15);
            this.labelFilm.TabIndex = 1;
            this.labelFilm.Text = "Фильм:";
            // 
            // lTicket
            // 
            this.lTicket.AutoSize = true;
            this.lTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTicket.Location = new System.Drawing.Point(14, 9);
            this.lTicket.Name = "lTicket";
            this.lTicket.Size = new System.Drawing.Size(52, 17);
            this.lTicket.TabIndex = 0;
            this.lTicket.Text = "Билет:";
            // 
            // comboBoxRows
            // 
            this.comboBoxRows.FormattingEnabled = true;
            this.comboBoxRows.Location = new System.Drawing.Point(66, 45);
            this.comboBoxRows.Name = "comboBoxRows";
            this.comboBoxRows.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRows.TabIndex = 2;
            this.comboBoxRows.SelectedIndexChanged += new System.EventHandler(this.comboBoxRowsSelectedIndexChanged);
            // 
            // comboBoxPlaces
            // 
            this.comboBoxPlaces.FormattingEnabled = true;
            this.comboBoxPlaces.Location = new System.Drawing.Point(66, 72);
            this.comboBoxPlaces.Name = "comboBoxPlaces";
            this.comboBoxPlaces.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlaces.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(485, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(405, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // lChoose
            // 
            this.lChoose.AutoSize = true;
            this.lChoose.Location = new System.Drawing.Point(15, 12);
            this.lChoose.Name = "lChoose";
            this.lChoose.Size = new System.Drawing.Size(94, 13);
            this.lChoose.TabIndex = 6;
            this.lChoose.Text = "Выберите место:";
            // 
            // lChooseRow
            // 
            this.lChooseRow.AutoSize = true;
            this.lChooseRow.Location = new System.Drawing.Point(15, 48);
            this.lChooseRow.Name = "lChooseRow";
            this.lChooseRow.Size = new System.Drawing.Size(29, 13);
            this.lChooseRow.TabIndex = 7;
            this.lChooseRow.Text = "Ряд:";
            // 
            // lChoosePlace
            // 
            this.lChoosePlace.AutoSize = true;
            this.lChoosePlace.Location = new System.Drawing.Point(15, 75);
            this.lChoosePlace.Name = "lChoosePlace";
            this.lChoosePlace.Size = new System.Drawing.Size(42, 13);
            this.lChoosePlace.TabIndex = 8;
            this.lChoosePlace.Text = "Место:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // imgHall
            // 
            this.imgHall.BackgroundImage = global::IndTaskCinema.Properties.Resources.hall1;
            this.imgHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHall.Location = new System.Drawing.Point(12, 121);
            this.imgHall.Name = "imgHall";
            this.imgHall.Size = new System.Drawing.Size(379, 204);
            this.imgHall.TabIndex = 9;
            this.imgHall.TabStop = false;
            this.imgHall.Click += new System.EventHandler(this.imgHallClick);
            // 
            // SelectPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 331);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.imgHall);
            this.Controls.Add(this.lChoosePlace);
            this.Controls.Add(this.lChooseRow);
            this.Controls.Add(this.lChoose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.comboBoxPlaces);
            this.Controls.Add(this.comboBoxRows);
            this.Controls.Add(this.pnlTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(588, 370);
            this.MinimumSize = new System.Drawing.Size(588, 370);
            this.Name = "SelectPlace";
            this.Text = "Кинотеатр \"Аврора\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectPLaceClosed);
            this.pnlTicket.ResumeLayout(false);
            this.pnlTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTicket;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label lTicket;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelHall;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboBoxRows;
        private System.Windows.Forms.ComboBox comboBoxPlaces;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lChoose;
        private System.Windows.Forms.Label lChooseRow;
        private System.Windows.Forms.Label lChoosePlace;
        private System.Windows.Forms.PictureBox imgHall;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lFilm;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lHall;
        private System.Windows.Forms.Label lPlace;
        private System.Windows.Forms.Label lRow;
        private System.Windows.Forms.Button btnContinue;
    }
}