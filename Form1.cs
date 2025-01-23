using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace MultiMediaLesson
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();

        string Path;

        Image img;//Where we will be storing our main image.
        public Form1()
        {
            InitializeComponent();
            wmpExample.uiMode = "none";//Setting our media player UI to none so that our Play and Stop buttons will be imporant.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();//Open file dialog, as seen in the notepad lessons.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(ofd.FileName);
                picBox.Image = img;
            }

        }

        private void trackBar_Image_Scroll(object sender, EventArgs e)
        {
            Image temp = picBox.Image;//To manipulate the image, first we store it in a temp variable.
            temp.RotateFlip(RotateFlipType.Rotate90FlipXY);//Rotating method, flipping it 90 degrees.
            picBox.Image = temp;//Finish up by changing the image on the image loader to the one we manipulated.
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            Image temp = picBox.Image;
            Bitmap bmp = new Bitmap(temp);//Change the image into a Bitmap.

            int oRed, oGreen, oBlue, sRed, sGreen, sBlue;//Variables for our colors.
            //Remember colors are made by Alpha, Red, Green and Blue. All these values are Ints that range from 0 - 255.
            //These parameters are refered to as ARGB.

            if (cB_Img.Text == "None") picBox.Image = img; //Returns image to the original one if None is selected.

            if (cB_Img.Text == "Black and White")
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)//Nested ForLoops for iterating through each of the pixels.
                    {
                        Color tempColor = bmp.GetPixel(i, j);//Grab the color from that pixel.
                        oRed = tempColor.R;
                        oGreen = tempColor.G;
                        oBlue = tempColor.B;//Break the tempColor in the basic colors.

                        sRed = Convert.ToInt32(0.3 * oRed + 0.7 * oGreen + 0.2 * oBlue);//Alter the basic colors to reflect the tone we want.
                        sGreen = Convert.ToInt32(0.3 * oRed + 0.7 * oGreen + 0.2 * oBlue);
                        sBlue = Convert.ToInt32(0.3 * oRed + 0.7 * oGreen + 0.2 * oBlue);

                        if (sRed > 255) sRed = 255;//Since we know the ints for color values can't go over 255, we use logic to limit it to 255.
                        if (sGreen > 255) sGreen = 255;
                        if (sBlue > 255) sBlue = 255;

                        tempColor = Color.FromArgb(tempColor.A, sRed, sGreen, sBlue);//Create a new color, from ARGB values.
                        bmp.SetPixel(i, j, tempColor);//Set the pixel to the new color we created.
                    }
                    
                }
                picBox.Image = bmp;//When the iteration is over, we substitute the image on the box for our new one! :)
            }

            if (cB_Img.Text == "Sepia")//Repeat of the same loop, except with different calculations to achieve Sepia.
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Color tempColor = bmp.GetPixel(i, j);
                        oRed = tempColor.R;
                        oGreen = tempColor.G;
                        oBlue = tempColor.B;

                        sRed = Convert.ToInt32(0.393 * oRed + 0.769 * oGreen + 0.182 * oBlue);
                        sGreen = Convert.ToInt32(0.349 * oRed + 0.686 * oGreen + 0.168 * oBlue);
                        sBlue = Convert.ToInt32(0.372 * oRed + 0.534 * oGreen + 0.131 * oBlue);

                        if (sRed > 255) sRed = 255;
                        if (sGreen > 255) sGreen = 255;
                        if (sBlue > 255) sBlue = 255;

                        tempColor = Color.FromArgb(tempColor.A, sRed, sGreen, sBlue);
                        bmp.SetPixel(i, j, tempColor);
                    }
                }
                picBox.Image = bmp;
            }

        }

        private void btn_PlayAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio | *.wav";

            Path = ofd.FileName;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                player = new SoundPlayer(ofd.FileName);
                player.Play();//Whenever we get the file, we play it immediatelly.

            }
        }

       

        private void btn_PlayMP3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 | *.mp3";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpExample.URL = ofd.FileName;//set the MP3 as the file to be opened.
                wmpExample.Ctlcontrols.play();//Play our MP3.
            }
        }

        private WaveStream Audio1; //Declaration of our needed objects for using NAudio.
        private WaveStream Audio2;
        private WaveOut AudioOut1;
        private WaveOut AudioOut2;


        private void btn_PlaySample_Click(object sender, EventArgs e)
        {

            Audio1 = new AudioFileReader(@"C:\Users\Lenovo\Desktop\3rd Semester\SODV2101- RAPID APP DEVELOP\Media-Player\beach1.mp3");
            Audio2 = new AudioFileReader(@"C:\Users\Lenovo\Desktop\3rd Semester\SODV2101- RAPID APP DEVELOP\Media-Player\waves1.mp3");

            AudioOut1 = new WaveOut();//out stream 1.
            AudioOut1.Init(Audio1);
            AudioOut2 = new WaveOut();//out stream 2
            AudioOut2.Init(Audio2);

            Audio1.CurrentTime = new TimeSpan(0L);//setting the playback time to 0.
            Audio2.CurrentTime = new TimeSpan(0L);
            AudioOut1.Play();//Playing
            AudioOut2.Play();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            wmpExample.Ctlcontrols.stop();//Accessing the controls of the MediaPLayer through code.
        }

        private void btn_PlayVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files | *.* | Video | *.mp4";
            ofd.Title = "Open your Video!";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Making sure the folder picked when the dialog is open is the user's desktop.

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpExample.URL = ofd.FileName;
                wmpExample.Ctlcontrols.play();
            }
        }
    }
}
