﻿namespace FandG
{
    partial class zielony
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zielony));
            this.labClock2 = new System.Windows.Forms.Label();
            this.labClock = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Count = new System.Windows.Forms.Timer(this.components);
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.labCount = new System.Windows.Forms.Label();
            this.chance1 = new System.Windows.Forms.PictureBox();
            this.chance2 = new System.Windows.Forms.PictureBox();
            this.chance3 = new System.Windows.Forms.PictureBox();
            this.chance4 = new System.Windows.Forms.PictureBox();
            this.chance5 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labClock2
            // 
            this.labClock2.AutoSize = true;
            this.labClock2.BackColor = System.Drawing.Color.Transparent;
            this.labClock2.Font = new System.Drawing.Font("Junegull", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClock2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labClock2.Location = new System.Drawing.Point(548, 19);
            this.labClock2.Name = "labClock2";
            this.labClock2.Size = new System.Drawing.Size(139, 33);
            this.labClock2.TabIndex = 22;
            this.labClock2.Text = "Czas: 00";
            // 
            // labClock
            // 
            this.labClock.AutoSize = true;
            this.labClock.BackColor = System.Drawing.Color.Transparent;
            this.labClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labClock.Font = new System.Drawing.Font("Junegull", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labClock.Location = new System.Drawing.Point(692, 19);
            this.labClock.Name = "labClock";
            this.labClock.Size = new System.Drawing.Size(64, 33);
            this.labClock.TabIndex = 21;
            this.labClock.Text = ":00";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.BackColor = System.Drawing.Color.Transparent;
            this.labScore.Font = new System.Drawing.Font("Junegull", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labScore.Location = new System.Drawing.Point(392, 19);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(147, 33);
            this.labScore.TabIndex = 15;
            this.labScore.Text = "Punkty: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // Count
            // 
            this.Count.Enabled = true;
            this.Count.Interval = 1000;
            this.Count.Tick += new System.EventHandler(this.Count_Tick);
            // 
            // Clock
            // 
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.BackColor = System.Drawing.Color.Transparent;
            this.labCount.Font = new System.Drawing.Font("Junegull", 89.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labCount.Location = new System.Drawing.Point(331, 194);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(116, 118);
            this.labCount.TabIndex = 23;
            this.labCount.Text = "5";
            // 
            // chance1
            // 
            this.chance1.BackColor = System.Drawing.Color.Transparent;
            this.chance1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chance1.BackgroundImage")));
            this.chance1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chance1.Location = new System.Drawing.Point(212, 12);
            this.chance1.Name = "chance1";
            this.chance1.Size = new System.Drawing.Size(40, 40);
            this.chance1.TabIndex = 20;
            this.chance1.TabStop = false;
            // 
            // chance2
            // 
            this.chance2.BackColor = System.Drawing.Color.Transparent;
            this.chance2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chance2.BackgroundImage")));
            this.chance2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chance2.Location = new System.Drawing.Point(166, 12);
            this.chance2.Name = "chance2";
            this.chance2.Size = new System.Drawing.Size(40, 40);
            this.chance2.TabIndex = 19;
            this.chance2.TabStop = false;
            // 
            // chance3
            // 
            this.chance3.BackColor = System.Drawing.Color.Transparent;
            this.chance3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chance3.BackgroundImage")));
            this.chance3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chance3.Location = new System.Drawing.Point(120, 12);
            this.chance3.Name = "chance3";
            this.chance3.Size = new System.Drawing.Size(40, 40);
            this.chance3.TabIndex = 18;
            this.chance3.TabStop = false;
            // 
            // chance4
            // 
            this.chance4.BackColor = System.Drawing.Color.Transparent;
            this.chance4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chance4.BackgroundImage")));
            this.chance4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chance4.Location = new System.Drawing.Point(74, 12);
            this.chance4.Name = "chance4";
            this.chance4.Size = new System.Drawing.Size(40, 40);
            this.chance4.TabIndex = 17;
            this.chance4.TabStop = false;
            // 
            // chance5
            // 
            this.chance5.BackColor = System.Drawing.Color.Transparent;
            this.chance5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chance5.BackgroundImage")));
            this.chance5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chance5.Location = new System.Drawing.Point(28, 12);
            this.chance5.Name = "chance5";
            this.chance5.Size = new System.Drawing.Size(40, 40);
            this.chance5.TabIndex = 16;
            this.chance5.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::FandG.Properties.Resources.zie_prawy1;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(334, 336);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(113, 97);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::FandG.Properties.Resources.butelka2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(554, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 95);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "bottle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FandG.Properties.Resources.puszka1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(351, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 73);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "can";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FandG.Properties.Resources.jablko1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(120, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "core";
            // 
            // exit_but
            // 
            this.exit_but.BackColor = System.Drawing.Color.Cornsilk;
            this.exit_but.Font = new System.Drawing.Font("Junegull", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_but.ForeColor = System.Drawing.Color.Maroon;
            this.exit_but.Location = new System.Drawing.Point(716, 441);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(40, 40);
            this.exit_but.TabIndex = 24;
            this.exit_but.Text = "x";
            this.exit_but.UseVisualStyleBackColor = false;
            this.exit_but.Visible = false;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // zielony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::FandG.Properties.Resources.tlo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 493);
            this.ControlBox = false;
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.labClock2);
            this.Controls.Add(this.labClock);
            this.Controls.Add(this.chance1);
            this.Controls.Add(this.chance2);
            this.Controls.Add(this.chance3);
            this.Controls.Add(this.chance4);
            this.Controls.Add(this.chance5);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "zielony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.chance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chance5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label labClock2;
        private System.Windows.Forms.Label labClock;
        private System.Windows.Forms.PictureBox chance1;
        private System.Windows.Forms.PictureBox chance2;
        private System.Windows.Forms.PictureBox chance3;
        private System.Windows.Forms.PictureBox chance4;
        private System.Windows.Forms.PictureBox chance5;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer Count;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button exit_but;
    }
}