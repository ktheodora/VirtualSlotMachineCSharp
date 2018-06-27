namespace KOYLOXERIS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pluscoins = new System.Windows.Forms.Button();
            this.minuscoins = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coinamount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autorb = new System.Windows.Forms.RadioButton();
            this.customrb = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Panel();
            this.slothadle = new System.Windows.Forms.PictureBox();
            this.coinsearned = new System.Windows.Forms.Label();
            this.coinsgiven = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewGameRefreshCoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minuscolumns = new System.Windows.Forms.Button();
            this.minuschoices = new System.Windows.Forms.Button();
            this.columnnumber = new System.Windows.Forms.Label();
            this.choicenumber = new System.Windows.Forms.Label();
            this.pluscolumns = new System.Windows.Forms.Button();
            this.pluschoices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slothadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pluscoins
            // 
            this.pluscoins.Location = new System.Drawing.Point(904, 164);
            this.pluscoins.Name = "pluscoins";
            this.pluscoins.Size = new System.Drawing.Size(30, 23);
            this.pluscoins.TabIndex = 0;
            this.pluscoins.Text = "+";
            this.pluscoins.UseVisualStyleBackColor = true;
            this.pluscoins.Click += new System.EventHandler(this.plus_Click);
            // 
            // minuscoins
            // 
            this.minuscoins.Location = new System.Drawing.Point(816, 165);
            this.minuscoins.Name = "minuscoins";
            this.minuscoins.Size = new System.Drawing.Size(30, 23);
            this.minuscoins.TabIndex = 1;
            this.minuscoins.Text = "-";
            this.minuscoins.UseVisualStyleBackColor = true;
            this.minuscoins.Click += new System.EventHandler(this.minus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(365, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIRTUAL SLOT MACHINE";
            // 
            // coinamount
            // 
            this.coinamount.AutoSize = true;
            this.coinamount.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinamount.Location = new System.Drawing.Point(867, 165);
            this.coinamount.Name = "coinamount";
            this.coinamount.Size = new System.Drawing.Size(19, 24);
            this.coinamount.TabIndex = 2;
            this.coinamount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose the amount of electronic coins that you will bet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Playbill", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Note: You win when you see the same image in each column.";
            // 
            // autorb
            // 
            this.autorb.AutoSize = true;
            this.autorb.Location = new System.Drawing.Point(517, 279);
            this.autorb.Name = "autorb";
            this.autorb.Size = new System.Drawing.Size(110, 17);
            this.autorb.TabIndex = 0;
            this.autorb.TabStop = true;
            this.autorb.Text = "Automatic Version";
            this.autorb.UseVisualStyleBackColor = true;
            this.autorb.CheckedChanged += new System.EventHandler(this.autorb_CheckedChanged);
            // 
            // customrb
            // 
            this.customrb.AutoSize = true;
            this.customrb.Location = new System.Drawing.Point(710, 279);
            this.customrb.Name = "customrb";
            this.customrb.Size = new System.Drawing.Size(117, 17);
            this.customrb.TabIndex = 1;
            this.customrb.TabStop = true;
            this.customrb.Text = "Customised Version";
            this.customrb.UseVisualStyleBackColor = true;
            this.customrb.CheckedChanged += new System.EventHandler(this.customrb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. of Columns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "No. of Fruit Choices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Choose the game version that you want:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Playbill", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(496, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.RoyalBlue;
            this.game.Controls.Add(this.slothadle);
            this.game.Controls.Add(this.coinsearned);
            this.game.Controls.Add(this.coinsgiven);
            this.game.Controls.Add(this.label9);
            this.game.Controls.Add(this.pictureBox3);
            this.game.Controls.Add(this.pictureBox2);
            this.game.Controls.Add(this.label8);
            this.game.Controls.Add(this.label7);
            this.game.Location = new System.Drawing.Point(0, 0);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(1042, 525);
            this.game.TabIndex = 10;
            this.game.Visible = false;
            // 
            // slothadle
            // 
            this.slothadle.Image = ((System.Drawing.Image)(resources.GetObject("slothadle.Image")));
            this.slothadle.Location = new System.Drawing.Point(946, 158);
            this.slothadle.Name = "slothadle";
            this.slothadle.Size = new System.Drawing.Size(93, 249);
            this.slothadle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slothadle.TabIndex = 8;
            this.slothadle.TabStop = false;
            // 
            // coinsearned
            // 
            this.coinsearned.AutoSize = true;
            this.coinsearned.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsearned.Location = new System.Drawing.Point(648, 476);
            this.coinsearned.Name = "coinsearned";
            this.coinsearned.Size = new System.Drawing.Size(22, 27);
            this.coinsearned.TabIndex = 6;
            this.coinsearned.Text = "0";
            // 
            // coinsgiven
            // 
            this.coinsgiven.AutoSize = true;
            this.coinsgiven.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsgiven.Location = new System.Drawing.Point(429, 476);
            this.coinsgiven.Name = "coinsgiven";
            this.coinsgiven.Size = new System.Drawing.Size(22, 27);
            this.coinsgiven.TabIndex = 5;
            this.coinsgiven.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "GIVEN:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(496, 463);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(297, 463);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Playbill", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(557, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "EARNED:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 49);
            this.label7.TabIndex = 0;
            this.label7.Text = "VIRTUAL SLOT MACHINE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onOffToolStripMenuItem});
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.soundToolStripMenuItem.Text = "Sound";
            // 
            // onOffToolStripMenuItem
            // 
            this.onOffToolStripMenuItem.Name = "onOffToolStripMenuItem";
            this.onOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onOffToolStripMenuItem.Text = "On/Off";
            this.onOffToolStripMenuItem.Click += new System.EventHandler(this.onOffToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewGameRefreshCoinsToolStripMenuItem,
            this.fullScreenToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.viewToolStripMenuItem.Text = "Options";
            // 
            // startNewGameRefreshCoinsToolStripMenuItem
            // 
            this.startNewGameRefreshCoinsToolStripMenuItem.Name = "startNewGameRefreshCoinsToolStripMenuItem";
            this.startNewGameRefreshCoinsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.startNewGameRefreshCoinsToolStripMenuItem.Text = "Start New Game/ Refresh coins";
            this.startNewGameRefreshCoinsToolStripMenuItem.Click += new System.EventHandler(this.startNewGameRefreshCoinsToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.fullScreenToolStripMenuItem.Text = "Exit Game";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // minuscolumns
            // 
            this.minuscolumns.Enabled = false;
            this.minuscolumns.Location = new System.Drawing.Point(845, 310);
            this.minuscolumns.Name = "minuscolumns";
            this.minuscolumns.Size = new System.Drawing.Size(30, 23);
            this.minuscolumns.TabIndex = 12;
            this.minuscolumns.Text = "-";
            this.minuscolumns.UseVisualStyleBackColor = true;
            this.minuscolumns.Click += new System.EventHandler(this.minuscolumns_Click);
            // 
            // minuschoices
            // 
            this.minuschoices.Enabled = false;
            this.minuschoices.Location = new System.Drawing.Point(845, 353);
            this.minuschoices.Name = "minuschoices";
            this.minuschoices.Size = new System.Drawing.Size(30, 23);
            this.minuschoices.TabIndex = 13;
            this.minuschoices.Text = "-";
            this.minuschoices.UseVisualStyleBackColor = true;
            this.minuschoices.Click += new System.EventHandler(this.minuschoices_Click);
            // 
            // columnnumber
            // 
            this.columnnumber.AutoSize = true;
            this.columnnumber.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnnumber.Location = new System.Drawing.Point(891, 310);
            this.columnnumber.Name = "columnnumber";
            this.columnnumber.Size = new System.Drawing.Size(19, 24);
            this.columnnumber.TabIndex = 14;
            this.columnnumber.Text = "3";
            // 
            // choicenumber
            // 
            this.choicenumber.AutoSize = true;
            this.choicenumber.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choicenumber.Location = new System.Drawing.Point(891, 353);
            this.choicenumber.Name = "choicenumber";
            this.choicenumber.Size = new System.Drawing.Size(19, 24);
            this.choicenumber.TabIndex = 15;
            this.choicenumber.Text = "3";
            // 
            // pluscolumns
            // 
            this.pluscolumns.Enabled = false;
            this.pluscolumns.Location = new System.Drawing.Point(925, 310);
            this.pluscolumns.Name = "pluscolumns";
            this.pluscolumns.Size = new System.Drawing.Size(30, 23);
            this.pluscolumns.TabIndex = 16;
            this.pluscolumns.Text = "+";
            this.pluscolumns.UseVisualStyleBackColor = true;
            this.pluscolumns.Click += new System.EventHandler(this.pluscolumns_Click);
            // 
            // pluschoices
            // 
            this.pluschoices.Enabled = false;
            this.pluschoices.Location = new System.Drawing.Point(925, 353);
            this.pluschoices.Name = "pluschoices";
            this.pluschoices.Size = new System.Drawing.Size(30, 23);
            this.pluschoices.TabIndex = 17;
            this.pluschoices.Text = "+";
            this.pluschoices.UseVisualStyleBackColor = true;
            this.pluschoices.Click += new System.EventHandler(this.pluschoices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 525);
            this.Controls.Add(this.pluschoices);
            this.Controls.Add(this.pluscolumns);
            this.Controls.Add(this.choicenumber);
            this.Controls.Add(this.columnnumber);
            this.Controls.Add(this.minuschoices);
            this.Controls.Add(this.minuscolumns);
            this.Controls.Add(this.game);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coinamount);
            this.Controls.Add(this.customrb);
            this.Controls.Add(this.pluscoins);
            this.Controls.Add(this.autorb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minuscoins);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIRTUAL SLOT MACHINE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.game.ResumeLayout(false);
            this.game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slothadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pluscoins;
        private System.Windows.Forms.Button minuscoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label coinamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton autorb;
        private System.Windows.Forms.RadioButton customrb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel game;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label coinsearned;
        private System.Windows.Forms.Label coinsgiven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox slothadle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button minuscolumns;
        private System.Windows.Forms.Button minuschoices;
        private System.Windows.Forms.Label columnnumber;
        private System.Windows.Forms.Label choicenumber;
        private System.Windows.Forms.Button pluscolumns;
        private System.Windows.Forms.Button pluschoices;
        private System.Windows.Forms.ToolStripMenuItem startNewGameRefreshCoinsToolStripMenuItem;
    }
}

