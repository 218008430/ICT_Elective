using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame2
{
    public partial class Form1 : Form
    {
        // this will be the variables we use but can change with time
        int correctAnswer;
        int totalQuestions;
        int score;
        int questionNumber;


        public Form1()
        {
            InitializeComponent();
            //From the method generateQuestion to initialize the switch statement to ask the question for the user.
            generateQuestion(questionNumber);

            totalQuestions = 10;

        }


        //putting everything together

        //the method that will initiliaze the code to run through and generate the questions
        private void generateQuestion(int q)
        {
            //using a switch statement
            switch (q)
            {

                case 1:
                    label1.Text = "Intensiewe vorm van swart";

                    button3.Text = "Pikswart";
                    button4.Text = "Donker";
                    button5.Text = "Nag Donker";
                    button6.Text = "Myn Donker";

                    correctAnswer = 1;
                    break;

                case 2:
                    label1.Text = "Trappe van Vergelykig - Goed - Beter - ......";

                    button3.Text = "Beterste";
                    button4.Text = "Goedste";
                    button5.Text = "Beste";
                    button6.Text = "Koning";

                    correctAnswer = 3;
                    break;

                case 3:
                    label1.Text = "Intensiewe vorm van warm ";

                    button3.Text = "Hittig";
                    button4.Text = "Vuurwarm";
                    button5.Text = "Brandwarm";
                    button6.Text = "Skroeiwarm";

                    correctAnswer = 2;
                    break;

                case 4:
                    label1.Text = "Wat beteken die woord ...AWE ";

                    button3.Text = "Manier van groet?";
                    button4.Text = "Om iemand af te skrik? ";
                    button5.Text = "Om iets te koop?";
                    button6.Text = "Om te af te groet";

                    correctAnswer = 1;
                    break;

                case 5:
                    label1.Text = "Vind die werk woord - Die man kap hout";

                    button3.Text = "kap";
                    button4.Text = "hout";
                    button5.Text = "man";
                    button6.Text = "Die";

                    correctAnswer = 1;
                    break;

                case 6:
                    label1.Text = "Vind die werk woord - Sy ry fiets";

                    button3.Text = "Sy";
                    button4.Text = "fiets";
                    button5.Text = "ry";
                    button6.Text = "Geen werkwoord";

                    correctAnswer = 3;
                    break;
                case 7:
                    label1.Text = "Sinoniem vir kwaad";

                    button3.Text = "baie kwaad";
                    button4.Text = "onsteld";
                    button5.Text = "woedend";
                    button6.Text = "hartseer";

                    correctAnswer = 3;
                    break;
                case 8:
                    label1.Text = "Sinoniem vir moeg";

                    button3.Text = "energieloos";
                    button4.Text = "leweloos";
                    button5.Text = "skaap moeg";
                    button6.Text = "lam";

                    correctAnswer = 1;
                    break;

                case 9:
                    label1.Text = "Intensiewe vorm van arm";

                    button3.Text = "baie arm";
                    button4.Text = "broekskeur";
                    button5.Text = "haweloos";
                    button6.Text = "brandarm";

                    correctAnswer = 4;
                    break;
                case 10:
                    label1.Text = "Met wat begin jou naam?";

                    button3.Text = "Hoofletter";
                    button4.Text = "Die E";
                    button5.Text = "byvoeglike woord";
                    button6.Text = "deelwoord";

                    correctAnswer = 1;
                    break;



            }
        }
    }
}
          
               //     <canvas Name = "myCanvas" Background="Gold">

                  //      <TextBlock Name = "txtQuestion" TextAlignment="Center" Padeding="3" FontSize="20" Width="572" TextWrapping="Wrap" Canvas.Left="104" Canvas.Top"330">
                   //             Welcome this Game is setup to help you with your Afrikaans it will give you different questions at different levels. 
                   //     </TextBlock>

                   //   <Button Background = "Red" FontSize+"18" Click "checkAnswer" Name= "ans1" Width+"200" Heighgt= "50" Content= "Answer 1" Tag= "0" Canvas.Left= "104" Canvas.Top= "434" />
                  //    < Button Background= "Red" FontSize+"18" Click "checkAnswer" Name= "ans2" Width+"200" Heighgt= "50" Content= "Answer 1" Tag= "0" Canvas.Left= "104" Canvas.Top= "509" />
                  //    < Button Background= "Red" FontSize+"18" Click "checkAnswer" Name= "ans3" Width+"200" Heighgt= "50" Content= "Answer 1" Tag= "0" Canvas.Left= "476" Canvas.Top= "434" />
                  //    < Button Background= "Red" FontSize+"18" Click "checkAnswer" Name= "ans4" Width+"200" Heighgt= "50" Content= "Answer 1" Tag= "0" Canvas.Left= "476" Canvas.Top= "509" />


                 //   </ Canvas >
