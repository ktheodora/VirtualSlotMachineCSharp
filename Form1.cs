using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KOYLOXERIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                
        }

        //this class helps us with giving attributes to the custom-made pictureboxes.
        class Image_Column : PictureBox
        {
            public int getWidth(int panel_width, int hadle_width, int total_of_cols)
            {
                //we subtract the width of the panel with the slot machine hadle so that we can have space for it
                return (panel_width - hadle_width) / total_of_cols;//dividing with the numbers of columns that the user has given us
            }
            public int getHeight(int panel_height)
            {
                return (panel_height - 150);//we subtract 150 from the panel height so that we can have some space from the borders of the panel
            }
            public int getLeft(int col_num, int array_width)
            {
               return col_num * array_width;  //we multiply the number of the column with the width that each picturebox has abd get the y coordinate.              
            }
          
        }

        //this class helps us with the automisation of the events that occur when we click the minus/plus buttons 
        class MinusPlusEvent
        {
            //declaring variables that we will use in the following methods
            string amount_type;
            int restriction;

            public MinusPlusEvent(string type, int restr)
            {//in the default constructor we give values 
                amount_type = type;
                restriction = restr;
            }

            public string upgrade_amount (string label_text)
            {//this is the method used to upgrade the amount
                int userdata = int.Parse(label_text); //we give the text that is already at the label in a integer variable
                userdata++;
                return userdata.ToString();//after we have increased the amount we make it a string again and return it
            }
            
            public string decrease_amount(string label_text)
            {//this is the method used to decrease the amount
                int userdata = int.Parse(label_text);
                if (userdata > restriction)//if the number in the label is bigger than the restriction of the case
                {
                    userdata--;
                    return userdata.ToString();
                }
                else if (userdata == 0)//only in the case that the coin amount is still 0
                {
                    MessageBox.Show("You must bet at least 1 coin.");
                    return label_text;//no change in the label's text
                }
                else //in all the other cases
                {
                    MessageBox.Show("You cannot use less than " + restriction.ToString() + " " + amount_type + ":) ");
                    return label_text;//no change in the label's text
                }
            }
        }

        //here are the methods of the plus and minus buttons of the user choice of coins
        MinusPlusEvent coinadder = new MinusPlusEvent("coin", 1);
        private void plus_Click(object sender, EventArgs e)
        {//the method for clicking the plus sign in coins
            coinamount.Text = coinadder.upgrade_amount(coinamount.Text);
            System.Media.SoundPlayer coinsound = new System.Media.SoundPlayer(string.Format("{0}//coin_sound.wav", Application.StartupPath));
            if (music_plays) //we check if the user wants sound or not
                coinsound.Play();
        }
        private void minus_Click(object sender, EventArgs e)
        {//the method for clicking the minus sign in coins
            coinamount.Text = coinadder.decrease_amount(coinamount.Text);           
        }

        //here are the methods of the plus and minus buttons of the user choice of columns
        MinusPlusEvent columnadder = new MinusPlusEvent("columns", 3);
        private void minuscolumns_Click(object sender, EventArgs e)
        {
            columnnumber.Text = columnadder.decrease_amount(columnnumber.Text);
        }

        private void pluscolumns_Click(object sender, EventArgs e)
        {
            if (int.Parse(columnnumber.Text) < 10)
                columnnumber.Text = columnadder.upgrade_amount(columnnumber.Text);
            else
                MessageBox.Show("You cannot use more than 10 choices");
        }

        //here are the methods of the plus and minus buttons of the user choice of fruit images
        MinusPlusEvent choicesadder = new MinusPlusEvent("choices", 3);
        private void minuschoices_Click(object sender, EventArgs e)
        {            
                choicenumber.Text = choicesadder.decrease_amount(choicenumber.Text);

        }

        private void pluschoices_Click(object sender, EventArgs e)
        {
            if (int.Parse(choicenumber.Text) < 10)
                choicenumber.Text = choicesadder.upgrade_amount(choicenumber.Text);
            else
                MessageBox.Show("You cannot use more than 10 choices");
        }

        //here we control the interaction of the user with the minus and plus buttons of the columns & choices

        public void enablingcolumnsandchoices(bool b)
        {
            minuschoices.Enabled = b;
            pluschoices.Enabled = b;
            minuscolumns.Enabled = b;
            pluscolumns.Enabled = b;
        }

        private void autorb_CheckedChanged(object sender, EventArgs e)
        {//if the automatic choice is click the buttons are disabled
            enablingcolumnsandchoices(false);
        }
        private void customrb_CheckedChanged(object sender, EventArgs e)
        {//if the customised choice is click the buttons are enabled
            enablingcolumnsandchoices(true);
        }

        //here we write the code for the menu bar choices
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //if the user wants to withdraw the previous amount and set everything to 0
        private void startNewGameRefreshCoinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinamount.Text = "0";
            coinsgiven.Text = "0";
            coinsearned.Text = "0";
        }

        bool music_plays = true;//default price of the bool that indicates if a use wants sound or not
        private void onOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (music_plays)
            {
                music_plays = false;
            }
            else
            {
                music_plays = true;
            }
        }

        //some explanation about the game rules
        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SLOT MACHINE RULES:\n1. Choose the amount of coins that you want. (Choose more than 1 coin)\n2. Choose either automatic or customised version (in customised version you determine the amount of columns and images displayed - choose between 3 & 10)\n3. Click the 'GO' button and test your luck!", "Game Rules");
        }

        //some explanation about the app 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Name: Virtual Slot Machine\nVersion: 1.0\nExecutive Programmer: Theodora-Paraskevi Kyriakou\nAssistant Programmers:Nikolaos Segos - Vasilios Smiris\nProject Built under the C# Programming examination of the Department of Informatics, University of Piraeus.");
        }


        /*we declare here the variables that will store the number of columns and choices 
        because we will need them at the tick of the clock*/
        int columns, choices;
        Image_Column[] Column;
        List<string> imagepaths;
        //the button that will start the game
        private void button1_Click(object sender, EventArgs e)
        {
            bool booly = true;
            if (autorb.Checked == true)
            {//if the user wants the basic implementation
                columns = 3;//set default prices
                choices = 4;
            }
            else if (customrb.Checked == true)
            {//orelse set his own choices
                columns = int.Parse(columnnumber.Text);
                choices = int.Parse(choicenumber.Text);
            }
            else//if the user hasn't checked any option
            {
                MessageBox.Show("Please choose either automatic or custom version!");
                booly = false;
            }
            //check if user has bet at least one coin
            if (coinamount.Text == "0")
            {
                MessageBox.Show("You have to bet at least 1 coin!");
                booly = false;
            }
            if (booly == true)//if everything is correct
            {
                //hide buttons and labels that go through the panel
                minuscolumns.SendToBack();
                pluscolumns.SendToBack();
                minuschoices.SendToBack();
                pluschoices.SendToBack();
                columnnumber.SendToBack();
                choicenumber.SendToBack();
                //start building the requested game
                Column = new Image_Column[columns];
                //setting properties for each column
                for (int i = 0; i < columns; i++)
                {
                    Column[i] = new Image_Column();
                    //Use of the Image_Column methods
                    Column[i].Width = Column[i].getWidth(game.Width, slothadle.Width, columns);
                    Column[i].Height = Column[i].getHeight(game.Height);                   
                    Column[i].Left = Column[i].getLeft(i, Column[i].Width);
                    Column[i].Top = 75;//we set it 75 as we want some border space on the top that can fit our 'VIRTUAL SLOT MACHINE' label
                    //Use of the picture box class methods                    
                    Column[i].BorderStyle = BorderStyle.FixedSingle;
                    Column[i].BackColor = Color.White;
                    Column[i].Visible = true;
                    //add it to the panel
                    game.Controls.Add(Column[i]);
                }
                //we create a list with as many images as the user has chosen
                imagepaths = new List<string>();
                for (int i= 1; i <= choices; i++)
                {
                   imagepaths.Add("img" + i.ToString() + ".jpg");
                }
                game.Visible = true;
                coinsgiven.Text = (int.Parse(coinsgiven.Text) + int.Parse(coinamount.Text)).ToString();
                timer1.Start();
                //we use the show function so that the gif can play more easily
                slothadle.Show();
                if (music_plays)
                {
                    System.Media.SoundPlayer handle_sound = new System.Media.SoundPlayer(string.Format("{0}//slot_handle.wav", Application.StartupPath));
                    handle_sound.Play();
                }
            }                          
        }

        //the clockcounter variable will keep track of every timer tick
        //and help us with stopping the timer at the right time
        int clockcounter;
        //we declare a random variable to help us with mixing the pictures
        Random my_random = new Random();        

        //we use this timer in order to simulate the image movement of the columns
        //and generate a new image everytime the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clockcounter < 10)//in the first second ticking
            {//we keeping showing the slot handle
                if ( clockcounter == 9)
                {
                    slothadle.Enabled = false;
                }//and when the first second finishes we stop it
            }
            else if (clockcounter < 20)//then for one second we mix the images
            { 
                for (int i = 0; i < columns; i++)
                {
                    string randomimg = imagepaths[my_random.Next(choices)];
                    Column[i].Image = Image.FromFile(randomimg);
                    if (clockcounter == 19)//we only give a tag at the last tick 
                    {//so that we can save some memory
                        Column[i].Image.Tag = randomimg;
                    }
                    Column[i].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else//when it reaches 2 seconds
            {//we stop showing pictures and we compare the last images of each column
                int imgcount = 0;
                for (int i = 0; i < (Column.Length-1); i++)
                {//check for jackpot
                    if (Column[i].Image.Tag == Column[i+1].Image.Tag)
                    {
                        imgcount++;
                    }
                }
                string MessagBoxString;//this is the string that we are going to store the sentence 
                //that the message box will announce to the player at the end of the game
                System.Media.SoundPlayer resultsound; //this is the sound file that will be heard when the results are announced to the user
                if (imgcount == Column.Length - 1)//if the image count equals with all the comparisons made at the previous loop
                {//we have a winner
                   int wincoins = (choices + columns) * int.Parse(coinamount.Text);//this is a way to calculate how many coins the user won
                   MessagBoxString = "ROUND IS OVER. \nCONGRATS! YOU WON ( choices = "+ choices + " + columns = " + columns +") * coins bet = " + coinamount.Text+" = "+ wincoins.ToString() +" coins! \nCLICK 'OK' TO GO BACK TO MAIN MENU.\n";
                   coinsearned.Text = (wincoins + int.Parse(coinsearned.Text)).ToString();
                   resultsound = new System.Media.SoundPlayer(string.Format("{0}//winning_sound.wav", Application.StartupPath));
                }
                else//the images doesn't match all together
                {
                    MessagBoxString = "ROUND IS OVER. \nYOU LOST! \nCLICK 'OK' TO GO BACK TO MAIN MENU.\n" ;
                    resultsound = new System.Media.SoundPlayer(string.Format("{0}//fail_sound.wav", Application.StartupPath));                    
                }
                if (music_plays)
                    resultsound.Play();
                timer1.Stop();//we stop the timer
                if (MessageBox.Show(MessagBoxString, "RESULT") == System.Windows.Forms.DialogResult.OK)
                {//if the user clicks ok at the message box
                    resultsound.Stop();//stop the result music and show the home page
                    for (int i = 0; i < Column.Length; i++)
                    {
                        Column[i].Visible = false;
                        //the previous pictureboxes are no longer visible so that they don't hide the next ones
                    }
                    game.Visible = false;                                      
                    clockcounter = -1; //set the clockcounter variable to -1 so it can be ready for the next round                      
                }
            }
            clockcounter++;//increase the clockcounter everytime there is a tick
        }
    }
}
