using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private potato[] potatos;

        private Salt salt;

        private Pepper pepper;

        private WaterTap waterTap;

        private knife knife;

        private Pan pan;

        private Stove stove;

        private forcemeat[] forcemeat;

        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            knife = new knife();
            pan = new Pan();
            stove = new Stove();
            
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownForcemeat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPepper = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSalt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPotatos = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBreakPotatos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonGetPotatos = new System.Windows.Forms.Button();
            this.buttonAddPepper = new System.Windows.Forms.Button();
            this.buttonAddSalt = new System.Windows.Forms.Button();
            this.buttonAddPotatos = new System.Windows.Forms.Button();
            this.buttonAddForcemeat = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGetPan = new System.Windows.Forms.Button();
            this.buttonCook = new System.Windows.Forms.Button();
            this.buttonAddPan = new System.Windows.Forms.Button();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonWash = new System.Windows.Forms.Button();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForcemeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.numericUpDownForcemeat);
            this.groupBox1.Controls.Add(this.numericUpDownPepper);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownSalt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownPotatos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(213, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингредиенты";
            // 
            // numericUpDownForcemeat
            // 
            this.numericUpDownForcemeat.Location = new System.Drawing.Point(156, 59);
            this.numericUpDownForcemeat.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownForcemeat.Name = "numericUpDownForcemeat";
            this.numericUpDownForcemeat.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownForcemeat.TabIndex = 13;
            this.numericUpDownForcemeat.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDownPepper
            // 
            this.numericUpDownPepper.Location = new System.Drawing.Point(156, 127);
            this.numericUpDownPepper.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPepper.Name = "numericUpDownPepper";
            this.numericUpDownPepper.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownPepper.TabIndex = 12;
            this.numericUpDownPepper.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Перец";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDownSalt
            // 
            this.numericUpDownSalt.Location = new System.Drawing.Point(156, 91);
            this.numericUpDownSalt.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSalt.Name = "numericUpDownSalt";
            this.numericUpDownSalt.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownSalt.TabIndex = 10;
            this.numericUpDownSalt.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Соль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фарш";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Картофель";
            // 
            // numericUpDownPotatos
            // 
            this.numericUpDownPotatos.Location = new System.Drawing.Point(156, 29);
            this.numericUpDownPotatos.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPotatos.Name = "numericUpDownPotatos";
            this.numericUpDownPotatos.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownPotatos.TabIndex = 1;
            this.numericUpDownPotatos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.buttonBreakPotatos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(249, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(183, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Нож";
            // 
            // buttonBreakPotatos
            // 
            this.buttonBreakPotatos.BackColor = System.Drawing.Color.SeaShell;
            this.buttonBreakPotatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBreakPotatos.Location = new System.Drawing.Point(35, 21);
            this.buttonBreakPotatos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBreakPotatos.Name = "buttonBreakPotatos";
            this.buttonBreakPotatos.Size = new System.Drawing.Size(105, 36);
            this.buttonBreakPotatos.TabIndex = 0;
            this.buttonBreakPotatos.Text = "Нарезать картофель";
            this.buttonBreakPotatos.UseVisualStyleBackColor = false;
            this.buttonBreakPotatos.Click += new System.EventHandler(this.buttonBreakEggs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.buttonGetPotatos);
            this.groupBox4.Controls.Add(this.buttonAddPepper);
            this.groupBox4.Controls.Add(this.buttonAddSalt);
            this.groupBox4.Controls.Add(this.buttonAddPotatos);
            this.groupBox4.Controls.Add(this.buttonAddForcemeat);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(461, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(206, 401);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тесто";
            // 
            // buttonGetPotatos
            // 
            this.buttonGetPotatos.BackColor = System.Drawing.Color.SeaShell;
            this.buttonGetPotatos.Enabled = false;
            this.buttonGetPotatos.Location = new System.Drawing.Point(27, 248);
            this.buttonGetPotatos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetPotatos.Name = "buttonGetPotatos";
            this.buttonGetPotatos.Size = new System.Drawing.Size(150, 42);
            this.buttonGetPotatos.TabIndex = 4;
            this.buttonGetPotatos.Text = "Получить манты";
            this.buttonGetPotatos.UseVisualStyleBackColor = false;
            this.buttonGetPotatos.Click += new System.EventHandler(this.buttonGetEggs_Click);
            // 
            // buttonAddPepper
            // 
            this.buttonAddPepper.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddPepper.Enabled = false;
            this.buttonAddPepper.Location = new System.Drawing.Point(27, 199);
            this.buttonAddPepper.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPepper.Name = "buttonAddPepper";
            this.buttonAddPepper.Size = new System.Drawing.Size(150, 42);
            this.buttonAddPepper.TabIndex = 3;
            this.buttonAddPepper.Text = "Добавить перец";
            this.buttonAddPepper.UseVisualStyleBackColor = false;
            this.buttonAddPepper.Click += new System.EventHandler(this.buttonAddPepper_Click);
            // 
            // buttonAddSalt
            // 
            this.buttonAddSalt.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddSalt.Enabled = false;
            this.buttonAddSalt.Location = new System.Drawing.Point(28, 144);
            this.buttonAddSalt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSalt.Name = "buttonAddSalt";
            this.buttonAddSalt.Size = new System.Drawing.Size(150, 42);
            this.buttonAddSalt.TabIndex = 2;
            this.buttonAddSalt.Text = "Добавить соль";
            this.buttonAddSalt.UseVisualStyleBackColor = false;
            this.buttonAddSalt.Click += new System.EventHandler(this.buttonAddSalt_Click);
            // 
            // buttonAddPotatos
            // 
            this.buttonAddPotatos.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddPotatos.Enabled = false;
            this.buttonAddPotatos.Location = new System.Drawing.Point(27, 91);
            this.buttonAddPotatos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPotatos.Name = "buttonAddPotatos";
            this.buttonAddPotatos.Size = new System.Drawing.Size(150, 42);
            this.buttonAddPotatos.TabIndex = 1;
            this.buttonAddPotatos.Text = "Добавить картофель";
            this.buttonAddPotatos.UseVisualStyleBackColor = false;
            this.buttonAddPotatos.Click += new System.EventHandler(this.buttonAddPotatos_Click);
            // 
            // buttonAddForcemeat
            // 
            this.buttonAddForcemeat.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddForcemeat.Location = new System.Drawing.Point(27, 35);
            this.buttonAddForcemeat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddForcemeat.Name = "buttonAddForcemeat";
            this.buttonAddForcemeat.Size = new System.Drawing.Size(150, 42);
            this.buttonAddForcemeat.TabIndex = 0;
            this.buttonAddForcemeat.Text = "Добавить фарш";
            this.buttonAddForcemeat.UseVisualStyleBackColor = false;
            this.buttonAddForcemeat.Click += new System.EventHandler(this.buttonAddOil_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox5.Controls.Add(this.buttonGetPan);
            this.groupBox5.Controls.Add(this.buttonCook);
            this.groupBox5.Controls.Add(this.buttonAddPan);
            this.groupBox5.Controls.Add(this.checkBoxOn);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(234, 104);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(213, 198);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Плита";
            // 
            // buttonGetPan
            // 
            this.buttonGetPan.BackColor = System.Drawing.Color.SeaShell;
            this.buttonGetPan.Enabled = false;
            this.buttonGetPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetPan.Location = new System.Drawing.Point(31, 149);
            this.buttonGetPan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetPan.Name = "buttonGetPan";
            this.buttonGetPan.Size = new System.Drawing.Size(144, 27);
            this.buttonGetPan.TabIndex = 3;
            this.buttonGetPan.Text = "Убрать пароварку";
            this.buttonGetPan.UseVisualStyleBackColor = false;
            this.buttonGetPan.Click += new System.EventHandler(this.buttonGetPan_Click);
            // 
            // buttonCook
            // 
            this.buttonCook.BackColor = System.Drawing.Color.SeaShell;
            this.buttonCook.Enabled = false;
            this.buttonCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCook.Location = new System.Drawing.Point(31, 96);
            this.buttonCook.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(144, 27);
            this.buttonCook.TabIndex = 2;
            this.buttonCook.Text = "Готовить";
            this.buttonCook.UseVisualStyleBackColor = false;
            this.buttonCook.Click += new System.EventHandler(this.buttonCook_Click);
            // 
            // buttonAddPan
            // 
            this.buttonAddPan.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPan.Location = new System.Drawing.Point(31, 58);
            this.buttonAddPan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddPan.Name = "buttonAddPan";
            this.buttonAddPan.Size = new System.Drawing.Size(144, 27);
            this.buttonAddPan.TabIndex = 1;
            this.buttonAddPan.Text = "Поставить пароварку";
            this.buttonAddPan.UseVisualStyleBackColor = false;
            this.buttonAddPan.Click += new System.EventHandler(this.buttonAddPan_Click);
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.BackColor = System.Drawing.Color.SeaShell;
            this.checkBoxOn.Location = new System.Drawing.Point(74, 21);
            this.checkBoxOn.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(45, 17);
            this.checkBoxOn.TabIndex = 0;
            this.checkBoxOn.Text = "Вкл";
            this.checkBoxOn.UseVisualStyleBackColor = false;
            this.checkBoxOn.CheckedChanged += new System.EventHandler(this.checkBoxOn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.buttonWash);
            this.groupBox3.Controls.Add(this.radioButtonClose);
            this.groupBox3.Controls.Add(this.radioButtonOpen);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(8, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(183, 173);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кран";
            // 
            // buttonWash
            // 
            this.buttonWash.BackColor = System.Drawing.Color.SeaShell;
            this.buttonWash.Location = new System.Drawing.Point(87, 25);
            this.buttonWash.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWash.Name = "buttonWash";
            this.buttonWash.Size = new System.Drawing.Size(83, 56);
            this.buttonWash.TabIndex = 2;
            this.buttonWash.Text = "Залить воду в пароварку";
            this.buttonWash.UseVisualStyleBackColor = false;
            this.buttonWash.Click += new System.EventHandler(this.buttonWash_Click);
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Location = new System.Drawing.Point(11, 58);
            this.radioButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(63, 17);
            this.radioButtonClose.TabIndex = 1;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Закрыт";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            this.radioButtonClose.CheckedChanged += new System.EventHandler(this.radioButtonClose_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(11, 29);
            this.radioButtonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(63, 17);
            this.radioButtonOpen.TabIndex = 0;
            this.radioButtonOpen.Text = "Открыт";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(665, 451);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Кухня";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForcemeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButtonClose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClose.Checked)
            {
                waterTap.State = false;
            }
        }

        private void buttonWash_Click(object sender, EventArgs e)
        {
            if (numericUpDownPotatos.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как залить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potatos = new potato[Convert.ToInt32(numericUpDownPotatos.Value)];
                pan.Init(Convert.ToInt32(numericUpDownPotatos.Value));
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i] = new potato();
                }
                for (int i = 0; i < potatos.Length; ++i)
                {
                    potatos[i].Dirty = 0;
                }
                numericUpDownPotatos.Enabled = false;
                radioButtonClose.Checked = true;
                MessageBox.Show("Воду залили,можно лепить манты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не все готово к готовке ,смысл резать ?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBreakEggs_Click(object sender, EventArgs e)
        {
            if (potatos == null)
            {
                MessageBox.Show("Не все готово к готовке ,смысл резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos.Length == 0)
            {
                MessageBox.Show("Не все готово к готовке ,смысл резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Вода не залита,пока рано резать картофель", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            for (int i = 0; i < potatos.Length; ++i)
            {
                knife.Break(potatos[i]);
            }
            buttonAddPotatos.Enabled = true;
            MessageBox.Show("Картофель нарезали,можно готовить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddSalt_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDownSalt.Value);
            if (salt.Count > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Соль добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddPepper_Click(object sender, EventArgs e)
        {
            pepper = new Pepper();
            pepper.Count = Convert.ToInt32(numericUpDownPepper.Value);
            if (pepper.Count > 0)
            {
                pan.AddPepper(pepper);
                MessageBox.Show("Перец добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Перца же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddOil_Click(object sender, EventArgs e)
        {
            forcemeat = new forcemeat[Convert.ToInt32(numericUpDownForcemeat.Value)];
            int forcemeatCount = Convert.ToInt32(numericUpDownForcemeat.Value);
            pan.Init2(forcemeatCount);
         
            if (forcemeat.Length <= 0)
            {
                MessageBox.Show("Фарша нет,что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < forcemeat.Length; ++i)
            {
                forcemeat[i] = new forcemeat();
            }
            for (int i = 0; i < forcemeat.Length; ++i)
            {
                pan.AddForcemeat(forcemeat[i]);
            }
            buttonAddSalt.Enabled = true;
            buttonAddPotatos.Enabled = true;

            MessageBox.Show("Фарш добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddPotatos_Click(object sender, EventArgs e)
        {
            if (potatos == null)
            {
                MessageBox.Show("Картошки нет,что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potatos.Length == 0)
            {
                MessageBox.Show("Картошки то нет,как готовить??", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (forcemeat == null)
            {
                MessageBox.Show("Добавьте сначала фарш.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (forcemeat.Length <= 0)
            {
                MessageBox.Show("Добавьте сначала фарш.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!stove.State || !pan.State)
            {
                MessageBox.Show("Поставьте пароварку на плиту,чтобы вода вскипятилась.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i < potatos.Length; ++i)
            {
                if (potatos[i].Dirty > 0)
                {
                    MessageBox.Show("Картофель не нарезан,как готовить??", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (potatos[i].Have_shell)
                {
                    MessageBox.Show("Для начала нарежте картофель.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
            {
                pan.AddPotato(potatos[i]);
            }
            buttonAddSalt.Enabled = true;
            buttonAddPepper.Enabled = true;
            MessageBox.Show("Картофель добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddPan_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            buttonCook.Enabled = true;
            pan.State = true;
            MessageBox.Show("Пароварка на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxOn_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = checkBoxOn.Checked;
        }

        private void buttonCook_Click(object sender, EventArgs e)
        {
            if (!pan.ReadyToGo)
            {
                MessageBox.Show("У нас не все готово к готовке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Жарить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (stove.Pan.IsReady())
            {
                buttonGetPan.Enabled = true;
                buttonGetPotatos.Enabled = true;
                checkBoxOn.Checked = false;
                MessageBox.Show("Готова!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так,манты не готовы", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonGetPan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Убрали с плиты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetEggs_Click(object sender, EventArgs e)
        {
            potatos = pan.GetPotatos();
            MessageBox.Show("Мы сделали это! Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPotatos;
        private System.Windows.Forms.NumericUpDown numericUpDownPepper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSalt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBreakPotatos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGetPan;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.Button buttonAddPan;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.NumericUpDown numericUpDownForcemeat;
        private System.Windows.Forms.Button buttonGetPotatos;
        private System.Windows.Forms.Button buttonAddPepper;
        private System.Windows.Forms.Button buttonAddSalt;
        private System.Windows.Forms.Button buttonAddPotatos;
        private System.Windows.Forms.Button buttonAddForcemeat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonWash;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
    
    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
