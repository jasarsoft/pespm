namespace Jasarsoft.PESPatchManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKitserver = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelGame = new System.Windows.Forms.Label();
            this.comboGame = new System.Windows.Forms.ComboBox();
            this.comboPatch = new System.Windows.Forms.ComboBox();
            this.comboSeason = new System.Windows.Forms.ComboBox();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.comboGameplay = new System.Windows.Forms.ComboBox();
            this.labelPatch = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelLangauge = new System.Windows.Forms.Label();
            this.labelGameplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureGame = new System.Windows.Forms.PictureBox();
            this.picturePatch = new System.Windows.Forms.PictureBox();
            this.pictureSeason = new System.Windows.Forms.PictureBox();
            this.pictureLangauge = new System.Windows.Forms.PictureBox();
            this.pictureGameplay = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLangauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemEdit,
            this.menuItemKitserver,
            this.menuItemTools,
            this.menuItemHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(337, 24);
            this.menuMain.TabIndex = 0;
            // 
            // menuItemFile
            // 
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "&File";
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.menuItemEdit.Text = "&Edit";
            // 
            // menuItemKitserver
            // 
            this.menuItemKitserver.Name = "menuItemKitserver";
            this.menuItemKitserver.Size = new System.Drawing.Size(64, 20);
            this.menuItemKitserver.Text = "&Kitserver";
            // 
            // menuItemTools
            // 
            this.menuItemTools.Name = "menuItemTools";
            this.menuItemTools.Size = new System.Drawing.Size(48, 20);
            this.menuItemTools.Text = "&Tools";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "&Help";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 36);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(313, 78);
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // labelGame
            // 
            this.labelGame.Location = new System.Drawing.Point(12, 129);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(90, 21);
            this.labelGame.TabIndex = 1;
            this.labelGame.Text = "Game:";
            this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGame
            // 
            this.comboGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGame.FormattingEnabled = true;
            this.comboGame.Location = new System.Drawing.Point(108, 129);
            this.comboGame.Name = "comboGame";
            this.comboGame.Size = new System.Drawing.Size(190, 21);
            this.comboGame.TabIndex = 6;
            // 
            // comboPatch
            // 
            this.comboPatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPatch.FormattingEnabled = true;
            this.comboPatch.Location = new System.Drawing.Point(108, 156);
            this.comboPatch.Name = "comboPatch";
            this.comboPatch.Size = new System.Drawing.Size(190, 21);
            this.comboPatch.TabIndex = 7;
            // 
            // comboSeason
            // 
            this.comboSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeason.FormattingEnabled = true;
            this.comboSeason.Location = new System.Drawing.Point(108, 183);
            this.comboSeason.Name = "comboSeason";
            this.comboSeason.Size = new System.Drawing.Size(190, 21);
            this.comboSeason.TabIndex = 8;
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Location = new System.Drawing.Point(108, 210);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(190, 21);
            this.comboLanguage.TabIndex = 9;
            // 
            // comboGameplay
            // 
            this.comboGameplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGameplay.FormattingEnabled = true;
            this.comboGameplay.Location = new System.Drawing.Point(108, 237);
            this.comboGameplay.Name = "comboGameplay";
            this.comboGameplay.Size = new System.Drawing.Size(190, 21);
            this.comboGameplay.TabIndex = 10;
            // 
            // labelPatch
            // 
            this.labelPatch.Location = new System.Drawing.Point(12, 156);
            this.labelPatch.Name = "labelPatch";
            this.labelPatch.Size = new System.Drawing.Size(90, 21);
            this.labelPatch.TabIndex = 2;
            this.labelPatch.Text = "Patch:";
            this.labelPatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSeason
            // 
            this.labelSeason.Location = new System.Drawing.Point(12, 183);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(90, 21);
            this.labelSeason.TabIndex = 3;
            this.labelSeason.Text = "Season:";
            this.labelSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLangauge
            // 
            this.labelLangauge.Location = new System.Drawing.Point(12, 210);
            this.labelLangauge.Name = "labelLangauge";
            this.labelLangauge.Size = new System.Drawing.Size(90, 21);
            this.labelLangauge.TabIndex = 4;
            this.labelLangauge.Text = "Language:";
            this.labelLangauge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGameplay
            // 
            this.labelGameplay.Location = new System.Drawing.Point(12, 237);
            this.labelGameplay.Name = "labelGameplay";
            this.labelGameplay.Size = new System.Drawing.Size(90, 21);
            this.labelGameplay.TabIndex = 5;
            this.labelGameplay.Text = "Gameplay:";
            this.labelGameplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 2);
            this.label6.TabIndex = 11;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.Location = new System.Drawing.Point(108, 278);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(190, 42);
            this.buttonPlay.TabIndex = 13;
            this.buttonPlay.Text = "PLAY  PATCH";
            this.buttonPlay.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 278);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 42);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // pictureGame
            // 
            this.pictureGame.Location = new System.Drawing.Point(304, 129);
            this.pictureGame.Name = "pictureGame";
            this.pictureGame.Size = new System.Drawing.Size(21, 21);
            this.pictureGame.TabIndex = 15;
            this.pictureGame.TabStop = false;
            // 
            // picturePatch
            // 
            this.picturePatch.Location = new System.Drawing.Point(304, 156);
            this.picturePatch.Name = "picturePatch";
            this.picturePatch.Size = new System.Drawing.Size(21, 21);
            this.picturePatch.TabIndex = 16;
            this.picturePatch.TabStop = false;
            // 
            // pictureSeason
            // 
            this.pictureSeason.Location = new System.Drawing.Point(304, 183);
            this.pictureSeason.Name = "pictureSeason";
            this.pictureSeason.Size = new System.Drawing.Size(21, 21);
            this.pictureSeason.TabIndex = 17;
            this.pictureSeason.TabStop = false;
            // 
            // pictureLangauge
            // 
            this.pictureLangauge.Location = new System.Drawing.Point(304, 210);
            this.pictureLangauge.Name = "pictureLangauge";
            this.pictureLangauge.Size = new System.Drawing.Size(21, 21);
            this.pictureLangauge.TabIndex = 18;
            this.pictureLangauge.TabStop = false;
            // 
            // pictureGameplay
            // 
            this.pictureGameplay.Location = new System.Drawing.Point(304, 237);
            this.pictureGameplay.Name = "pictureGameplay";
            this.pictureGameplay.Size = new System.Drawing.Size(21, 21);
            this.pictureGameplay.TabIndex = 19;
            this.pictureGameplay.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(304, 278);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(21, 42);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "X";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 332);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.pictureGameplay);
            this.Controls.Add(this.pictureLangauge);
            this.Controls.Add(this.pictureSeason);
            this.Controls.Add(this.picturePatch);
            this.Controls.Add(this.pictureGame);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelGameplay);
            this.Controls.Add(this.labelLangauge);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.labelPatch);
            this.Controls.Add(this.comboGameplay);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.comboSeason);
            this.Controls.Add(this.comboPatch);
            this.Controls.Add(this.comboGame);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "PES Patch Manager: PES 6";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSeason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLangauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGameplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.ComboBox comboGame;
        private System.Windows.Forms.ComboBox comboPatch;
        private System.Windows.Forms.ComboBox comboSeason;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.ComboBox comboGameplay;
        private System.Windows.Forms.Label labelPatch;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelLangauge;
        private System.Windows.Forms.Label labelGameplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemKitserver;
        private System.Windows.Forms.ToolStripMenuItem menuItemTools;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.PictureBox pictureGame;
        private System.Windows.Forms.PictureBox picturePatch;
        private System.Windows.Forms.PictureBox pictureSeason;
        private System.Windows.Forms.PictureBox pictureLangauge;
        private System.Windows.Forms.PictureBox pictureGameplay;
        private System.Windows.Forms.Button buttonReset;
    }
}

