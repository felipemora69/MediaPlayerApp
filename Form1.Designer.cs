namespace MultiMediaLesson
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.trackBar_Image = new System.Windows.Forms.TrackBar();
            this.cB_Img = new System.Windows.Forms.ComboBox();
            this.wmpExample = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_PlayAudio = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_PlayMP3 = new System.Windows.Forms.Button();
            this.btn_PlaySample = new System.Windows.Forms.Button();
            this.btn_PlayVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpExample)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.Color.Black;
            this.btn_Open.Location = new System.Drawing.Point(32, 46);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(91, 23);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open Picture";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.Color.Black;
            this.btn_Modify.ForeColor = System.Drawing.Color.White;
            this.btn_Modify.Location = new System.Drawing.Point(257, 75);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 1;
            this.btn_Modify.Text = "Apply";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(32, 156);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(300, 262);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // trackBar_Image
            // 
            this.trackBar_Image.Location = new System.Drawing.Point(32, 102);
            this.trackBar_Image.Name = "trackBar_Image";
            this.trackBar_Image.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Image.TabIndex = 3;
            this.trackBar_Image.Scroll += new System.EventHandler(this.trackBar_Image_Scroll);
            // 
            // cB_Img
            // 
            this.cB_Img.FormattingEnabled = true;
            this.cB_Img.Items.AddRange(new object[] {
            "None",
            "Black and White",
            "Sepia"});
            this.cB_Img.Location = new System.Drawing.Point(211, 48);
            this.cB_Img.Name = "cB_Img";
            this.cB_Img.Size = new System.Drawing.Size(121, 21);
            this.cB_Img.TabIndex = 4;
            this.cB_Img.Text = "None";
            // 
            // wmpExample
            // 
            this.wmpExample.Enabled = true;
            this.wmpExample.Location = new System.Drawing.Point(352, 35);
            this.wmpExample.Name = "wmpExample";
            this.wmpExample.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpExample.OcxState")));
            this.wmpExample.Size = new System.Drawing.Size(402, 269);
            this.wmpExample.TabIndex = 5;
            // 
            // btn_PlayAudio
            // 
            this.btn_PlayAudio.BackColor = System.Drawing.Color.Black;
            this.btn_PlayAudio.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayAudio.ForeColor = System.Drawing.Color.White;
            this.btn_PlayAudio.Location = new System.Drawing.Point(352, 323);
            this.btn_PlayAudio.Name = "btn_PlayAudio";
            this.btn_PlayAudio.Size = new System.Drawing.Size(75, 23);
            this.btn_PlayAudio.TabIndex = 6;
            this.btn_PlayAudio.Text = "Play Audio";
            this.btn_PlayAudio.UseVisualStyleBackColor = false;
            this.btn_PlayAudio.Click += new System.EventHandler(this.btn_PlayAudio_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(352, 361);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(53, 44);
            this.btn_Stop.TabIndex = 7;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_PlayMP3
            // 
            this.btn_PlayMP3.BackColor = System.Drawing.Color.Black;
            this.btn_PlayMP3.Location = new System.Drawing.Point(433, 323);
            this.btn_PlayMP3.Name = "btn_PlayMP3";
            this.btn_PlayMP3.Size = new System.Drawing.Size(75, 23);
            this.btn_PlayMP3.TabIndex = 8;
            this.btn_PlayMP3.Text = "Play MP3";
            this.btn_PlayMP3.UseVisualStyleBackColor = false;
            this.btn_PlayMP3.Click += new System.EventHandler(this.btn_PlayMP3_Click);
            // 
            // btn_PlaySample
            // 
            this.btn_PlaySample.BackColor = System.Drawing.Color.Black;
            this.btn_PlaySample.Location = new System.Drawing.Point(595, 323);
            this.btn_PlaySample.Name = "btn_PlaySample";
            this.btn_PlaySample.Size = new System.Drawing.Size(75, 23);
            this.btn_PlaySample.TabIndex = 9;
            this.btn_PlaySample.Text = "Play Sample";
            this.btn_PlaySample.UseVisualStyleBackColor = false;
            this.btn_PlaySample.Click += new System.EventHandler(this.btn_PlaySample_Click);
            // 
            // btn_PlayVideo
            // 
            this.btn_PlayVideo.BackColor = System.Drawing.Color.Black;
            this.btn_PlayVideo.Location = new System.Drawing.Point(514, 323);
            this.btn_PlayVideo.Name = "btn_PlayVideo";
            this.btn_PlayVideo.Size = new System.Drawing.Size(75, 23);
            this.btn_PlayVideo.TabIndex = 10;
            this.btn_PlayVideo.Text = "Play Video";
            this.btn_PlayVideo.UseVisualStyleBackColor = false;
            this.btn_PlayVideo.Click += new System.EventHandler(this.btn_PlayVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PlayVideo);
            this.Controls.Add(this.btn_PlaySample);
            this.Controls.Add(this.btn_PlayMP3);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_PlayAudio);
            this.Controls.Add(this.wmpExample);
            this.Controls.Add(this.cB_Img);
            this.Controls.Add(this.trackBar_Image);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Open);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.TrackBar trackBar_Image;
        private System.Windows.Forms.ComboBox cB_Img;
        private AxWMPLib.AxWindowsMediaPlayer wmpExample;
        private System.Windows.Forms.Button btn_PlayAudio;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_PlayMP3;
        private System.Windows.Forms.Button btn_PlaySample;
        private System.Windows.Forms.Button btn_PlayVideo;
    }
}

