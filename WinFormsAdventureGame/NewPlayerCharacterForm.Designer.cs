
namespace WinFormsAdventureGame
{
    partial class NewPlayerCharacterForm
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
            this.lblNewPlayerCharacter = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCharacterType = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblWeaponType = new System.Windows.Forms.Label();
            this.cboCharacterTypes = new System.Windows.Forms.ComboBox();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewPlayerCharacter
            // 
            this.lblNewPlayerCharacter.AutoSize = true;
            this.lblNewPlayerCharacter.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewPlayerCharacter.Location = new System.Drawing.Point(137, 46);
            this.lblNewPlayerCharacter.Name = "lblNewPlayerCharacter";
            this.lblNewPlayerCharacter.Size = new System.Drawing.Size(460, 47);
            this.lblNewPlayerCharacter.TabIndex = 0;
            this.lblNewPlayerCharacter.Text = "Create new character";
            // 
            // btnCreate
            // 
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreate.Location = new System.Drawing.Point(532, 450);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 60);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 163);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 28);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Character &name";
            // 
            // lblCharacterType
            // 
            this.lblCharacterType.AutoSize = true;
            this.lblCharacterType.Location = new System.Drawing.Point(40, 248);
            this.lblCharacterType.Name = "lblCharacterType";
            this.lblCharacterType.Size = new System.Drawing.Size(194, 28);
            this.lblCharacterType.TabIndex = 3;
            this.lblCharacterType.Text = "Character &type";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(304, 156);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(452, 35);
            this.txtCharacterName.TabIndex = 4;
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.Location = new System.Drawing.Point(40, 345);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(90, 28);
            this.lblWeaponType.TabIndex = 7;
            this.lblWeaponType.Text = "&Weapon";
            // 
            // cboCharacterTypes
            // 
            this.cboCharacterTypes.FormattingEnabled = true;
            this.cboCharacterTypes.Location = new System.Drawing.Point(304, 248);
            this.cboCharacterTypes.Name = "cboCharacterTypes";
            this.cboCharacterTypes.Size = new System.Drawing.Size(452, 35);
            this.cboCharacterTypes.TabIndex = 8;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(304, 345);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(452, 35);
            this.cboWeapons.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(41, 450);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 60);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewPlayerCharacterForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(809, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.cboCharacterTypes);
            this.Controls.Add(this.lblWeaponType);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNewPlayerCharacter);
            this.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewPlayerCharacterForm";
            this.Text = "New player character...";
            this.Load += new System.EventHandler(this.frmNewPlayerCharacter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPlayerCharacter;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCharacterType;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblWeaponType;
        private System.Windows.Forms.ComboBox cboCharacterTypes;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.Button btnCancel;
    }
}