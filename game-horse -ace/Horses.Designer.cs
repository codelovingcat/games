namespace game_horse__ace
{
    partial class Horses
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerHorse = new System.Windows.Forms.Timer(this.components);
            this.picture2Horse = new System.Windows.Forms.PictureBox();
            this.picture3Horse = new System.Windows.Forms.PictureBox();
            this.pictureBirHorse = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture2Horse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3Horse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.Location = new System.Drawing.Point(4, 412);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(165, 54);
            this.btnNewGame.TabIndex = 37;
            this.btnNewGame.Text = "Yeniden Oyna";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblText.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(233, 425);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(577, 29);
            this.lblText.TabIndex = 35;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Minion Pro SmBd", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(111, 412);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 54);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblFinish.Location = new System.Drawing.Point(816, -2);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(10, 398);
            this.lblFinish.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label4.Location = new System.Drawing.Point(1, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(815, 10);
            this.label4.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Location = new System.Drawing.Point(1, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(815, 10);
            this.label3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(1, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(815, 10);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 10);
            this.label1.TabIndex = 19;
            // 
            // timerHorse
            // 
            this.timerHorse.Tick += new System.EventHandler(this.timerHorse_Tick);
            // 
            // picture2Horse
            // 
            this.picture2Horse.Image = global::game_horse__ace.Properties.Resources.horse2;
            this.picture2Horse.Location = new System.Drawing.Point(4, 137);
            this.picture2Horse.Name = "picture2Horse";
            this.picture2Horse.Size = new System.Drawing.Size(125, 110);
            this.picture2Horse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2Horse.TabIndex = 29;
            this.picture2Horse.TabStop = false;
            // 
            // picture3Horse
            // 
            this.picture3Horse.Image = global::game_horse__ace.Properties.Resources.horse3;
            this.picture3Horse.Location = new System.Drawing.Point(4, 263);
            this.picture3Horse.Name = "picture3Horse";
            this.picture3Horse.Size = new System.Drawing.Size(125, 120);
            this.picture3Horse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture3Horse.TabIndex = 27;
            this.picture3Horse.TabStop = false;
            // 
            // pictureBirHorse
            // 
            this.pictureBirHorse.Image = global::game_horse__ace.Properties.Resources.horse1;
            this.pictureBirHorse.Location = new System.Drawing.Point(4, 11);
            this.pictureBirHorse.Name = "pictureBirHorse";
            this.pictureBirHorse.Size = new System.Drawing.Size(125, 110);
            this.pictureBirHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBirHorse.TabIndex = 25;
            this.pictureBirHorse.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::game_horse__ace.Properties.Resources.hors;
            this.pictureBox1.Location = new System.Drawing.Point(4, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Horses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(828, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picture2Horse);
            this.Controls.Add(this.picture3Horse);
            this.Controls.Add(this.pictureBirHorse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Horses";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Horses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture2Horse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3Horse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBirHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox picture2Horse;
        private System.Windows.Forms.PictureBox picture3Horse;
        private System.Windows.Forms.PictureBox pictureBirHorse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerHorse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

