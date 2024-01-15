using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matala7
{
    public partial class Form1 : Form
    {
        Queue<Woman> AllWomans = new Queue<Woman>();
        List<Man> AllMen = new List<Man>();
        List<Couple> Coupels = new List<Couple>();
        
        public Form1()
        {
            InitializeComponent();
            ReadFromFile(AllWomans,AllMen);
            foreach(Woman W in AllWomans)
            {
                lbxWoman.Items.Add(W.ToString());
            }
        }
        static void ReadFromFile(Queue<Woman> AllWomans, List<Man> AllMen)
        {
            
            string path1 = "women.txt";
            string[] personLines = File.ReadAllLines(path1);
            foreach (string W in personLines)//every line will be splited, and each value will be filed of the object
            {
                string[] womanSplit = W.Split("-");
                string[] womanSplit2 = womanSplit[3].Split(">");
                Woman W1 = new Woman(womanSplit[0], womanSplit[1], womanSplit[2], int.Parse(womanSplit2[1]));
                AllWomans.Enqueue(W1);//add the current readed woman to the queue
            }

            string path2 = "men.txt";
            personLines = File.ReadAllLines(path2);
            foreach (string M in personLines)
            {
                string[] ManSplit = M.Split("-");
                string[] manSplit2 = ManSplit[3].Split(">");
                Man M1 = new Man(ManSplit[0], ManSplit[1], ManSplit[2], double.Parse(manSplit2[1]));
                AllMen.Add(M1);
            }
        }

        private void btnFindMatch_Click(object sender, EventArgs e)
        {
            int check = 0;//if match success it will be 1,reset every click
            Woman W1 = AllWomans.Dequeue();
            lbxWoman.Items.RemoveAt(0);
            foreach (Man M in AllMen)
            {
                if (W1.LastName == M.LastName)
                {
                    Couple c1 = new Couple(M, W1);
                    Coupels.Add(c1);//add to couple class
                    lbxCouples.Items.Add(c1.ToString());
                    check= 1;
                }
            }
            if (check == 0)//no match
            {
                MessageBox.Show($"No match found for {W1.FirstName} {W1.LastName}", "", MessageBoxButtons.OK);
                lbxSingleWoman.Items.Add($"{W1.FirstName} {W1.LastName} ({W1.NumberOfKids})");
            }
            if(AllWomans.Count == 0)//queue over
            {
                btnFindMatch.Enabled = false;
                Coupels.Sort();
                Coupels.Reverse();//order of ABC
                lbxCouples.Items.Clear();
                foreach (Couple c in Coupels)
                {
                    lbxCouples.Items.Add(c.ToString());
                }
                check = 0;//now check if man have couple, yes? -> 1
                foreach(Man m in AllMen)//pass all men, if not apear in couple list add it to single man list box
                {
                    foreach (Couple c in Coupels)
                    {
                        if (m.LastName == c.ManCouple.LastName)//last name is unique
                            check = 1;//found match
                    }
                    if (check == 0)//no couple match to current man
                        lbxSingleMan.Items.Add($"{m.FirstName} {m.LastName} ({m.DistanceFromWork})");
                    check = 0;//reset
                }
                panelSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> StringConvert = new List<string>();
            if (rdbSman.Checked == true)
            {
                foreach (var item in lbxSingleMan.Items)
                {
                    StringConvert.Add(item.ToString());
                }
                File.WriteAllLines("single_men.txt",StringConvert);
                MessageBox.Show("men saved!", "", MessageBoxButtons.OK);
                return;
            }
            if (rdbSwoman.Checked == true)
            {
                foreach (var item in lbxSingleWoman.Items)
                {
                    StringConvert.Add(item.ToString());
                }
                File.WriteAllLines("single_women.txt", StringConvert);
                MessageBox.Show("women saved!", "", MessageBoxButtons.OK);
                return;
            }
            if (rdbCouples.Checked == true)
            {
                foreach (Couple c in Coupels)
                {
                    StringConvert.Add(c.ToString());
                }
                File.WriteAllLines("couples.txt", StringConvert);
                MessageBox.Show("couple saved!", "", MessageBoxButtons.OK);
                return;
            }
             MessageBox.Show("Please choose an option - save men,women,couples to file", "", MessageBoxButtons.OK);
            
        }
    }
}
