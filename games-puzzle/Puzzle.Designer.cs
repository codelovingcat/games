namespace games_puzzle
{
    partial class Puzzle
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnNextTo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(83, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 90;
            this.label4.Text = ":";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(64, 14);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(24, 16);
            this.lblDakika.TabIndex = 89;
            this.lblDakika.Text = "00";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(91, 14);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(24, 16);
            this.lblSaniye.TabIndex = 88;
            this.lblSaniye.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "Süre";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.MistyRose;
            this.btnOut.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOut.Location = new System.Drawing.Point(11, 107);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(105, 29);
            this.btnOut.TabIndex = 86;
            this.btnOut.Text = "Çık";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnNextTo
            // 
            this.btnNextTo.BackColor = System.Drawing.Color.Salmon;
            this.btnNextTo.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextTo.Location = new System.Drawing.Point(11, 73);
            this.btnNextTo.Name = "btnNextTo";
            this.btnNextTo.Size = new System.Drawing.Size(105, 28);
            this.btnNextTo.TabIndex = 85;
            this.btnNextTo.Text = "Dur/Devam";
            this.btnNextTo.UseVisualStyleBackColor = false;
            this.btnNextTo.Click += new System.EventHandler(this.btnNextTo_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MistyRose;
            this.btnStart.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(11, 34);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 33);
            this.btnStart.TabIndex = 84;
            this.btnStart.Text = "Yeniden Başlat";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::games_puzzle.Properties.Resources.resim;
            this.pictureBox1.Location = new System.Drawing.Point(564, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnNextTo);
            this.panel1.Controls.Add(this.lblDakika);
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.lblSaniye);
            this.panel1.Location = new System.Drawing.Point(415, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 142);
            this.panel1.TabIndex = 92;
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Puzzle";
            this.Text = "Puzzle Oyna";
            this.Load += new System.EventHandler(this.Puzzle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnNextTo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

