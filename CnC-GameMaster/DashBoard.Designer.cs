namespace CnCGameMaster
{
    partial class DashBoard
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
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxGames = new System.Windows.Forms.ListBox();
            this.lbxPlayers = new System.Windows.Forms.ListBox();
            this.btnCacheGames = new System.Windows.Forms.Button();
            this.lbxCommands = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateToken = new System.Windows.Forms.Button();
            this.txtAuthToken = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxPlayerTiles = new System.Windows.Forms.ListBox();
            this.lbxPlayerUnits = new System.Windows.Forms.ListBox();
            this.lbxPlayerGames = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGameTestEnvironment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(472, 30);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(85, 45);
            this.btnAddPlayer.TabIndex = 0;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Visible = false;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(472, 81);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(85, 45);
            this.btnEditPlayer.TabIndex = 1;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Visible = false;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(472, 132);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(85, 45);
            this.btnDeletePlayer.TabIndex = 3;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Visible = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Players";
            this.label1.Visible = false;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(13, 353);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(85, 45);
            this.btnAddGame.TabIndex = 6;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Location = new System.Drawing.Point(571, 132);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(85, 45);
            this.btnDeleteGame.TabIndex = 8;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Visible = false;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnEditGame
            // 
            this.btnEditGame.Location = new System.Drawing.Point(571, 81);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(85, 45);
            this.btnEditGame.TabIndex = 7;
            this.btnEditGame.Text = "Edit Game";
            this.btnEditGame.UseVisualStyleBackColor = true;
            this.btnEditGame.Visible = false;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Games";
            // 
            // lbxGames
            // 
            this.lbxGames.FormattingEnabled = true;
            this.lbxGames.Location = new System.Drawing.Point(16, 32);
            this.lbxGames.Name = "lbxGames";
            this.lbxGames.Size = new System.Drawing.Size(199, 134);
            this.lbxGames.TabIndex = 10;
            // 
            // lbxPlayers
            // 
            this.lbxPlayers.FormattingEnabled = true;
            this.lbxPlayers.Location = new System.Drawing.Point(253, 32);
            this.lbxPlayers.Name = "lbxPlayers";
            this.lbxPlayers.Size = new System.Drawing.Size(199, 134);
            this.lbxPlayers.TabIndex = 11;
            this.lbxPlayers.Visible = false;
            this.lbxPlayers.SelectedIndexChanged += new System.EventHandler(this.lbxPlayers_SelectedIndexChanged);
            // 
            // btnCacheGames
            // 
            this.btnCacheGames.Location = new System.Drawing.Point(861, 413);
            this.btnCacheGames.Name = "btnCacheGames";
            this.btnCacheGames.Size = new System.Drawing.Size(85, 45);
            this.btnCacheGames.TabIndex = 12;
            this.btnCacheGames.Text = "Cache Games";
            this.btnCacheGames.UseVisualStyleBackColor = true;
            this.btnCacheGames.Visible = false;
            this.btnCacheGames.Click += new System.EventHandler(this.btnCacheGames_Click);
            // 
            // lbxCommands
            // 
            this.lbxCommands.FormattingEnabled = true;
            this.lbxCommands.Location = new System.Drawing.Point(677, 30);
            this.lbxCommands.Name = "lbxCommands";
            this.lbxCommands.Size = new System.Drawing.Size(199, 368);
            this.lbxCommands.TabIndex = 14;
            this.lbxCommands.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "GamesCommands";
            this.label3.Visible = false;
            // 
            // btnCreateToken
            // 
            this.btnCreateToken.Location = new System.Drawing.Point(12, 416);
            this.btnCreateToken.Name = "btnCreateToken";
            this.btnCreateToken.Size = new System.Drawing.Size(85, 45);
            this.btnCreateToken.TabIndex = 15;
            this.btnCreateToken.Text = "Create Token";
            this.btnCreateToken.UseVisualStyleBackColor = true;
            this.btnCreateToken.Visible = false;
            this.btnCreateToken.Click += new System.EventHandler(this.btnCreateToken_Click);
            // 
            // txtAuthToken
            // 
            this.txtAuthToken.Location = new System.Drawing.Point(149, 442);
            this.txtAuthToken.Name = "txtAuthToken";
            this.txtAuthToken.Size = new System.Drawing.Size(183, 20);
            this.txtAuthToken.TabIndex = 43;
            this.txtAuthToken.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(149, 416);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(183, 20);
            this.txtUserId.TabIndex = 44;
            this.txtUserId.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "UserId";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Token";
            this.label5.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 47;
            this.button1.Text = "reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxPlayerTiles
            // 
            this.lbxPlayerTiles.FormattingEnabled = true;
            this.lbxPlayerTiles.Location = new System.Drawing.Point(237, 201);
            this.lbxPlayerTiles.Name = "lbxPlayerTiles";
            this.lbxPlayerTiles.Size = new System.Drawing.Size(199, 134);
            this.lbxPlayerTiles.TabIndex = 49;
            this.lbxPlayerTiles.Visible = false;
            // 
            // lbxPlayerUnits
            // 
            this.lbxPlayerUnits.FormattingEnabled = true;
            this.lbxPlayerUnits.Location = new System.Drawing.Point(457, 201);
            this.lbxPlayerUnits.Name = "lbxPlayerUnits";
            this.lbxPlayerUnits.Size = new System.Drawing.Size(199, 134);
            this.lbxPlayerUnits.TabIndex = 48;
            this.lbxPlayerUnits.Visible = false;
            // 
            // lbxPlayerGames
            // 
            this.lbxPlayerGames.FormattingEnabled = true;
            this.lbxPlayerGames.Location = new System.Drawing.Point(16, 201);
            this.lbxPlayerGames.Name = "lbxPlayerGames";
            this.lbxPlayerGames.Size = new System.Drawing.Size(199, 134);
            this.lbxPlayerGames.TabIndex = 50;
            this.lbxPlayerGames.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "PlayerGames";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "PlayerTiles";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "PlayerUnits";
            this.label8.Visible = false;
            // 
            // txtGameTestEnvironment
            // 
            this.txtGameTestEnvironment.Location = new System.Drawing.Point(214, 366);
            this.txtGameTestEnvironment.Name = "txtGameTestEnvironment";
            this.txtGameTestEnvironment.Size = new System.Drawing.Size(183, 20);
            this.txtGameTestEnvironment.TabIndex = 54;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 495);
            this.Controls.Add(this.txtGameTestEnvironment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxPlayerGames);
            this.Controls.Add(this.lbxPlayerTiles);
            this.Controls.Add(this.lbxPlayerUnits);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtAuthToken);
            this.Controls.Add(this.btnCreateToken);
            this.Controls.Add(this.lbxCommands);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCacheGames);
            this.Controls.Add(this.lbxPlayers);
            this.Controls.Add(this.lbxGames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnEditPlayer);
            this.Controls.Add(this.btnAddPlayer);
            this.Name = "DashBoard";
            this.Text = "Game Master Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Label label1;
     //   private System.Windows.Forms.ListBox lbxGames;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnEditGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxGames;
        private System.Windows.Forms.ListBox lbxPlayers;
        private System.Windows.Forms.Button btnCacheGames;
        private System.Windows.Forms.ListBox lbxCommands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateToken;
        private System.Windows.Forms.TextBox txtAuthToken;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxPlayerTiles;
        private System.Windows.Forms.ListBox lbxPlayerUnits;
        private System.Windows.Forms.ListBox lbxPlayerGames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGameTestEnvironment;
    }
}

