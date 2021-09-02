using AdventureGameClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsAdventureGame
{
    public partial class NewPlayerCharacterForm : Form
    {
        public string CharacterName
        {
            get { return txtCharacterName.Text; }
            set { txtCharacterName.Text = value; }
        }


        public Weapon SelectedWeapon
        {
            get { return (Weapon)cboWeapons.SelectedItem; }
        }

        public CharacterType SelectedCharacterType
        {
            get { return (CharacterType)cboCharacterTypes.SelectedItem; }
        }


        public NewPlayerCharacterForm(List<Weapon> weapons)
        {
            
            InitializeComponent();
            cboWeapons.DisplayMember = "Name";
            cboWeapons.DataSource = weapons;

            
        }

        private void frmNewPlayerCharacter_Load(object sender, EventArgs e)
        {
            cboCharacterTypes.DataSource = Enum.GetValues(typeof(CharacterType));
            txtCharacterName.Select();
        }
    }
}
