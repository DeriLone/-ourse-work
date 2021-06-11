namespace GameBallista
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
            this.components = new System.ComponentModel.Container();
            this.Angle = new System.Windows.Forms.TextBox();
            this.Force = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ballista1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Shots = new System.Windows.Forms.Label();
            this.LozeOrWin = new System.Windows.Forms.Label();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Ballista2 = new System.Windows.Forms.PictureBox();
            this.explosionBox = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.WhoseTurn = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.Restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ballista1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballista2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Angle
            // 
            this.Angle.AccessibleDescription = "";
            this.Angle.AccessibleName = "";
            this.Angle.BackColor = System.Drawing.Color.White;
            this.Angle.Location = new System.Drawing.Point(12, 12);
            this.Angle.MaxLength = 2;
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(48, 20);
            this.Angle.TabIndex = 0;
            this.Angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Angle_KeyPress);
            // 
            // Force
            // 
            this.Force.BackColor = System.Drawing.Color.White;
            this.Force.Location = new System.Drawing.Point(12, 47);
            this.Force.MaxLength = 3;
            this.Force.Name = "Force";
            this.Force.Size = new System.Drawing.Size(48, 20);
            this.Force.TabIndex = 1;
            this.Force.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Force_KeyPress);
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.Color.White;
            this.Weight.Location = new System.Drawing.Point(12, 82);
            this.Weight.MaxLength = 2;
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(48, 20);
            this.Weight.TabIndex = 2;
            this.Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(13, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "ВОГОНЬ !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кут вогню (1 - 75)";
            // 
            // Ballista1
            // 
            this.Ballista1.BackColor = System.Drawing.Color.Transparent;
            this.Ballista1.Location = new System.Drawing.Point(102, 499);
            this.Ballista1.Name = "Ballista1";
            this.Ballista1.Size = new System.Drawing.Size(125, 90);
            this.Ballista1.TabIndex = 5;
            this.Ballista1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(62, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сила пострілу (1 - 150)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(62, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вага снаряду (1 - 50)";
            // 
            // Shots
            // 
            this.Shots.AutoSize = true;
            this.Shots.BackColor = System.Drawing.Color.Transparent;
            this.Shots.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shots.Location = new System.Drawing.Point(118, 123);
            this.Shots.Name = "Shots";
            this.Shots.Size = new System.Drawing.Size(35, 18);
            this.Shots.TabIndex = 8;
            this.Shots.Text = "5/5";
            // 
            // LozeOrWin
            // 
            this.LozeOrWin.AutoSize = true;
            this.LozeOrWin.BackColor = System.Drawing.Color.Transparent;
            this.LozeOrWin.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LozeOrWin.Location = new System.Drawing.Point(411, 158);
            this.LozeOrWin.Name = "LozeOrWin";
            this.LozeOrWin.Size = new System.Drawing.Size(339, 59);
            this.LozeOrWin.TabIndex = 9;
            this.LozeOrWin.Text = "Ви програли";
            this.LozeOrWin.Visible = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Location = new System.Drawing.Point(939, 499);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(20, 20);
            this.bullet.TabIndex = 10;
            this.bullet.TabStop = false;
            // 
            // Ballista2
            // 
            this.Ballista2.BackColor = System.Drawing.Color.Transparent;
            this.Ballista2.Location = new System.Drawing.Point(955, 499);
            this.Ballista2.Name = "Ballista2";
            this.Ballista2.Size = new System.Drawing.Size(125, 90);
            this.Ballista2.TabIndex = 11;
            this.Ballista2.TabStop = false;
            // 
            // explosionBox
            // 
            this.explosionBox.BackColor = System.Drawing.Color.Transparent;
            this.explosionBox.Location = new System.Drawing.Point(496, 483);
            this.explosionBox.Name = "explosionBox";
            this.explosionBox.Size = new System.Drawing.Size(110, 120);
            this.explosionBox.TabIndex = 13;
            this.explosionBox.TabStop = false;
            // 
            // WhoseTurn
            // 
            this.WhoseTurn.BackColor = System.Drawing.Color.Transparent;
            this.WhoseTurn.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhoseTurn.Location = new System.Drawing.Point(989, 14);
            this.WhoseTurn.Name = "WhoseTurn";
            this.WhoseTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WhoseTurn.Size = new System.Drawing.Size(183, 18);
            this.WhoseTurn.TabIndex = 14;
            this.WhoseTurn.Text = "Ваш хід";
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restart.Location = new System.Drawing.Point(518, 231);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(129, 34);
            this.Restart.TabIndex = 16;
            this.Restart.Text = "Ще раз!";
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameBallista.Resource1.background;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.WhoseTurn);
            this.Controls.Add(this.explosionBox);
            this.Controls.Add(this.Ballista2);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.LozeOrWin);
            this.Controls.Add(this.Shots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ballista1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.Force);
            this.Controls.Add(this.Angle);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.Text = "Game Ballista";
            ((System.ComponentModel.ISupportInitialize)(this.Ballista1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ballista2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.TextBox Force;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Ballista1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Shots;
        private System.Windows.Forms.Label LozeOrWin;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Ballista2;
        private System.Windows.Forms.PictureBox explosionBox;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label WhoseTurn;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label Restart;
    }
}

