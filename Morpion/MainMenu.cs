using System.CodeDom;
using System.Reflection.Metadata;
using System.Timers;

namespace Morpion
{
    public partial class MainWindow : Form
    {
        private int turn = 1;
        private int ia_wins = 0;
        private int player_wins = 0;
        private string opponent = "IA";
        private Random rnd = new Random();
        private List<Button> buttons = new List<Button>();
        private Button[][] matrice = new Button[][] {};
        private Button[] diag1 = new Button[] { };
        private Button[] diag2 = new Button[] { };
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button> { B2,A1,C1,A3,C3, B1,A2,C2,B3};
            matrice = new Button[][] { [A1, B1, C1], [A2, B2, C2], [A3, B3, C3] };
            diag1 = new Button[] {A1,B2,C3};
            diag2 = new Button[] { A3, B2, C1 };
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "X" || button.Text == "O") { return; }
            button.Text = (turn % 2 == 0) ? "O" : "X";
            button.BackColor = (button.Text == "O") ? Color.IndianRed : Color.YellowGreen;
            turn++; 
            Check(sender, e);
            if (iaMode.Checked && turn%2 == 0) iaPlay(sender,e);
        }

        private void restartGame(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && string.Equals(X.Tag, "Play"))
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "?";
                    ((Button)X).BackColor = DefaultBackColor;
                }
            }
            turn = 1;
        }

        private bool Check(object sender, EventArgs e)
        {
            if ((A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
                || (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
                || (A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
                || (A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
                || (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
                || (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
                || (A1.Text == "O" && B2.Text == "O" && C3.Text == "O")
                || (A3.Text == "O" && B2.Text == "O" && C1.Text == "O"))
            {
                MessageBox.Show("You lose :(");
                ia_wins++;
                iaWins.Text = opponent + " wins - " + ia_wins.ToString();
                restartGame(sender, e);
                return true;
            }

            else if ((A1.Text == "X" && B1.Text == "X" && C1.Text == "X")
                || (A2.Text == "X" && B2.Text == "X" && C2.Text == "X")
                || (A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
                || (A1.Text == "X" && A2.Text == "X" && A3.Text == "X")
                || (B1.Text == "X" && B2.Text == "X" && B3.Text == "X")
                || (C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
                || (A1.Text == "X" && B2.Text == "X" && C3.Text == "X")
                || (A3.Text == "X" && B2.Text == "X" && C1.Text == "X"))
            {
                MessageBox.Show("You win it !!!");
                player_wins++;
                playerWins.Text = "Player wins - " + player_wins.ToString();
                restartGame(sender, e);
            }

            else if (turn == 10)
            {
                MessageBox.Show("It's a draw ;)");
                restartGame(sender, e);
            }
            return false;
        }

        private void DifficultyClick(object sender, EventArgs e)
        {
            if (facileTSMI.Checked && sender == difficileTSMI)
            {
                facileTSMI.Checked = false; difficileTSMI.Checked = true;
            }
            else if (difficileTSMI.Checked && sender == facileTSMI)
            {
                difficileTSMI.Checked = false; facileTSMI.Checked = true;
            }
        }

        private void gameMode(object sender, EventArgs e)
        {
            if (vsMode.Checked && sender == iaMode)
            {
                vsMode.Checked = false; iaMode.Checked = true;
            }
            else if (iaMode.Checked && sender == vsMode)
            {
                iaMode.Checked = false; vsMode.Checked = true;
            }
        }

        private void DarkModeClick(object sender, EventArgs e)
        {
            if (darkMode.Checked)
            {
                darkMode.Checked = false;
                this.BackColor = MainWindow.DefaultBackColor;
                menuStrip.BackColor = MainWindow.DefaultBackColor;
                menuStrip.ForeColor = Color.Black;
                foreach (Control X in this.Controls)
                {
                    if (X is Button && X.BackColor == Color.DimGray)
                    {
                        X.BackColor = Color.White;
                    }
                    if (X is Button button)
                    {
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 1;
                        button.FlatAppearance.BorderColor = Color.LightGray;
                    }
                }
            }
            else
            {
                darkMode.Checked = true;
                this.BackColor = Color.Black;
                menuStrip.BackColor = Color.Black;
                menuStrip.ForeColor = Color.LightGray;
                foreach (Control X in this.Controls)
                {
                    if (X is Button && (X.BackColor != Color.IndianRed && X.BackColor != Color.YellowGreen))
                    {
                        X.BackColor = Color.DimGray;
                    }
                    if (X is Button button)
                    {
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                    }
                }
            }
        }

        private void iaPlay(object sender, EventArgs e)
        {
            if (facileTSMI.Checked)
            {
                var idx = 4;
                Console.WriteLine(buttons[idx].Text);
                while (buttons[idx].Text != "?")
                {
                    idx = rnd.Next(0,8);
                }
                buttons[idx].Text = "O";
                buttons[idx].BackColor = Color.IndianRed;

            }
            else
            {

                //First IA check if he can win
                var col = new List<List<Button>> { new List<Button>(), new List<Button>(), new List<Button>() };

                foreach (Button[] n in matrice)
                {
                    foreach (Button button in n)
                    {
                        if (button.Name[0] == 'A') { col[0].Add(button); }
                        if (button.Name[0] == 'B') { col[1].Add(button); }
                        if (button.Name[0] == 'C') { col[2].Add(button); }
                    }
                }

                foreach (Button[] n in matrice)
                {
                    int countO = n.Count(btt => btt.Text == "O");
                    if (countO == 2)
                    {
                        foreach (Button elem in n)
                        {
                            if (elem.Text == "?")
                            {
                                elem.Text = "O";
                                elem.BackColor = Color.IndianRed;
                                if (Check(sender, e)) { return; }
                                turn++;
                                return;
                            }
                        }
                    }
                }

                foreach (List<Button> c in col)
                {
                    int countO = c.Count(btt => btt.Text == "O");
                    if (countO == 2)
                    {
                        foreach (Button elem in c)
                        {
                            if (elem.Text == "?")
                            {
                                elem.Text = "O";
                                elem.BackColor = Color.IndianRed;
                                if (Check(sender, e)) { return; }
                                turn++;
                                return;
                            }
                        }
                    }
                }

                if (diag1.Count(btt => btt.Text == "O") == 2)
                {
                    foreach (Button elem in diag1)
                    {
                        if (elem.Text == "?")
                        {
                            elem.Text = "O";
                            elem.BackColor = Color.IndianRed;
                            if (Check(sender, e)) { return; }
                            turn++;
                            return;
                        }
                    }
                }

                if (diag2.Count(btt => btt.Text == "O") == 2)
                {
                    foreach (Button elem in diag2)
                    {
                        if (elem.Text == "?")
                        {
                            elem.Text = "O";
                            elem.BackColor = Color.IndianRed;
                            if (Check(sender, e)) { return; }
                            turn++;
                            return;
                        }
                    }
                }

                //manage if he can block
                foreach (Button[] n in matrice)
                {
                    int countX = n.Count(btt => btt.Text == "X");
                    if (countX == 2)
                    {
                        foreach (Button elem in n)
                        {
                            if (elem.Text == "?")
                            {
                                elem.Text = "O";
                                elem.BackColor = Color.IndianRed;
                                if (Check(sender, e)) { return; }
                                turn++;
                                return;
                            }
                        }
                    }

                }

                foreach (List<Button> c in col)
                {
                    int countX = c.Count(btt => btt.Text == "X");
                    if (countX == 2)
                    {
                        foreach (Button elem in c)
                        {
                            if (elem.Text == "?")
                            {
                                elem.Text = "O";
                                elem.BackColor = Color.IndianRed;
                                if (Check(sender, e)) { return; }
                                turn++;
                                return;
                            }
                        }
                    }
                }

                if ( diag1.Count(btt => btt.Text == "X") == 2)
                {
                    foreach (Button elem in diag1)
                    {
                        if (elem.Text == "?")
                        {
                            elem.Text = "O";
                            elem.BackColor = Color.IndianRed;
                            if (Check(sender, e)) { return; }
                            turn++;
                            return;
                        }
                    }
                }

                if (diag2.Count(btt => btt.Text == "X") == 2)
                {
                    foreach (Button elem in diag2)
                    {
                        if (elem.Text == "?")
                        {
                            elem.Text = "O";
                            elem.BackColor = Color.IndianRed;
                            if (Check(sender, e)) { return; }
                            turn++;
                            return;
                        }
                    }
                }

                var idx = 0;
                while (buttons[idx].Text != "?")
                {
                    idx++;
                }
                buttons[idx].Text = "O";
                buttons[idx].BackColor = Color.IndianRed;

            }
            
            turn++;
            Check(sender, e);
        }
    }
}
