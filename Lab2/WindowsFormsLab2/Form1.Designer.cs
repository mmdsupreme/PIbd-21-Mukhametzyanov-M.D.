namespace WindowsFormsLab2
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
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaxCountPassenget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxFrontSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxBackSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxSideSpoiler = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonSetAuto = new System.Windows.Forms.Button();
            this.buttonSetSportCar = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.Location = new System.Drawing.Point(69, 32);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(563, 313);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Максимальная скорость";
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(170, 393);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(75, 20);
            this.textBoxMaxSpeed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимальное кол-во пассажиров";
            // 
            // textBoxMaxCountPassenget
            // 
            this.textBoxMaxCountPassenget.Location = new System.Drawing.Point(194, 428);
            this.textBoxMaxCountPassenget.Name = "textBoxMaxCountPassenget";
            this.textBoxMaxCountPassenget.Size = new System.Drawing.Size(74, 20);
            this.textBoxMaxCountPassenget.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кол-во лошадиных сил";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цвет";
            // 
            // checkBoxFrontSpoiler
            // 
            this.checkBoxFrontSpoiler.AutoSize = true;
            this.checkBoxFrontSpoiler.Location = new System.Drawing.Point(517, 351);
            this.checkBoxFrontSpoiler.Name = "checkBoxFrontSpoiler";
            this.checkBoxFrontSpoiler.Size = new System.Drawing.Size(79, 17);
            this.checkBoxFrontSpoiler.TabIndex = 7;
            this.checkBoxFrontSpoiler.Text = "suspension";
            this.checkBoxFrontSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackSpoiler
            // 
            this.checkBoxBackSpoiler.AutoSize = true;
            this.checkBoxBackSpoiler.Location = new System.Drawing.Point(602, 374);
            this.checkBoxBackSpoiler.Name = "checkBoxBackSpoiler";
            this.checkBoxBackSpoiler.Size = new System.Drawing.Size(61, 17);
            this.checkBoxBackSpoiler.TabIndex = 8;
            this.checkBoxBackSpoiler.Text = "reserve";
            this.checkBoxBackSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxSideSpoiler
            // 
            this.checkBoxSideSpoiler.AutoSize = true;
            this.checkBoxSideSpoiler.Location = new System.Drawing.Point(602, 351);
            this.checkBoxSideSpoiler.Name = "checkBoxSideSpoiler";
            this.checkBoxSideSpoiler.Size = new System.Drawing.Size(87, 17);
            this.checkBoxSideSpoiler.TabIndex = 9;
            this.checkBoxSideSpoiler.Text = "Exhaust pipe";
            this.checkBoxSideSpoiler.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(406, 389);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(66, 20);
            this.textBoxWeight.TabIndex = 11;
            // 
            // buttonSetAuto
            // 
            this.buttonSetAuto.Location = new System.Drawing.Point(204, 455);
            this.buttonSetAuto.Name = "buttonSetAuto";
            this.buttonSetAuto.Size = new System.Drawing.Size(104, 20);
            this.buttonSetAuto.TabIndex = 12;
            this.buttonSetAuto.Text = "Задать авто";
            this.buttonSetAuto.UseVisualStyleBackColor = true;
            this.buttonSetAuto.Click += new System.EventHandler(this.buttonSetAuto_Click);
            // 
            // buttonSetSportCar
            // 
            this.buttonSetSportCar.Location = new System.Drawing.Point(386, 455);
            this.buttonSetSportCar.Name = "buttonSetSportCar";
            this.buttonSetSportCar.Size = new System.Drawing.Size(137, 20);
            this.buttonSetSportCar.TabIndex = 13;
            this.buttonSetSportCar.Text = "Задать внедорожник";
            this.buttonSetSportCar.UseVisualStyleBackColor = true;
            this.buttonSetSportCar.Click += new System.EventHandler(this.buttonSetSportCar_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(602, 449);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(98, 25);
            this.buttonMove.TabIndex = 14;
            this.buttonMove.Text = "Движение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.BackColor = System.Drawing.Color.Red;
            this.buttonSelectColor.Location = new System.Drawing.Point(406, 418);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(79, 24);
            this.buttonSelectColor.TabIndex = 15;
            this.buttonSelectColor.Text = "Color";
            this.buttonSelectColor.UseVisualStyleBackColor = false;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.BackColor = System.Drawing.Color.Black;
            this.buttonSelectDopColor.Location = new System.Drawing.Point(602, 393);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(98, 27);
            this.buttonSelectDopColor.TabIndex = 16;
            this.buttonSelectDopColor.Text = "button5";
            this.buttonSelectDopColor.UseVisualStyleBackColor = false;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 478);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonSetSportCar);
            this.Controls.Add(this.buttonSetAuto);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxSideSpoiler);
            this.Controls.Add(this.checkBoxBackSpoiler);
            this.Controls.Add(this.checkBoxFrontSpoiler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaxCountPassenget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxFrontSpoiler;
        private System.Windows.Forms.CheckBox checkBoxBackSpoiler;
        private System.Windows.Forms.CheckBox checkBoxSideSpoiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonSetAuto;
        private System.Windows.Forms.Button buttonSetSportCar;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
    }
}

