
namespace WinFormsAdventureGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlayOneRound = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.playOneRoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.grpBoxCharacter = new System.Windows.Forms.GroupBox();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.lblCharacterWeapon = new System.Windows.Forms.Label();
            this.lblCharacterLevel = new System.Windows.Forms.Label();
            this.lblCharacterGold = new System.Windows.Forms.Label();
            this.lblCharacterClass = new System.Windows.Forms.Label();
            this.lblCharacterHP = new System.Windows.Forms.Label();
            this.lblCharacterXP = new System.Windows.Forms.Label();
            this.grpBoxMonster = new System.Windows.Forms.GroupBox();
            this.picMonster = new System.Windows.Forms.PictureBox();
            this.lblMonsterWeapon = new System.Windows.Forms.Label();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.lblMonsterType = new System.Windows.Forms.Label();
            this.lblMonsterGold = new System.Windows.Forms.Label();
            this.lblMonsterHP = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBoxCharacter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.grpBoxMonster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayOneRound
            // 
            this.btnPlayOneRound.Location = new System.Drawing.Point(685, 524);
            this.btnPlayOneRound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlayOneRound.Name = "btnPlayOneRound";
            this.btnPlayOneRound.Size = new System.Drawing.Size(168, 121);
            this.btnPlayOneRound.TabIndex = 0;
            this.btnPlayOneRound.Text = "Play one &round";
            this.btnPlayOneRound.UseVisualStyleBackColor = true;
            this.btnPlayOneRound.Click += new System.EventHandler(this.btnPlayRound_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1529, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuExit,
            this.playOneRoundToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewGame.Size = new System.Drawing.Size(217, 26);
            this.mnuNewGame.Text = "&New game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuExit.Size = new System.Drawing.Size(217, 26);
            this.mnuExit.Text = "&Exit";
            // 
            // playOneRoundToolStripMenuItem
            // 
            this.playOneRoundToolStripMenuItem.Name = "playOneRoundToolStripMenuItem";
            this.playOneRoundToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.playOneRoundToolStripMenuItem.Text = "&Play one round";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtStatus.Location = new System.Drawing.Point(0, 653);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(1529, 321);
            this.txtStatus.TabIndex = 4;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterName.ForeColor = System.Drawing.Color.White;
            this.lblCharacterName.Location = new System.Drawing.Point(21, 59);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(88, 32);
            this.lblCharacterName.TabIndex = 0;
            this.lblCharacterName.Text = "Name:";
            // 
            // grpBoxCharacter
            // 
            this.grpBoxCharacter.Controls.Add(this.picCharacter);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterWeapon);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterLevel);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterGold);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterClass);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterHP);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterXP);
            this.grpBoxCharacter.Controls.Add(this.lblCharacterName);
            this.grpBoxCharacter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBoxCharacter.Location = new System.Drawing.Point(26, 42);
            this.grpBoxCharacter.Name = "grpBoxCharacter";
            this.grpBoxCharacter.Size = new System.Drawing.Size(625, 603);
            this.grpBoxCharacter.TabIndex = 5;
            this.grpBoxCharacter.TabStop = false;
            this.grpBoxCharacter.Text = "Character";
            // 
            // picCharacter
            // 
            this.picCharacter.Location = new System.Drawing.Point(145, 308);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(308, 278);
            this.picCharacter.TabIndex = 4;
            this.picCharacter.TabStop = false;
            // 
            // lblCharacterWeapon
            // 
            this.lblCharacterWeapon.AutoSize = true;
            this.lblCharacterWeapon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterWeapon.ForeColor = System.Drawing.Color.White;
            this.lblCharacterWeapon.Location = new System.Drawing.Point(21, 175);
            this.lblCharacterWeapon.Name = "lblCharacterWeapon";
            this.lblCharacterWeapon.Size = new System.Drawing.Size(115, 32);
            this.lblCharacterWeapon.TabIndex = 3;
            this.lblCharacterWeapon.Text = "Weapon:";
            // 
            // lblCharacterLevel
            // 
            this.lblCharacterLevel.AutoSize = true;
            this.lblCharacterLevel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterLevel.ForeColor = System.Drawing.Color.White;
            this.lblCharacterLevel.Location = new System.Drawing.Point(216, 230);
            this.lblCharacterLevel.Name = "lblCharacterLevel";
            this.lblCharacterLevel.Size = new System.Drawing.Size(79, 32);
            this.lblCharacterLevel.TabIndex = 3;
            this.lblCharacterLevel.Text = "Level:";
            // 
            // lblCharacterGold
            // 
            this.lblCharacterGold.AutoSize = true;
            this.lblCharacterGold.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterGold.ForeColor = System.Drawing.Color.White;
            this.lblCharacterGold.Location = new System.Drawing.Point(389, 230);
            this.lblCharacterGold.Name = "lblCharacterGold";
            this.lblCharacterGold.Size = new System.Drawing.Size(75, 32);
            this.lblCharacterGold.TabIndex = 2;
            this.lblCharacterGold.Text = "Gold:";
            // 
            // lblCharacterClass
            // 
            this.lblCharacterClass.AutoSize = true;
            this.lblCharacterClass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterClass.ForeColor = System.Drawing.Color.White;
            this.lblCharacterClass.Location = new System.Drawing.Point(21, 115);
            this.lblCharacterClass.Name = "lblCharacterClass";
            this.lblCharacterClass.Size = new System.Drawing.Size(78, 32);
            this.lblCharacterClass.TabIndex = 1;
            this.lblCharacterClass.Text = "Class:";
            // 
            // lblCharacterHP
            // 
            this.lblCharacterHP.AutoSize = true;
            this.lblCharacterHP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterHP.ForeColor = System.Drawing.Color.White;
            this.lblCharacterHP.Location = new System.Drawing.Point(389, 115);
            this.lblCharacterHP.Name = "lblCharacterHP";
            this.lblCharacterHP.Size = new System.Drawing.Size(54, 32);
            this.lblCharacterHP.TabIndex = 1;
            this.lblCharacterHP.Text = "HP:";
            // 
            // lblCharacterXP
            // 
            this.lblCharacterXP.AutoSize = true;
            this.lblCharacterXP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterXP.ForeColor = System.Drawing.Color.White;
            this.lblCharacterXP.Location = new System.Drawing.Point(21, 230);
            this.lblCharacterXP.Name = "lblCharacterXP";
            this.lblCharacterXP.Size = new System.Drawing.Size(52, 32);
            this.lblCharacterXP.TabIndex = 1;
            this.lblCharacterXP.Text = "XP:";
            // 
            // grpBoxMonster
            // 
            this.grpBoxMonster.Controls.Add(this.picMonster);
            this.grpBoxMonster.Controls.Add(this.lblMonsterWeapon);
            this.grpBoxMonster.Controls.Add(this.lblMonsterName);
            this.grpBoxMonster.Controls.Add(this.lblMonsterType);
            this.grpBoxMonster.Controls.Add(this.lblMonsterGold);
            this.grpBoxMonster.Controls.Add(this.lblMonsterHP);
            this.grpBoxMonster.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBoxMonster.Location = new System.Drawing.Point(880, 42);
            this.grpBoxMonster.Name = "grpBoxMonster";
            this.grpBoxMonster.Size = new System.Drawing.Size(625, 603);
            this.grpBoxMonster.TabIndex = 6;
            this.grpBoxMonster.TabStop = false;
            this.grpBoxMonster.Text = "Monster";
            // 
            // picMonster
            // 
            this.picMonster.Location = new System.Drawing.Point(149, 308);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(308, 278);
            this.picMonster.TabIndex = 4;
            this.picMonster.TabStop = false;
            // 
            // lblMonsterWeapon
            // 
            this.lblMonsterWeapon.AutoSize = true;
            this.lblMonsterWeapon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterWeapon.ForeColor = System.Drawing.Color.White;
            this.lblMonsterWeapon.Location = new System.Drawing.Point(34, 175);
            this.lblMonsterWeapon.Name = "lblMonsterWeapon";
            this.lblMonsterWeapon.Size = new System.Drawing.Size(115, 32);
            this.lblMonsterWeapon.TabIndex = 3;
            this.lblMonsterWeapon.Text = "Weapon:";
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.AutoSize = true;
            this.lblMonsterName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterName.ForeColor = System.Drawing.Color.White;
            this.lblMonsterName.Location = new System.Drawing.Point(34, 59);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(88, 32);
            this.lblMonsterName.TabIndex = 0;
            this.lblMonsterName.Text = "Name:";
            // 
            // lblMonsterType
            // 
            this.lblMonsterType.AutoSize = true;
            this.lblMonsterType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterType.ForeColor = System.Drawing.Color.White;
            this.lblMonsterType.Location = new System.Drawing.Point(34, 115);
            this.lblMonsterType.Name = "lblMonsterType";
            this.lblMonsterType.Size = new System.Drawing.Size(68, 32);
            this.lblMonsterType.TabIndex = 1;
            this.lblMonsterType.Text = "Type";
            // 
            // lblMonsterGold
            // 
            this.lblMonsterGold.AutoSize = true;
            this.lblMonsterGold.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterGold.ForeColor = System.Drawing.Color.White;
            this.lblMonsterGold.Location = new System.Drawing.Point(34, 230);
            this.lblMonsterGold.Name = "lblMonsterGold";
            this.lblMonsterGold.Size = new System.Drawing.Size(75, 32);
            this.lblMonsterGold.TabIndex = 2;
            this.lblMonsterGold.Text = "Gold:";
            // 
            // lblMonsterHP
            // 
            this.lblMonsterHP.AutoSize = true;
            this.lblMonsterHP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonsterHP.ForeColor = System.Drawing.Color.White;
            this.lblMonsterHP.Location = new System.Drawing.Point(387, 115);
            this.lblMonsterHP.Name = "lblMonsterHP";
            this.lblMonsterHP.Size = new System.Drawing.Size(54, 32);
            this.lblMonsterHP.TabIndex = 1;
            this.lblMonsterHP.Text = "HP:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(685, 56);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(168, 121);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "&New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnPlayOneRound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1529, 974);
            this.Controls.Add(this.grpBoxMonster);
            this.Controls.Add(this.grpBoxCharacter);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnPlayOneRound);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Adventure Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxCharacter.ResumeLayout(false);
            this.grpBoxCharacter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.grpBoxMonster.ResumeLayout(false);
            this.grpBoxMonster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayOneRound;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.GroupBox grpBoxCharacter;
        private System.Windows.Forms.Label lblCharacterWeapon;
        private System.Windows.Forms.Label lblCharacterLevel;
        private System.Windows.Forms.Label lblCharacterGold;
        private System.Windows.Forms.Label lblCharacterClass;
        private System.Windows.Forms.Label lblCharacterXP;
        private System.Windows.Forms.GroupBox grpBoxMonster;
        private System.Windows.Forms.Label lblMonsterWeapon;
        private System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label lblMonsterType;
        private System.Windows.Forms.Label lblMonsterGold;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.PictureBox picMonster;
        private System.Windows.Forms.ToolStripMenuItem playOneRoundToolStripMenuItem;
        private System.Windows.Forms.Label lblCharacterHP;
        private System.Windows.Forms.Label lblMonsterHP;
        private System.Windows.Forms.Button btnNewGame;
    }
}

