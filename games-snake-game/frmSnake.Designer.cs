namespace games_snake_game
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.duraklatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(-2, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 455);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(724, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 454);
            this.label2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 17);
            this.label1.TabIndex = 9;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.LightCyan;
            this.lblScore.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(338, 1);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(64, 22);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score : 0";
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pbGame.Location = new System.Drawing.Point(10, 41);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(716, 433);
            this.pbGame.TabIndex = 7;
            this.pbGame.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.spToolStripMenuItem,
            this.duraklatToolStripMenuItem,
            this.spToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosyaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.dosyaToolStripMenuItem.Text = "Oyun Oyna";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem
            // 
            this.spToolStripMenuItem.Name = "spToolStripMenuItem";
            this.spToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // duraklatToolStripMenuItem
            // 
            this.duraklatToolStripMenuItem.Name = "duraklatToolStripMenuItem";
            this.duraklatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duraklatToolStripMenuItem.Text = "Duraklat";
            this.duraklatToolStripMenuItem.Click += new System.EventHandler(this.duraklatToolStripMenuItem_Click);
            // 
            // spToolStripMenuItem1
            // 
            this.spToolStripMenuItem1.Name = "spToolStripMenuItem1";
            this.spToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(-2, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(739, 17);
            this.label4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGame);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duraklatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

