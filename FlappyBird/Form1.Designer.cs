
namespace FlappyBird
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblUstCizgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 663);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(773, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(274, 256);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(63, 55);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // boruAlt
            // 
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(614, 470);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(114, 196);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 0;
            this.boruAlt.TabStop = false;
            // 
            // boruUst
            // 
            this.boruUst.Image = ((System.Drawing.Image)(resources.GetObject("boruUst.Image")));
            this.boruUst.Location = new System.Drawing.Point(614, 12);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(114, 187);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 0;
            this.boruUst.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.DarkViolet;
            this.scoreText.Location = new System.Drawing.Point(22, 698);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(330, 61);
            this.scoreText.TabIndex = 1;
            this.scoreText.Text = "Score:0";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // lblUstCizgi
            // 
            this.lblUstCizgi.Location = new System.Drawing.Point(-3, 2);
            this.lblUstCizgi.Name = "lblUstCizgi";
            this.lblUstCizgi.Size = new System.Drawing.Size(776, 10);
            this.lblUstCizgi.TabIndex = 2;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(772, 764);
            this.Controls.Add(this.lblUstCizgi);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.boruUst);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.ground);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblUstCizgi;
    }
}

