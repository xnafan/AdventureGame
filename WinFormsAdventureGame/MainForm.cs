using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAdventureGame
{
    public partial class MainForm : Form
    {
        GameController controller = new GameController();
        public MainForm()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            using (NewPlayerCharacterForm newCharacterForm = new NewPlayerCharacterForm(controller.Weapons))
            {
                if (newCharacterForm.ShowDialog() == DialogResult.OK)
                {
                    controller.StartNewGame(newCharacterForm.CharacterName, newCharacterForm.SelectedCharacterType, newCharacterForm.SelectedWeapon);
                    UpdateUI();
                }
            }
        }

        private void btnPlayRound_Click(object sender, EventArgs e)
        {
            controller.PlayRound();
            UpdateUI();

        }

        private void UpdateUI()
        {
            txtStatus.Text = controller.GetLatestStatus();
            btnPlayOneRound.Visible = controller.IsGameRunning;
            SetCharacterStats();
            SetMonsterStats();
        }


        private void SetCharacterStats()
        {
            lblCharacterName.Text = "Name: " + controller.Character?.Name;
            lblCharacterClass.Text = "Class: " + controller.Character?.CharacterType;
            lblCharacterXP.Text = "XP: " + controller.Character?.ExperiencePoints;
            lblCharacterHP.Text = "HP: " + controller.Character?.HitPoints;
            lblCharacterLevel.Text = "Level: " + controller.Character?.Level;
            lblCharacterGold.Text = "Gold: " + controller.Character?.Gold;
            lblCharacterWeapon.Text = "Weapon: "+ controller.Character?.Weapon;
            this.BackColor = controller.Character != null && !controller.Character.IsAlive ? Color.Red : Color.ForestGreen;
        }
        private void SetMonsterStats()
        {
            lblMonsterName.Text = "Name: " + controller.Monster?.Name;
            lblMonsterType.Text = "Class: " + controller.Monster?.MonsterType;
            lblMonsterGold.Text = "Gold: " + controller.Monster?.Gold;
            lblMonsterWeapon.Text = "Weapon: " + controller.Monster?.Weapon;
            lblMonsterHP.Text = "HP: " + controller.Monster?.HitPoints;
            grpBoxMonster.ForeColor = controller.Monster != null && !controller.Monster.IsAlive ? Color.Red : Color.Black;

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}