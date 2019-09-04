using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pictureBoxpuzzle
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pictureBox10.Visible = false;
            //pictureBox2.Visible = false;
            //pictureBox3.Visible = false;
            //pictureBox4.Visible = false;
            //picturebox5.visible = false;
            //picturebox6.visible = false;
            //picturebox7.visible = false;
            //picturebox8.visible = false;
            //picturebox9.visible = false;
            //picturebox10.visible = false;
            //picturebox11.visible = false;
            //picturebox12.visible = false;
            //picturebox13.visible = false;
            //picturebox14.visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*<
        left to be done:
        1.)
        2.)
        3.)
        4.)
        5.)
        
        7.)
        8.)------checking for condition if after shuffling the exact same image pops-up(very rare scenario...but have to look through it)----------- 
        6.)Timer+history
        9.)restart functionality
        7.)clean the mess ;)
        8.)goto the maestro... :D
        >
        */


        //<imp> Global declarations <imp>
        
        public string path;
        OpenFileDialog openfiledialog = new OpenFileDialog();
        Image img,im1,im2,im3,im4,im5,im6,im7,im8,im9;
        Bitmap bimg1;
        int a = 0, c = 0, d = 0, lvl;
        //chk1 = 0, chk2 = 0, chk3 = 0, chk4 = 0, chk5 = 0, chk6 = 0,chk7=0,chk8=0,chk9=0;
        PictureBox[] pictureboxs1 = new PictureBox[4];
        PictureBox[] pictureboxs2 = new PictureBox[9];
        
        //<for a 4 grid puzzle> lvl=1
        RectangleF rec0 = new RectangleF(0, 0, 200, 100);
        RectangleF rec1 = new RectangleF(200, 0, 200, 100);
        RectangleF rec2 = new RectangleF(0,100, 200, 100);
        RectangleF rec3 = new RectangleF(200,100,200, 100);
        
        // <for a 9 grid puzzle> lvl=2
        RectangleF rec00 = new RectangleF(0, 0, 133, 66);
        RectangleF rec01 = new RectangleF(133, 0, 133, 66);
        RectangleF rec02 = new RectangleF(266, 0, 133, 66);
        RectangleF rec03 = new RectangleF(0, 66, 133, 66);
        RectangleF rec04 = new RectangleF(133, 66, 133, 66);
        RectangleF rec05 = new RectangleF(266, 66, 133, 66);
        RectangleF rec06 = new RectangleF(0, 132, 133, 66);
        RectangleF rec07 = new RectangleF(133, 132, 133, 66);
        RectangleF rec08 = new RectangleF(266, 132, 133, 66);

        Stopwatch stopwatch = new Stopwatch();
       
        private void pictureBox6_Click(object sender, EventArgs e)
        {

          //  chk1 = 1;
          //  check();
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox6;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox6;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            //chk2 = 1;
            //check();
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox7;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox7;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //chk6 = 1;
            //check();
            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            pictureBox11.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox11;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox11;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //chk7 = 1;
            //check();
            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            pictureBox12.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox12;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox12;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
           // chk8 = 1;
           //check();
            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
            pictureBox13.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox13;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox13;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //chk9 = 1;
            //check();
            pictureBox14.BorderStyle = BorderStyle.Fixed3D;
            pictureBox14.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox14;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox14;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            //chk3 = 1;
            //check();
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox8;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox8;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

           // chk4 = 1;
           // check();
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox9;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox9;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            //chk5 = 1;
            //check();
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            pictureBox10.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox10;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox10;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        
        //level selector
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() =="Begginner")
                lvl = 1;
            else if (comboBox1.SelectedItem.ToString()=="Hard")
                lvl = 2;
            
        }

        //RectangleF rec9 = new RectangleF(200, 0, 200, 200);
   
        PictureBox p1, p2;
       //
       void reload()
        {
            //reset global values
            path = "";
            img  = null; im1 =  null; im2  = null; im3 =  null; im4 = null; im5  = null; im6 =  null; im7  = null; im8 =  null; im9 = null;
            
            a = 0; c = 0; d = 0;
            stopwatch.Reset();

            button1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox1.SelectedItem = "Begginner";
            button3.Enabled = true;

            for (int i = 0; i < 4; i++)
                pictureboxs1[i].Enabled = true;

            for (int i = 0; i < 9; i++)
                pictureboxs2[i].Enabled = true;


            // InitializeComponent();
            //Set visibility false of picture boxes
            pictureboxes1.Visible = false;
            pictureboxes1.Image = null;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            //enable buttons

    }

        //restart button
        private void button4_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //<imp> dynamic access to image by user  <imp>
        public void button1_Click(object sender, EventArgs e)
         {
            openfiledialog.ShowDialog();
            string fileName = openfiledialog.FileName;
            textBox1.Text = fileName;
            if(fileName!=null && fileName != "")
            {
                img = Image.FromFile(fileName);
                c = img.Height;
                d=img.Width;
                bimg1 = new Bitmap(img, 400, 200);
            }
 
        }
        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           // chk3 = 1;
           // check();
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox4;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox4;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           // chk4 = 1;
           // check();
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox5;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox5;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // chk1 = 1;
           // check();
            pictureBox2.BorderStyle= BorderStyle.Fixed3D;
            pictureBox2.BackColor = Color.AliceBlue;
            if (a == 0)
            {
                a = 1;
                p1 = pictureBox2;
            }
            else if (a == 1) {
                a = 0;
                p2 = pictureBox2;
                swap(p1,p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        //swap function <imp>
        public void swap(PictureBox p1,PictureBox p2) {

            var img12 = p1.Image;
            p1.Image = p2.Image;
            p2.Image = img12;
            check();

        }
        public void swap_for_shuffle(PictureBox p1, PictureBox p2)
        {

            var img12 = p1.Image;
            p1.Image = p2.Image;
            p2.Image = img12;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           // chk2 = 1;
           // check();
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BackColor = Color.AliceBlue;

            if (a == 0)
            {
                a = 1;
                p1 = pictureBox3;
            }
            else if (a == 1)
            {
                a = 0;
                p2 = pictureBox3;
                swap(p1, p2);
                p1.BorderStyle = BorderStyle.None;
                p2.BorderStyle = BorderStyle.None;
            }

        }
        

        //<imp> SHOW BTTN: displaying the cropped images <imp>
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Choose Level first..");
            }
         
            else
            {
                pictureboxes1.Visible = true;
                pictureboxes1.BackgroundImage = bimg1;
                pictureboxs1[0] = pictureBox2;
                pictureboxs1[1] = pictureBox3;
                pictureboxs1[2] = pictureBox4;
                pictureboxs1[3] = pictureBox5;

                pictureboxs2[0] = pictureBox6;
                pictureboxs2[1] = pictureBox7;
                pictureboxs2[2] = pictureBox8;
                pictureboxs2[3] = pictureBox9;
                pictureboxs2[4] = pictureBox10;
                pictureboxs2[5] = pictureBox11;
                pictureboxs2[6] = pictureBox12;
                pictureboxs2[7] = pictureBox13;
                pictureboxs2[8] = pictureBox14;

                if (lvl == 1)
                {
                    pictureBox2.Image = bimg1.Clone(rec0, bimg1.PixelFormat);
                    pictureBox3.Image = bimg1.Clone(rec1, bimg1.PixelFormat);
                    pictureBox4.Image = bimg1.Clone(rec2, bimg1.PixelFormat);
                    pictureBox5.Image = bimg1.Clone(rec3, bimg1.PixelFormat);

                    im1 = pictureBox2.Image;
                    im2 = pictureBox3.Image;
                    im3 = pictureBox4.Image;
                    im4 = pictureBox5.Image;


                    for (int i = 0; i < 4; i++)
                        pictureboxs1[i].Visible = true;

                    for (int i = 0; i < 9; i++)
                        pictureboxs2[i].Visible=false;
                }

                if (lvl == 2)
                {
                    pictureBox6.Image = bimg1.Clone(rec00, bimg1.PixelFormat);
                    pictureBox7.Image = bimg1.Clone(rec01, bimg1.PixelFormat);
                    pictureBox8.Image = bimg1.Clone(rec02, bimg1.PixelFormat);
                    pictureBox9.Image = bimg1.Clone(rec03, bimg1.PixelFormat);
                    pictureBox10.Image = bimg1.Clone(rec04, bimg1.PixelFormat);
                    pictureBox11.Image = bimg1.Clone(rec05, bimg1.PixelFormat);
                    pictureBox12.Image = bimg1.Clone(rec06, bimg1.PixelFormat);
                    pictureBox13.Image = bimg1.Clone(rec07, bimg1.PixelFormat);
                    pictureBox14.Image = bimg1.Clone(rec08, bimg1.PixelFormat);

                    im1 = pictureBox6.Image;
                    im2 = pictureBox7.Image;
                    im3 = pictureBox8.Image;
                    im4 = pictureBox9.Image;
                    im5 = pictureBox10.Image;
                    im6 = pictureBox11.Image;
                    im7 = pictureBox12.Image;
                    im8 = pictureBox13.Image;
                    im9 = pictureBox14.Image;

                    for (int i = 0; i < 9; i++)
                        pictureboxs2[i].Visible = true;
                    for (int i = 0; i < 4; i++)
                        pictureboxs1[i].Visible=false;
                }
                // pictureBox10.Enabled = true;
                comboBox1.Enabled = false;
                // pictureBox10.Visible = true;
                shuffle();
                button3.Enabled = false;
                button1.Enabled = false;
                stopwatch.Start();
            }
        }
        // <imp> check function---modification of last popup has to be dealt 
        void check()
        {
            if (lvl == 1)
            {
                if (pictureBox2.Image == im1 && pictureBox3.Image == im2 && pictureBox4.Image == im3 && pictureBox5.Image == im4)// && chk1 == 1 && chk2 == 1 && chk3 == 1 && chk4 == 1)
                {
                    a = 2;  //dummy value to stop functioning of swap fxn;
                    stopwatch.Stop();
                    var tm = stopwatch.ElapsedMilliseconds/1000.00;
                    MessageBox.Show("puzzle stacked!!" + "\ntime elapsed : "+ tm +"seconds", "congrats", MessageBoxButtons.OK);
                    for (int i = 0; i < 4; i++)
                     pictureboxs1[i].Enabled = false;
                    //pictureBox5.Enabled = false;
                    //pictureBox4.Enabled = false;
                    //pictureBox3.Enabled = false;
                    //pictureBox2.Enabled = false;
                    
                }

            }
            else if (lvl == 2)
            {
                if (pictureBox6.Image == im1 && pictureBox7.Image == im2 && pictureBox8.Image == im3 && pictureBox9.Image == im4 && pictureBox10.Image == im5 && pictureBox11.Image == im6 && pictureBox12.Image == im7 && pictureBox13.Image == im8 && pictureBox14.Image == im9)
                {
                    // && chk1 == 1 && chk2 == 1 && chk3 == 1 && chk4 == 1)
                    //if(chk1==1&&chk2==1&&chk3==1&&chk4==1&&chk5==1&&chk6==1&&chk7==1&&chk8==1&&chk9==1)
                   
                    a = 2;  //dummy value to stop functioning of swap fxn;
                    stopwatch.Stop();
                    var tm = stopwatch.ElapsedMilliseconds / 1000.00;
                    MessageBox.Show("puzzle stacked!!" +"\ntime elapsed : "+tm + "seconds", "congrats" , MessageBoxButtons.OK);
                for (int i = 0; i < 9; i++)
                    pictureboxs2[i].Enabled = false;

                    
                }    
            }

        }

        void shuffle()
        {

            Random rnd = new Random();
            if (lvl == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    int in1 = rnd.Next(4);
                    int in2 = rnd.Next(4);
                    swap_for_shuffle(pictureboxs1[in1], pictureboxs1[in2]);
                }
                //check for same imagery after shuffling
                if (pictureBox2.Image == im1 && pictureBox3.Image == im2 && pictureBox4.Image == im3 && pictureBox5.Image == im4)
                    shuffle();

            }
            else if (lvl == 2) {
                {
                    for(int i = 0; i < 10; i++)
                    {
                        int in1 = rnd.Next(9);
                        int in2 = rnd.Next(9);
                        swap_for_shuffle(pictureboxs2[in1], pictureboxs2[in2]);
                    }
                    //check for same imagery after shuffling
                    if (pictureBox6.Image == im1 && pictureBox7.Image == im2 && pictureBox8.Image == im3 && pictureBox9.Image == im4 && pictureBox10.Image == im5 && pictureBox11.Image == im6 && pictureBox12.Image == im7 && pictureBox13.Image == im8 && pictureBox14.Image == im9)
                        shuffle();
                }
            }
        }


    }
}
