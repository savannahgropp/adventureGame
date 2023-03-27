using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;

        //randoms
        Random randGen = new Random();
        int randomValue;

        //sounds
        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.workingMilkMan);
        SoundPlayer clickSound = new SoundPlayer(Properties.Resources.workingButtonClick);

        public Form1()
        {
            InitializeComponent();

            //opening page
            optionLabel.Text = "You wake up to a blinding light shining in your face. You can't seem to remember anything. You panick. Do you run?";
            option1.Visible = true;
            option1.Text = "Run!";
            option2.Visible = true;
            option2.Text = "Wait";
            option3.Visible = false;
            pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 51)
                {
                    page = 2;
                }
                else
                {
                    page = 33;
                }
            }
            else if (page == 2)
            {
                page = 3;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                //B
                page = 51;
            }
            else if (page == 6)
            {
                page = 7;
            }
            else if (page == 7)
            {
                //B
                page = 51;
            }
            else if (page == 8)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 36;
            }
            else if (page == 10)
            {
                page = 36;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 36;
            }
            else if (page == 13)
            {
                //B
                page = 51;
            }
            else if (page == 15)
            {
                //B
                page = 51;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                //B
                page = 51;
            }
            else if (page == 18)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 81)
                {
                    page = 19;
                }
                else
                {
                    page = 20;
                }
            }
            else if (page == 19)
            {
                page = 36;
            }
            else if (page == 20)
            {
                //B
                page = 51;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 23;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 25;
            }
            else if (page == 25)
            {
                page = 36;
            }
            else if (page == 26)
            {
                //B
                page = 51;
            }
            else if (page == 27)
            {
                page = 28;
            }
            else if (page == 28)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 51)
                {
                    page = 2;
                }
                else
                {
                    page = 33;
                }
            }
            else if (page == 29)
            {
                //B
                page = 51;
            }
            else if (page == 30)
            {
                //B
                page = 51;
            }
            else if (page == 31)
            {
                //B
                page = 51;
            }
            else if (page == 32)
            {
                //B
                page = 51;
            }
            else if (page == 33)
            {
                page = 34;
            }
            else if (page == 34)
            {
                page = 35;
            }
            else if (page == 35)
            {
                //B
                page = 51;
            }
            else if (page == 36)
            {
                page = 34;
            }
            else if (page == 37)
            {
                //B
                page = 51;
            }
            else if (page == 38)
            {
                page = 39;
            }
            else if (page == 39)
            {
                //B
                page = 51;
            }
            else if (page == 40)
            {
                page = 41;
            }
            else if (page == 41)
            {
                page = 42;
            }
            else if (page == 42)
            {
                page = 43;
            }
            else if (page == 43)
            {
                //B
                page = 51;
            }
            else if (page == 44)
            {
                page = 46;
            }
            else if (page == 46)
            {
                page = 1;
            }
            else if (page == 47)
            {
                //end
            }
            else if (page == 48)
            {
                //B
                page = 51;
            }
            else if (page == 49)
            {
                //B
                page = 51;
            }
            else if (page == 50)
            {
                //B
                page = 51;
            }
            else if (page == 51)
            {
                page = 1;
            }
            else if (page == 52)
            {
                //end
            }

            pageSwitch();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 50;
            }
            else if (page == 2)
            {
                page = 16;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                //B
                page = 52;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                //B
                page = 52;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 15;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                //B
                page = 52;
            }
            else if (page == 15)
            {
                //B
                page = 52;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                //B
                page = 52;
            }
            else if (page == 18)
            {
                page = 21;
            }
            else if (page == 19)
            {
                page = 32;
            }
            else if (page == 20)
            {
                //B
                page = 52;
            }
            else if (page == 21)
            {
                page = 32;
            }
            else if (page == 22)
            {
                page = 30;
            }
            else if (page == 23)
            {
                page = 27;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 25)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 51)
                {
                    page = 37;
                }
                else
                {
                    page = 38;
                }
            }
            else if (page == 26)
            {
                //B
                page = 52;
            }
            else if (page == 27)
            {
                page = 29;
            }
            else if (page == 28)
            {
                page = 50;
            }
            else if (page == 29)
            {
                //B
                page = 52;
            }
            else if (page == 30)
            {
                //B
                page = 52;
            }
            else if (page == 31)
            {
                //B
                page = 52;
            }
            else if (page == 32)
            {
                //B
                page = 52;
            }
            else if (page == 33)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 51)
                {
                    page = 37;
                }
                else
                {
                    page = 38;
                }
            }
            else if (page == 34)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 51)
                {
                    page = 37;
                }
                else
                {
                    page = 38;
                }
            }
            else if (page == 35)
            {
                //B
                page = 52;
            }
            else if (page == 36)
            {
                randomValue = randGen.Next(1, 101);

                if (randomValue < 51)
                {
                    page = 37;
                }
                else
                {
                    page = 38;
                }
            }
            else if (page == 37)
            {
                //B
                page = 52;
            }
            else if (page == 38)
            {
                page = 40;
            }
            else if (page == 39)
            {
                //B
                page = 52;
            }
            else if (page == 40)
            {
                page = 49;
            }
            else if (page == 41)
            {
                page = 48;
            }
            else if (page == 42)
            {
                page = 44;
            }
            else if (page == 43)
            {
                //B
                page = 52;
            }
            else if (page == 44)
            {
                page = 47;
            }
            else if (page == 46)
            {
                page = 1;
            }
            else if (page == 47)
            {
                //end
            }
            else if (page == 48)
            {
                //B
                page = 52;
            }
            else if (page == 49)
            {
                //B
                page = 52;
            }
            else if (page == 50)
            {
                //B
                page = 52;
            }
            else if (page == 51)
            {
                page = 1;
            }
            else if (page == 52)
            {
                //end
            }
            pageSwitch();
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (page == 22)
            {
                page = 31;
            }
            pageSwitch();
        }

        private void pageSwitch()
        {
            switch (page)
            {
                case 1:
                    optionLabel.Text = "You wake up to a blinding light shining in your face. You can't seem to remember anything. You panick. Do you run?";
                    
                    option1.Visible = true;
                    option1.Text = "Run!";
                    option2.Visible = true;
                    option2.Text = "Wait";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 2:
                    optionLabel.Text = "Your hands are tied. You try to escape but cant. A person walks in.";
                    option1.Text = "Socialize!";
                    option2.Visible = true;
                    option2.Text = "Death stare until they leave.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 3:
                    optionLabel.Text = "You decided to socialize. Be quick before they leave. What do you say?";
                    option1.Text = "Something semi-normal";
                    option2.Text = "Make literal robot sounds.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 4:
                    optionLabel.Text = "The person looks at you confused. 'you shouldn't be talking,' they say and leave quickly.";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel.Text = "A big fat white man enters the room with a milk crate in his hand. He bashes you over the head and you are knocked out from the impact.";
                    option1.Visible = true;
                    option1.Text = "Play again.";
                    option2.Visible = true;
                    option2.Text = "Accept the defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 6:
                    optionLabel.Text = "The person jumps up and cheers. You seem to have made their day but don't understand why.";
                    option1.Text = "Scream!";
                    option2.Text = "Sit and stare at her.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 7:
                    optionLabel.Text = "The person steps back in shock with a petrified look on their face. They steps back into the hallway.";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel.Text = "She returns moments later with a big fat white man. The man throws a glass of milk at you which releases a virus into your skin that turns you into the milk man's minion.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept the defeat.";
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 8:
                    optionLabel.Text = "The person unties you hands. This shocks you.";
                    option1.Text = "Thank them.";
                    option2.Text = "Sit as still as possible.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 9:
                    optionLabel.Text = "The person leaves the room with a smile on their face. Do you try to escape while you have the chance?";
                    option1.Text = "Yes. Run. Now.";
                    option2.Text = "No. Sit and wait until someone comes back.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 10:
                    optionLabel.Text = "The person informs you that someone will be back later to help 'set you up' and then leaves the room. You realize you have time. Do you attempt an escape?";
                    option1.Text = "Get out as fat as possible.";
                    option2.Text = "No. They're nice.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 11:
                    optionLabel.Text = "You wait and wait for hours on end and realize you have been lied to. No one is coming. No one seems to be here at all.";
                    option1.Text = "Investigate.";
                    option2.Text = "Keep waiting.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 12:
                    optionLabel.Text = "You step out of the doorway to see nothing but long empty white hallways. ";
                    option1.Text = "Run! Escape!";
                    option2.Text = "Go back in the room. You never know what's out there.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_56_53_PM;
                    clickSound.Play();
                    break;
                case 13:
                    optionLabel.Text = "You sit back on the bed and take a look around. You look out the window to find people marching around in weird patterns. You are mezmerised by this and continue staring at them.";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel.Text = "Seeing these patterns hypnotizes you. Your vision begins to fade at the edges and your bones liquify into milk.";
                    option1.Visible = true;
                    option1.Text = "Play again.";
                    option2.Visible = true;
                    option2.Text = "Accept the defeat.";
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 15:
                    optionLabel.Text = "You sit in the room for what seems like hours. Until a man walks in. It is the milk man. You realize you have been tricked as he uses his magic milk powers against you.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept the defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 16:
                    optionLabel.Text = "The person looks at you and writes something on their clip board. As they turn around to leave you gat an idea.";
                    option1.Text = "TACKLE THEM.";
                    option2.Text = "No. Bad idea. Just sit and wait.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 17:
                    optionLabel.Text = "You fool. You forgot your hands were tied. The person turns back around and looks at you like you are insane (because you are) and yells something down the hallway.";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(4000);

                    optionLabel.Text = "A big fat white man marches in with a bottle and force feeds you like a baby. Your vision fades to white and you turn into a milk man minion.";
                    option1.Visible = true;
                    option1.Text = "Play again.";
                    option2.Visible = true;
                    option2.Text = "Accept the defeat.";
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 18:
                    optionLabel.Text = "You let the person leave the room in peace. You look down only to realize your hands are still tied. Good thing you didn't try to tackle them.";
                    option1.Text = "Attempt to untie your hands.";
                    option2.Text = "Sit alone in your own thoughts.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 19:
                    optionLabel.Text = "You successfully broke your hands free!";
                    option1.Text = "ESCAPE";
                    option2.Text = "Sit and wait.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 20:
                    optionLabel.Text = "You fail to untie your hands and a person hears you struggle. An alarm sounds and milk begins pouring from the cracks in the ceiling. The milk man has taken your soul with his litres of milk and you become one of his minions.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 21:
                    optionLabel.Text = "Sitting in your own thoughts for awhile has led you to immense boredom. You realize you haven't ate in awhile.";
                    option1.Text = "Scream for food.";
                    option2.Text = "Keep waiting.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 22:
                    optionLabel.Text = "The door opens and people rush in thinking there is an emergency. ";
                    option1.Text = "Beg them for food.";
                    option2.Text = "Try to break your hands free and fight them.";
                    option3.Visible = true;
                    option3.Text = "Scream at the top of your lungs.";
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 23:
                    optionLabel.Text = "The people call you insane and say that you will get fed if you cooperate. Do you listen?";
                    option1.Text = "Yes.";
                    option2.Text = "No. Scream again.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 24:
                    optionLabel.Text = "They agree to untie you hands if you agree to bag milk for the rest of your life.";
                    option1.Text = "Agree. A bigger victory can come out of this.";
                    option2.Text = "Disagree. No one will keep you hostage.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 25:
                    optionLabel.Text = "They untie your hands and you realize this place isn't as bad as it seems. Even so, do you try to escape?";
                    option1.Text = "Yes. Run";
                    option2.Text = "No. This is a nice place.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 26:
                    optionLabel.Text = "They have had enough of you. The milk man spawns in and murders you because of your incompitence.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 27:
                    optionLabel.Text = "They give you one more chance to listen. Do you cooperate?";
                    option1.Text = "Listen to them. Maybe something good can come out of this.";
                    option2.Text = "Don't listen.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_7_18_21_PM;
                    clickSound.Play();
                    break;
                case 28:
                    optionLabel.Text = "It was a trap. You were under the impression of a safe building but it was a lie. There is no safe place when the milk man is near. The milk man senses your fear and spawns in behind you. He wipes your memory once again.";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel.Text = "You wake up to a blinding light shining in your face. You can't seem to remember anything. You panick. Do you run?";
                    option1.Text = "Run!";
                    option2.Text = "Wait";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 29:
                    optionLabel.Text = "Now you're just asking for it. The milk man takes you with his evil wrath to the depths of the universe.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 30:
                    optionLabel.Text = "The people freak out and call you insane. They stab you with a needle filled with milk. The milk takes over your bloodstream and your vision turns white. You turn into a milk man minion.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 31:
                    optionLabel.Text = "You have alerted the milk man. He doesn't even waste a moment before filling your bloodstream with milk.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 32:
                    optionLabel.Text = "poor choice. No one came for hours while you were starving to death. The door opens and a bunch of milk ogres march in and murder you.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 33:
                    optionLabel.Text = "Your hands are tied but you manage to break free. You don't have a plan. There's a window behind you.";
                    option1.Text = "Take the door.";
                    option2.Visible = true;
                    option2.Text = "Take the window.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 34:
                    optionLabel.Text = "You take a step out the door and immediately regret your decision. You turn back around. Maybe someone is coming soon. Do you go wait for someone to come or go through the window?";
                    option1.Text = "wait";
                    option2.Text = "jump out the window";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 35:
                    optionLabel.Text = "A person walks in after a few minutes. They notice your hands are untied. they freak out and before you can explain, it's too late. the milk man is summoned and it's all over.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 36:
                    optionLabel.Text = "Your hands are free. Time to escape!";
                    option1.Text = "Take the door";
                    option2.Text = "take the window";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_44_11_AM;
                    clickSound.Play();
                    break;
                case 37:
                    optionLabel.Text = "You fail to open the window. The milk man spawns in behind you after hearing your struggle. Death. Destruction. Domination.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 38:
                    optionLabel.Text = "You make it out of the window and jump onto the grass. You see that you are in a courtyard with dozens of people around you.";
                    option1.Text = "Close the window.";
                    option2.Text = "Run. Zoom.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_31_15_AM;
                    clickSound.Play();
                    break;
                case 39:
                    optionLabel.Text = "In an attempt to close the window, a person from inside sees you and alerts the authorities. You are taken to milk prison for trying to escape and have to bag milk for eternity. Play again?";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 40:
                    optionLabel.Text = "By leaving the window open, you are aware of a clue of where you went. You have to move quick. You begin walking towards the people and consider your options.";
                    option1.Text = "Blend in.";
                    option2.Text = "Ask for help.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_31_15_AM;
                    clickSound.Play();
                    break;
                case 41:
                    optionLabel.Text = "You're a natural at this. No one even notices you are there. Do you test your luck and keep going or change strategies and hide.";
                    option1.Text = "Keep going";
                    option2.Text = "Hide";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_31_15_AM;
                    clickSound.Play();
                    break;
                case 42:
                    optionLabel.Text = "You walk like you own the place. No one even notices. You see a giant glass door and a road outside. You recognize the road. Your memory is coming back. Do you run to the door or keep blending in while walking towards it?";
                    option1.Text = "Run";
                    option2.Text = "Walk";
                    option3.Visible = false;
                    clickSound.Play();
                    break;
                case 43:
                    optionLabel.Text = "The people notice you are not one of them. Then you realize they are the milk man army. You have screwed yourself. Play again?";
                    option1.Text = "Play again";
                    option2.Text = "Accept defeat";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 44:
                    optionLabel.Text = "While you are walking towards the door, you realize you are walking through the milk man army. Even so, you use your skills to navigate and look like you are a part of them. ";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_31_15_AM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    optionLabel.Text = "You manage to make your way to the giant door and get out of the building. You have escaped. Congratulations you win.";
                    option1.Visible = true;
                    option1.Text = "Play again.";
                    option2.Visible = true;
                    option2.Text = "No.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_31_15_AM;
                    clickSound.Play();
                    break;
                case 46:
                    optionLabel.Text = "Congratulations. You won!";
                    option1.Text = "Click here to return to title screen";
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_39_23_AM;
                    clickSound.Play();
                    break;
                case 47:
                    optionLabel.Text = "Congratulations. See you next time!";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_39_23_AM;
                    clickSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    Application.Exit();
                    break;
                case 48:
                    optionLabel.Text = "You can NEVER hide from the milk man.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 49:
                    optionLabel.Text = "You ask someone for help but quickly realize these arent regular people. They are a milk man army. They attack you unitl you bleed out onto the grass.";
                    option1.Text = "Play again.";
                    option2.Text = "Accept defeat.";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 50:
                    optionLabel.Text = "You fool. You have overestimated the speed of the milkman. He peeks through the doorway after 15 minutes of waiting for something to happen. Your hands are tied. There is no escape from the milk man.";
                    option1.Text = "Play again";
                    option2.Text = "Accept defeat";
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();
                    break;
                case 51:
                    optionLabel.Text = "You are one brave soul.";
                    option1.Text = "Return to title page";
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_27_9_39_23_AM;
                    clickSound.Play();
                    break;
                case 52:
                    optionLabel.Text = "The milk man has officially defeated you. Good try young warrior.";
                    option1.Visible = false;
                    option2.Visible = false;
                    option3.Visible = false;
                    pictureBox1.Image = Properties.Resources.Photos_2023_03_26_6_41_04_PM;
                    deathSound.Play();

                    Refresh();
                    Thread.Sleep(5000);

                    Application.Exit();
                    break;
            }
        }
    }
}
