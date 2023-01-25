using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game_X
{
    public partial class PlayForm : Form
    {
        private Random rnd = new Random();
        private List<PictureBox> pictures = new List<PictureBox>();
        private List<Image> images = new List<Image>
        {
            Image.FromFile("../../Pictures/Hexagon.png"),
            Image.FromFile("../../Pictures/Circle.png"),
            Image.FromFile("../../Pictures/Cube.png"),
            Image.FromFile("../../Pictures/Triangle.png"),
            Image.FromFile("../../Pictures/Quadrilateral.png"),
            Image.FromFile("../../Pictures/Pentagon.png"),
            Image.FromFile("../../Pictures/Hearth.png"),
            Image.FromFile("../../Pictures/Square.png"),
            Image.FromFile("../../Pictures/Star.png"),
            Image.FromFile("../../Pictures/Elipse.png")
        };

        private PictureBox firstChoice { get; set; }
        private PictureBox secondChoice { get; set; }

        public PlayForm()
        {
            InitializeComponent();

            AddImage();
            HidePictures();

        }

        private void PlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;

            if (firstChoice == null)
            {
                firstChoice = pic;
                pic.Image = (Image)pic.Tag;
                this.firstChoice.Click -= PictureBox_Click;
            }

            else if (secondChoice == null)
            {
                secondChoice = pic;
                pic.Image = (Image)pic.Tag;

                //Dobawq tochki
                if (firstChoice.Image == secondChoice.Image)
                {
                    this.firstChoice.Click -= PictureBox_Click;
                    this.secondChoice.Click -= PictureBox_Click;

                    scoreLabel.Text = (int.Parse(scoreLabel.Text) + 10).ToString();
                }
                else if (int.Parse(scoreLabel.Text) != 0)
                {
                    scoreLabel.Text = (int.Parse(scoreLabel.Text) - 5).ToString();
                }

                Task.Delay(600).ContinueWith(t =>
                {

                    if (firstChoice.Image == secondChoice.Image)
                    {
                        firstChoice.Tag = null;
                        secondChoice.Tag = null;
                    }
                    else
                    {
                        foreach (var picture in pictures)
                        {
                            if (picture.Tag != null)
                            {
                                picture.Image = Image.FromFile("../../Pictures/NormalModeCover.png");
                            }
                        }
                    }

                    if (pictures.All(picture => picture.Tag == null))
                    {
                        MessageBox.Show("CONGRATS YOU WON!\nIf you want to play again press Restart");
                    }

                    firstChoice = null;
                    secondChoice = null;
                });

                this.firstChoice.Click += PictureBox_Click;
            }
        }

        private void AddImage()
        {
            pictures.Add(pictureBox1);
            pictures.Add(pictureBox2);
            pictures.Add(pictureBox3);
            pictures.Add(pictureBox4);
            pictures.Add(pictureBox5);
            pictures.Add(pictureBox6);
            pictures.Add(pictureBox7);
            pictures.Add(pictureBox8);
            pictures.Add(pictureBox9);
            pictures.Add(pictureBox10);
            pictures.Add(pictureBox11);
            pictures.Add(pictureBox12);
            pictures.Add(pictureBox13);
            pictures.Add(pictureBox14);
            pictures.Add(pictureBox15);
            pictures.Add(pictureBox16);
            pictures.Add(pictureBox17);
            pictures.Add(pictureBox18);
            pictures.Add(pictureBox19);
            pictures.Add(pictureBox20);

            var shuffled = images.OrderBy(picture => Guid.NewGuid()).ToList();
            images = shuffled;

            for (int i = 0; i < images.Count; i++)
            {
                pictures[i].Tag = images[i];
                pictures[i + 10].Tag = images[i];
            }
        }

        private void HidePictures()
        {
            foreach (var picture in pictures)
            {
                picture.Image = Image.FromFile("../../Pictures/NormalModeCover.png");
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayForm play = new PlayForm();
            play.ShowDialog();
        }

        private void GoToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartGameForm form = new StartGameForm();
            form.ShowDialog();
        }
    }
}