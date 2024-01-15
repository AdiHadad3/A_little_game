using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace matala_4_game
{
    public partial class mainGame : Form
    {
        string[] picArr = { "Animal.jpeg", "Cars.jpeg", "City.jpeg", "Food.jpeg", "Furnitures.jpeg", "Park.jpeg", "Products.jpeg", "Sea.jpeg", "SwimmingPool.jpeg", "WritingTools.jpeg" };//pictures array
        string[] arrObjects = new string[3];//array of the answers
        string[] arrMixObjects = new string[3];
        bool[] ImageSelected = { false, false, false, false, false, false, false, false, false, false };//change to true when the picture chosen
        int PicIndex;
        int colorNum;
        double score;
        int level;
        int maxLevel = 10;//the last level=victory, equal to amount of pictures
        int Chances = 0;
        int startTime = 20;
        int tickers = 20; //counts the ticks
        public mainGame(string name)
        {
            {
                InitializeComponent();
                lblName.Text = name;
                choosePicture();//to start, show random picture
                lblTimer.Text = tickers.ToString();
                timer1.Start();
            }
        }
        private void choosePicture()//select random picture from picture Array one time in a round
        {
            Random rnd = new Random();
            do
            { PicIndex = rnd.Next(0, picArr.Length); } while (ImageSelected[PicIndex]==true&&level!=maxLevel);//is the picture was used continue searching and also the game didnt over
            if (level!= maxLevel)//if didn't finish the game change photo which place in random index
            {
                pictureBox1.ImageLocation = @"..\..\..\pics\" + picArr[PicIndex];
                ImageSelected[PicIndex] = true;//picture chosen
            }
            else//finish the game
            {
                MessageBox.Show("You Won!");
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tickers--;
            lblTimer.Text = tickers.ToString();

            if (tickers == 0)//time out
            {
                timer1.Stop();
                if (Chances == 0)//only if it is the first chance
                {
                    answerList(PicIndex);//choose answers array for specific photo
                    shuffle(arrMixObjects);//mix answers array (unoriginal)
                    for (int i = 0; i < arrMixObjects.Length; i++)//initialize answers in cmb
                    {
                        cmbAnswers.Items.Add(arrMixObjects[i]);
                    }
                }
                pictureBox1.Visible = false;//hide photo
                panelTimer.Visible = false;//hide timer
                panelAns.Visible = true;//show answer panel
            }
        }
        private void answerList(int index)//select the answers of the current picture 
        {
            switch (index)
            {
                case 0:
                    addObjectsInArray("CAT", "MONKEY", "LION");//the first string=the correct answer
                    break;

                case 1:
                    addObjectsInArray("AIRPLANE", "POLICE CAR", "SCOOTER");
                    break;

                case 2:
                    addObjectsInArray("FLOWER", "TREE", "HOUSE");
                    break;
                case 3:
                    addObjectsInArray("PASTA", "EGG", "APPLE");
                    break;
                case 4:
                    addObjectsInArray("TV", "DOLL", "BED");
                    break;
                case 5:
                    addObjectsInArray("BIRD", "SLIDE", "BENCH");
                    break;
                case 6:
                    addObjectsInArray("COMPUTER", "REMOTE", "PRINTER");
                    break;
                case 7:
                    addObjectsInArray("TOWEL", "FLIP FLOPS", "BALL");
                    break;
                case 8:
                    addObjectsInArray("FISH", "BALL", "SUNGLASSES");
                    break;
                case 9:
                    addObjectsInArray("PENCIL CASE", "BOOK", "PENCIL");
                    break;
                default: addObjectsInArray("CAT", "MONKEY", "LION");
                    break;
            }
        }
        void addObjectsInArray(string o1, string o2, string o3)//initializing answers in array
        {
            arrObjects[0] = o1;//the first item in array=correct answer
            arrObjects[1] = o2;
            arrObjects[2] = o3;
            for (int i = 0; i < arrMixObjects.Length; i++)
                arrMixObjects[i] = arrObjects[i];
        }
        private void shuffle(string[] arr)//mix array
        {
            Random rnd = new Random();
            string tmpS;
            int tmpIndex;
            for (int i = 0; i < arr.Length; i++)//pass all array and mix it
            {
                tmpS = arr[i];
                tmpIndex = rnd.Next(i, arr.Length);
                arr[i] = arr[tmpIndex];
                arr[tmpIndex] = tmpS;
            }
        }
        private void cmbAnswers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnswers.SelectedItem.ToString() == arrObjects[0])//if the chosen answer==first object in original array (the correct answer)
            {
                btnContinue.Visible = true;//show continue
                lblCorrect.Text = "correct";
                lblCorrect.Visible = true;//show correct
                cmbAnswers.Items.Clear();//reset answers cmb
                if (Chances == 0)//score depands on tryes
                {
                    score++;
                    if (lblScore.ForeColor == Color.Red)//changing color of count
                    {
                        lblScore.ForeColor = Color.Blue;
                        lblLevel.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lblScore.ForeColor = Color.Red;
                        lblLevel.ForeColor = Color.Red;
                    }
                }
                else//if it the second try
                {
                    score += 0.5;
                    if (lblScore.ForeColor == Color.Red)//changing color of count
                    {
                        lblScore.ForeColor = Color.Blue;
                        lblLevel.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lblScore.ForeColor = Color.Red;
                        lblLevel.ForeColor = Color.Red;
                    }
                    Chances = 0;//reset chances
                }
                level++;
                lblLevel.Text = level.ToString();
                lblScore.Text = score.ToString();//show new score
            }
            else//incorrect answer chosen
            {
                btnContinue.Visible = true;
                lblCorrect.Text = "incorrect";
                lblCorrect.Visible = true;
                Chances++;
                if (Chances == 2)//2 chances taken
                    gameOver();
            }
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            lblReady.Visible = false;
            btnContinue.Visible = false;
            lblCorrect.Visible = false;
            if (Chances == 1)
            {
                cmbAnswers.Items.Remove(cmbAnswers.SelectedItem);//delete chosen item
            }
            else
            {
                choosePicture();//another round
                panelAns.Visible = false;
                panelTimer.Visible = true;
                pictureBox1.Visible = true;//show random picture
                startTime -= 2;
                tickers = startTime;
                lblTimer.Text = tickers.ToString();
                timer1.Start();
            }
        }
        private void gameOver()
        {
           MessageBox.Show("Game Over");
           this.Close();//back to parent, can continue or close thie window
        }
        private void lblCorrect_MouseMove(object sender, MouseEventArgs e)
        {
            Random rndC = new Random();
            colorNum = rndC.Next(0, 5);
            switch (colorNum)
            {
                case 0:
                    lblCorrect.ForeColor = Color.Pink;
                    break;
                case 1:
                    lblCorrect.ForeColor = Color.SkyBlue;
                    break;
                case 2:
                    lblCorrect.ForeColor = Color.Chartreuse;
                    break;
                case 3:
                    lblCorrect.ForeColor = Color.MediumOrchid;
                    break;
                case 4:
                    lblCorrect.ForeColor = Color.Crimson;
                    break;
                default:
                    lblCorrect.ForeColor = Color.Orange;
                    break;
            }
        }
        private void btnContinue_MouseMove(object sender, MouseEventArgs e)
        {
            lblReady.Visible = true;
        }
    }
}
