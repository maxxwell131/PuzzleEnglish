namespace PuzzleEnglish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelRussion = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRussion
            // 
            this.labelRussion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRussion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRussion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRussion.ForeColor = System.Drawing.Color.Red;
            this.labelRussion.Location = new System.Drawing.Point(93, 19);
            this.labelRussion.Name = "labelRussion";
            this.labelRussion.Size = new System.Drawing.Size(330, 40);
            this.labelRussion.TabIndex = 0;
            this.labelRussion.Text = "label1";
            this.labelRussion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRussion.Click += new System.EventHandler(this.labelRussion_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(444, 182);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 57);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev.Location = new System.Drawing.Point(12, 182);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 57);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // pictureCard
            // 
            this.pictureCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCard.Location = new System.Drawing.Point(93, 62);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(330, 330);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCard.TabIndex = 4;
            this.pictureCard.TabStop = false;
            this.pictureCard.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnglish.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnglish.ForeColor = System.Drawing.Color.Blue;
            this.labelEnglish.Location = new System.Drawing.Point(93, 395);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(330, 40);
            this.labelEnglish.TabIndex = 5;
            this.labelEnglish.Text = "label2";
            this.labelEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEnglish.Click += new System.EventHandler(this.labelEnglish_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVideo.Location = new System.Drawing.Point(435, 62);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(71, 18);
            this.labelVideo.TabIndex = 6;
            this.labelVideo.Text = "+ video";
            this.labelVideo.Visible = false;
            this.labelVideo.Click += new System.EventHandler(this.labelVideo_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(93, 62);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(330, 330);
            this.player.TabIndex = 7;
            this.player.Visible = false;
            this.player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 465);
            this.Controls.Add(this.player);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.pictureCard);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelRussion);
            this.Name = "Form1";
            this.Text = "Puzzle English";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRussion;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.PictureBox pictureCard;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelVideo;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

