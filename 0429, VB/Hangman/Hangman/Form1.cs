using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class Form1 : Form
    {
        int guessNumber = 1;
        char guess;

        public Form1()
        {
            InitializeComponent();
        }

        string rightAnswer = null;
        string rightAnswer2 = null;
    }

        string returnWordSwedish()
        {
            Random rnd1 = new Random();
            string[] allLines = File.ReadAllLines("C:\\Bibliotek\\Swedish.txt");
            string rightWord = allLines[rnd1.Next(allLines.Length)];
            return rightWord;
        }


        private void btnGissa_Click(object sender, EventArgs e) //Knapp för att gissa
        {
            guess = char.Parse(textBox2.Text); //Här gör man sin gissning med en bokstav.
            textBox2.Clear();
                       
           //För varje gissning som är fel så blir man mer hängd. guessNumber ökar med ett för varje felgissning så att rätt bild laddas.
      
                if (!rightAnswer.Contains(guess) && guessNumber == 1)
                    pictureBox1.Load("fel1.gif");
                if (!rightAnswer.Contains(guess) && guessNumber == 2)
                    pictureBox1.Load("fel2.gif");
                if (!rightAnswer.Contains(guess) && guessNumber == 3)
                    pictureBox1.Load("fel3.gif");
                if (!rightAnswer.Contains(guess) && guessNumber == 4)
                    pictureBox1.Load("fel4.gif");

                if (!rightAnswer.Contains(guess) && guessNumber == 5)  //Efter 5 gissningar så är man hängd 
                {
                    pictureBox1.Load("fel5.gif");
                    btnGissa.Enabled = false;
                    lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
                }

                if (!rightAnswer.Contains(guess)) //Om gissningen inte är rätt ökas guessNumber för nästa bild.
                    guessNumber++;

                else if (rightAnswer.Contains(guess)) //Om gissningen ÄR rätt så minskas bokstäver att gissa på.
                {
                    
                    while (rightAnswer.IndexOf(guess) != -1) //Om ordet innehåller mer än en bokstav av samma sort, ser denna till att alla visas.
                    {                                        //Om du skriver in t t.ex. så letar denna upp alla t. När den inte hittar fler är index -1

                        label1.Text += guess.ToString();

                        char test = guess;

                        int index = rightAnswer.IndexOf(guess); //Tar reda på indexet för bokstaven du gissade på

                        //rightAnswer3.Replace('_', test);
                                                  
                        if (index != -1) //Om det inte är tomt på bokstäver
                        {
                         
                             if (rightAnswer.Length == 1)
                                btnGissa.Enabled = false;                        

                              rightAnswer = rightAnswer.Remove(index, 1); //"Index" är numret för bokstaven, "1" är hur många som ska tas bort.
                        }
                        else
                            btnGissa.Enabled = false;
                    
                    }//End of while
                }
                  
        }//Här slutar btnGissa

   /*     private void btnNyttOrd_Click(object sender, EventArgs e) //Knapp för att lägga in ordet att gissa
        {
            rightAnswer = textBox1.Text; //Det rätta svaret lägg i en variabel för att minska för varje rätt bokstav.
            rightAnswer2 = textBox1.Text; //Det rätta svaret lägg i en variabel som inte minskar. Denna variabel visas om man gissar rätt ord.
            textBox1.Clear();

            int wordLength = rightAnswer2.Length;

            for (int i = 1; i <= wordLength; i++)
            {
                label1.Text += "_ ";
            }
        
        }  */

        private void btnGissaHelaOrdet_Click(object sender, EventArgs e) //Knappen för att gissa rätt ord (Hela ordet, inte bokstav för bokstav)
        {
            //if (textBox3.Text.Equals(rightAnswer2))
            if (textBox3.Text == rightAnswer2)
                lblSlutResultat.Text = "Du gissade rätt ord: " + rightAnswer2;
            else
            {
                pictureBox1.Load("fel5.jif");
                btnGissa.Enabled = false;
                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
            }

        }

        private void ta_Click(object sender, EventArgs e)
        {
            rightAnswer = returnWordSwedish();
            rightAnswer2 = rightAnswer;
        }
    }
}
