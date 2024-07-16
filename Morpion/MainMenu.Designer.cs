namespace Morpion
{
    partial class MainWindow
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
            playerWins = new Label();
            iaWins = new Label();
            A1 = new Button();
            B1 = new Button();
            C1 = new Button();
            A2 = new Button();
            B2 = new Button();
            C2 = new Button();
            A3 = new Button();
            B3 = new Button();
            C3 = new Button();
            button10 = new Button();
            menuStrip = new MenuStrip();
            difficultéToolStripMenuItem = new ToolStripMenuItem();
            facileTSMI = new ToolStripMenuItem();
            difficileTSMI = new ToolStripMenuItem();
            modesDeJeuxToolStripMenuItem = new ToolStripMenuItem();
            vsMode = new ToolStripMenuItem();
            iaMode = new ToolStripMenuItem();
            affichageToolStripMenuItem = new ToolStripMenuItem();
            darkMode = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // playerWins
            // 
            playerWins.AutoSize = true;
            playerWins.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerWins.ForeColor = Color.YellowGreen;
            playerWins.Location = new Point(12, 28);
            playerWins.Name = "playerWins";
            playerWins.Size = new Size(156, 28);
            playerWins.TabIndex = 0;
            playerWins.Text = "Player Wins - 0";
            // 
            // iaWins
            // 
            iaWins.AutoSize = true;
            iaWins.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iaWins.ForeColor = Color.IndianRed;
            iaWins.Location = new Point(540, 28);
            iaWins.Name = "iaWins";
            iaWins.Size = new Size(117, 28);
            iaWins.TabIndex = 1;
            iaWins.Text = "IA Wins - 0";
            // 
            // A1
            // 
            A1.FlatAppearance.BorderColor = Color.LightGray;
            A1.FlatStyle = FlatStyle.Flat;
            A1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A1.Location = new Point(58, 72);
            A1.Name = "A1";
            A1.Size = new Size(177, 160);
            A1.TabIndex = 2;
            A1.Tag = "Play";
            A1.Text = "?";
            A1.UseVisualStyleBackColor = true;
            A1.Click += playerClick;
            // 
            // B1
            // 
            B1.FlatAppearance.BorderColor = Color.LightGray;
            B1.FlatStyle = FlatStyle.Flat;
            B1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B1.Location = new Point(241, 72);
            B1.Name = "B1";
            B1.Size = new Size(177, 160);
            B1.TabIndex = 3;
            B1.Tag = "Play";
            B1.Text = "?";
            B1.UseVisualStyleBackColor = true;
            B1.Click += playerClick;
            // 
            // C1
            // 
            C1.FlatAppearance.BorderColor = Color.LightGray;
            C1.FlatStyle = FlatStyle.Flat;
            C1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C1.Location = new Point(424, 72);
            C1.Name = "C1";
            C1.Size = new Size(177, 160);
            C1.TabIndex = 4;
            C1.Tag = "Play";
            C1.Text = "?";
            C1.UseVisualStyleBackColor = true;
            C1.Click += playerClick;
            // 
            // A2
            // 
            A2.FlatAppearance.BorderColor = Color.LightGray;
            A2.FlatStyle = FlatStyle.Flat;
            A2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A2.Location = new Point(58, 238);
            A2.Name = "A2";
            A2.Size = new Size(177, 160);
            A2.TabIndex = 5;
            A2.Tag = "Play";
            A2.Text = "?";
            A2.UseVisualStyleBackColor = true;
            A2.Click += playerClick;
            // 
            // B2
            // 
            B2.FlatAppearance.BorderColor = Color.LightGray;
            B2.FlatStyle = FlatStyle.Flat;
            B2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B2.Location = new Point(241, 238);
            B2.Name = "B2";
            B2.Size = new Size(177, 160);
            B2.TabIndex = 6;
            B2.Tag = "Play";
            B2.Text = "?";
            B2.UseVisualStyleBackColor = true;
            B2.Click += playerClick;
            // 
            // C2
            // 
            C2.FlatAppearance.BorderColor = Color.LightGray;
            C2.FlatStyle = FlatStyle.Flat;
            C2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C2.Location = new Point(424, 238);
            C2.Name = "C2";
            C2.Size = new Size(177, 160);
            C2.TabIndex = 7;
            C2.Tag = "Play";
            C2.Text = "?";
            C2.UseVisualStyleBackColor = true;
            C2.Click += playerClick;
            // 
            // A3
            // 
            A3.FlatAppearance.BorderColor = Color.LightGray;
            A3.FlatStyle = FlatStyle.Flat;
            A3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            A3.Location = new Point(58, 404);
            A3.Name = "A3";
            A3.Size = new Size(177, 160);
            A3.TabIndex = 8;
            A3.Tag = "Play";
            A3.Text = "?";
            A3.UseVisualStyleBackColor = true;
            A3.Click += playerClick;
            // 
            // B3
            // 
            B3.FlatAppearance.BorderColor = Color.LightGray;
            B3.FlatStyle = FlatStyle.Flat;
            B3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B3.Location = new Point(241, 404);
            B3.Name = "B3";
            B3.Size = new Size(177, 160);
            B3.TabIndex = 9;
            B3.Tag = "Play";
            B3.Text = "?";
            B3.UseVisualStyleBackColor = true;
            B3.Click += playerClick;
            // 
            // C3
            // 
            C3.FlatAppearance.BorderColor = Color.LightGray;
            C3.FlatStyle = FlatStyle.Flat;
            C3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C3.Location = new Point(424, 404);
            C3.Name = "C3";
            C3.Size = new Size(177, 160);
            C3.TabIndex = 10;
            C3.Tag = "Play";
            C3.Text = "?";
            C3.UseVisualStyleBackColor = true;
            C3.Click += playerClick;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderColor = Color.LightGray;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(280, 615);
            button10.Name = "button10";
            button10.Size = new Size(100, 30);
            button10.TabIndex = 11;
            button10.Tag = "Restart";
            button10.Text = "Restart";
            button10.UseVisualStyleBackColor = true;
            button10.Click += restartGame;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { difficultéToolStripMenuItem, modesDeJeuxToolStripMenuItem, affichageToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(669, 28);
            menuStrip.TabIndex = 12;
            menuStrip.Text = "menuStrip1";
            // 
            // difficultéToolStripMenuItem
            // 
            difficultéToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facileTSMI, difficileTSMI });
            difficultéToolStripMenuItem.Name = "difficultéToolStripMenuItem";
            difficultéToolStripMenuItem.Size = new Size(84, 24);
            difficultéToolStripMenuItem.Text = "Difficulté";
            // 
            // facileTSMI
            // 
            facileTSMI.Checked = true;
            facileTSMI.CheckState = CheckState.Checked;
            facileTSMI.Name = "facileTSMI";
            facileTSMI.Size = new Size(144, 26);
            facileTSMI.Text = "Facile";
            facileTSMI.Click += DifficultyClick;
            // 
            // difficileTSMI
            // 
            difficileTSMI.Name = "difficileTSMI";
            difficileTSMI.Size = new Size(144, 26);
            difficileTSMI.Text = "Difficile";
            difficileTSMI.Click += DifficultyClick;
            // 
            // modesDeJeuxToolStripMenuItem
            // 
            modesDeJeuxToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vsMode, iaMode });
            modesDeJeuxToolStripMenuItem.Name = "modesDeJeuxToolStripMenuItem";
            modesDeJeuxToolStripMenuItem.Size = new Size(120, 24);
            modesDeJeuxToolStripMenuItem.Text = "Modes de jeux";
            // 
            // vsMode
            // 
            vsMode.Checked = true;
            vsMode.CheckState = CheckState.Checked;
            vsMode.Name = "vsMode";
            vsMode.Size = new Size(174, 26);
            vsMode.Text = "2 Joueurs";
            vsMode.Click += gameMode;
            // 
            // iaMode
            // 
            iaMode.Name = "iaMode";
            iaMode.Size = new Size(174, 26);
            iaMode.Text = "Joueur VS IA";
            iaMode.Click += gameMode;
            // 
            // affichageToolStripMenuItem
            // 
            affichageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkMode });
            affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            affichageToolStripMenuItem.Size = new Size(87, 24);
            affichageToolStripMenuItem.Text = "Affichage";
            // 
            // darkMode
            // 
            darkMode.Name = "darkMode";
            darkMode.Size = new Size(191, 26);
            darkMode.Text = "Thème sombre";
            darkMode.Click += DarkModeClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 671);
            Controls.Add(label1);
            Controls.Add(button10);
            Controls.Add(C3);
            Controls.Add(B3);
            Controls.Add(A3);
            Controls.Add(C2);
            Controls.Add(B2);
            Controls.Add(A2);
            Controls.Add(C1);
            Controls.Add(B1);
            Controls.Add(A1);
            Controls.Add(iaWins);
            Controls.Add(playerWins);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Morpion";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label playerWins;
        private Label iaWins;
        private Button A1;
        private Button B1;
        private Button C1;
        private Button A2;
        private Button B2;
        private Button C2;
        private Button A3;
        private Button B3;
        private Button C3;
        private Button button10;
        private MenuStrip menuStrip;
        private ToolStripMenuItem difficultéToolStripMenuItem;
        private ToolStripMenuItem facileTSMI;
        private ToolStripMenuItem difficileTSMI;
        private ToolStripMenuItem modesDeJeuxToolStripMenuItem;
        private ToolStripMenuItem vsMode;
        private ToolStripMenuItem iaMode;
        private ToolStripMenuItem affichageToolStripMenuItem;
        private ToolStripMenuItem darkMode;
        private Label label1;
    }
}
