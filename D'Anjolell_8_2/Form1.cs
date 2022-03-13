using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Code that closes the program
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare Variables
            string userString;
            int totalWords;
            double totalLetters;
            double averageLetters;

            //Get input from user
            userString = txtEntry.Text;

            //Call countwords method and set word total variable equal to returned value
            totalWords = countWords(userString);

            //Call countletters method and set letter total equal to returned value
            totalLetters = countLetters(userString);

            //Find the average number of letters between all the words
            averageLetters = totalLetters / totalWords;

            //Output
            lblWords.Text = "Number of Words: " + totalWords.ToString();
            lblLetters.Text = "Average Number of Letters: " + averageLetters.ToString(".00");
        }

        private int countWords(string str)
        {
            //Declare variables
            int wordsNum = 0;
            Boolean wordBegin = false;

            //For loop to go through the word
            for (int i = 0; i < str.Length; i++)
            {
                //If statement to determine if the character is a letter and not a space
                if (i == 0 && !char.IsWhiteSpace(str[i]))
                {
                    wordBegin = true;
                }
                else if (i > 0 && char.IsWhiteSpace(str[i - 1]))
                {
                    wordBegin = true;
                }
                else
                {
                    wordBegin = false;
                }

                //If statement to see if it is a start of a new word
                if (wordBegin == true && (char.IsLetterOrDigit(str[i]) || char.IsPunctuation(str[i])))
                {
                    //Increment the word counter
                    wordsNum++;
                }
            }

            //Return number of words back to main
            return wordsNum;
        }

        private int countLetters(string str)
        {
            //Declare variables
            int lettersNum = 0;
            string[] wordArray = str.Split(' ');

            //For loop to go through each word
            for (int i = 0; i < wordArray.Length; i++)
            {
                //Add the length of each word to the total number of letters
                lettersNum += wordArray[i].Length;
            }

            //Return number of letters back to main
            return lettersNum;
        }
    }
}
