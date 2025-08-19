using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupp2_SUppgift
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lagDBDataSet.tblSport' table. You can move, or remove it, as needed.
            this.tblSportTableAdapter.Fill(this.lagDBDataSet.tblSport);
            // TODO: This line of code loads data into the 'lagDBDataSet.tblLag' table. You can move, or remove it, as needed.
            this.tblLagTableAdapter.Fill(this.lagDBDataSet.tblLag);


        }
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();

            frmNyttLag Test = new frmNyttLag();
            Test.Show();

        }

        private void btnValjLag_Click(object sender, EventArgs e)
        {
        }

        private void lstLag_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //användaren ska kunna välja 4 st lag från datagridview
            //lagen ska sedan skrivas i textrutor
            if (e.RowIndex >= 0)
            {
                string lagnamn = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //Fyll nästa tomma TextBox
                if (string.IsNullOrEmpty(txtLagEtt.Text) && txtLagTva.Text != lagnamn && txtLagTre.Text != lagnamn && txtLagFyra.Text != lagnamn)
                {
                    txtLagEtt.Text = lagnamn;
                }
                else if (string.IsNullOrEmpty(txtLagTva.Text) && txtLagEtt.Text != lagnamn && txtLagTre.Text != lagnamn && txtLagFyra.Text != lagnamn)
                {
                    txtLagTva.Text = lagnamn;
                }
                else if (string.IsNullOrEmpty(txtLagTre.Text) && txtLagTva.Text != lagnamn && txtLagEtt.Text != lagnamn && txtLagFyra.Text != lagnamn)
                {
                    txtLagTre.Text = lagnamn;
                }
                else if (string.IsNullOrEmpty(txtLagFyra.Text) && txtLagTva.Text != lagnamn && txtLagTre.Text != lagnamn && txtLagEtt.Text != lagnamn)
                {
                    txtLagFyra.Text = lagnamn;
                }
                else
                {
                    MessageBox.Show("Alla 4 lag är redan valda.");
                }
            }
        }



        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbValjLag_MouseClick(object sender, MouseEventArgs e)
        {
            txtLagEtt.Clear();
            txtLagTva.Clear();
            txtLagTre.Clear();
            txtLagFyra.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLagEtt.Clear();
            txtLagTva.Clear();
            txtLagTre.Clear();
            txtLagFyra.Clear();

            DGVresultat.Rows.Clear();
            DGVTabell.DataSource = null;
        }
    public class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
    }
    public class Match
    {
        public Team Home { get; set; }
        public Team Away { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
    }

        private void btnRun_Click(object sender, EventArgs e)
        {
            DGVresultat.Rows.Clear();
            DGVTabell.DataSource = null;
            Random slumpMal = new Random();
            string textCmb = cmbValjLag.Text;
            string[] lagArray = new string[4];
            string namn1 = txtLagEtt.Text;
            //MessageBox.Show($"{namn1}");
            List<Match> matches = new List<Match>();
            List<Team> teams = new List<Team>
                {
                    new Team { Name = ($"{namn1}") },
                    new Team { Name = txtLagTva.Text },
                    new Team { Name = txtLagTre.Text },
                    new Team { Name = txtLagFyra.Text }
                };

            //Hockeyresultat
            if (cmbValjLag.SelectedIndex == 0)
            {
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int j = i+1; j < teams.Count; j++)
                    {
                        var home = teams[i];
                        var away = teams[j];

                        // Slumpa resultat (0-6 mål)
                        int homeGoals = slumpMal.Next(0, 7);
                        int awayGoals = slumpMal.Next(0, 7);

                        // Skapa match
                        matches.Add(new Match
                        {
                            Home = home,
                            Away = away,
                            HomeGoals = homeGoals,
                            AwayGoals = awayGoals
                        });

                        // Uppdatera statistik
                        home.GoalsFor += homeGoals;
                        home.GoalsAgainst += awayGoals;
                        away.GoalsFor += awayGoals;
                        away.GoalsAgainst += homeGoals;

                        if (homeGoals > awayGoals)
                        {
                            home.Points += 3;
                        }
                        else if (awayGoals > homeGoals)
                        {
                            away.Points += 3;
                        }
                        else
                        {
                            home.Points += 1; away.Points += 1;
                        }
                        DGVresultat.Rows.Add($"{home.Name} \t {homeGoals} - {awayGoals} \t {away.Name}");

                        var table = teams
                           .OrderByDescending(t => t.Points)
                           .ThenByDescending(t => t.GoalsFor)
                           .ThenByDescending(t => t.GoalsAgainst)
                           .Select(t => new
                           {
                               Lag = t.Name,
                               Poäng = t.Points,
                               GjordaMål = t.GoalsFor,
                               Insläppta = t.GoalsAgainst,
                               Målskillnad = t.GoalsFor - t.GoalsAgainst
                           })
                           .ToList();

                        // Visa tabell i andra DataGridView
                        DGVTabell.DataSource = null;
                        DGVTabell.DataSource = table;
                    }
                }
                
            }
            //Fotboll
            else if (cmbValjLag.SelectedIndex == 1)
            {
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int j = i + 1; j < teams.Count; j++)
                    {
                        var home = teams[i];
                        var away = teams[j];

                        // Slumpa resultat (0-6 mål)
                        int homeGoals = slumpMal.Next(0, 3);
                        int awayGoals = slumpMal.Next(0, 3);

                        // Skapa match
                        matches.Add(new Match
                        {
                            Home = home,
                            Away = away,
                            HomeGoals = homeGoals,
                            AwayGoals = awayGoals
                        });

                        // Uppdatera statistik
                        home.GoalsFor += homeGoals;
                        home.GoalsAgainst += awayGoals;
                        away.GoalsFor += awayGoals;
                        away.GoalsAgainst += homeGoals;

                        if (homeGoals > awayGoals)
                        {
                            home.Points += 3;
                        }
                        else if (awayGoals > homeGoals)
                        {
                            away.Points += 3;
                        }
                        else
                        {
                            home.Points += 1; away.Points += 1;
                        }
                        DGVresultat.Rows.Add($"{home.Name} {homeGoals} - {awayGoals} {away.Name}");

                        var table = teams
                           .OrderByDescending(t => t.Points)
                           .ThenByDescending(t => t.GoalsFor)
                           .ThenByDescending(t => t.GoalsAgainst)
                           .Select(t => new
                           {
                               Lag = t.Name,
                               Poäng = t.Points,
                               GjordaMål = t.GoalsFor,
                               Insläppta = t.GoalsAgainst,
                               Målskillnad = t.GoalsFor - t.GoalsAgainst
                           })
                           .ToList();

                        // Visa tabell i andra DataGridView
                        DGVTabell.DataSource = null;
                        DGVTabell.DataSource = table;
                    }
                }
                //MessageBox.Show($"{textCmb}");

            }
            //Basket
            else if (cmbValjLag.SelectedIndex == 2)
            {
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int j = i + 1; j < teams.Count; j++)
                    {
                        var home = teams[i];
                        var away = teams[j];

                        // Slumpa resultat (0-6 mål)
                        int homeGoals = slumpMal.Next(50, 120);
                        int awayGoals = slumpMal.Next(50, 120);

                        // Skapa match
                        matches.Add(new Match
                        {
                            Home = home,
                            Away = away,
                            HomeGoals = homeGoals,
                            AwayGoals = awayGoals
                        });

                        // Uppdatera statistik
                        home.GoalsFor += homeGoals;
                        home.GoalsAgainst += awayGoals;
                        away.GoalsFor += awayGoals;
                        away.GoalsAgainst += homeGoals;

                        if (homeGoals > awayGoals)
                        {
                            home.Points += 3;
                        }
                        else if (awayGoals > homeGoals)
                        {
                            away.Points += 3;
                        }
                        else
                        {
                            home.Points += 1; away.Points += 1;
                        }
                        DGVresultat.Rows.Add($"{home.Name} {homeGoals} - {awayGoals} {away.Name}");

                        var table = teams
                           .OrderByDescending(t => t.Points)
                           .ThenByDescending(t => t.GoalsFor)
                           .ThenByDescending(t => t.GoalsAgainst)
                           .Select(t => new
                           {
                               Lag = t.Name,
                               Poäng = t.Points,
                               GjordaMål = t.GoalsFor,
                               Insläppta = t.GoalsAgainst,
                               Målskillnad = t.GoalsFor - t.GoalsAgainst
                           })
                           .ToList();

                        // Visa tabell i andra DataGridView
                        DGVTabell.DataSource = null;
                        DGVTabell.DataSource = table;
                    }
                }
                //MessageBox.Show($"{textCmb}");

            }

            


        }





    }
    //    // Rensa textrutorna först
    //    if (lstLag.SelectedItems.Count > 4)
    //    {
    //        MessageBox.Show("Välj 4 st Lag!");
    //        return;


    //    // Lägg in valen i textrutorna
    //    int LagNr = 0;
    //    foreach (var anvLag in lstLag.SelectedItems)
    //    {
    //        if (LagNr == 0) txtLagEtt.Text = anvLag.ToString();

    //        else if (LagNr == 1) txtLagEtt.Text = anvLag.ToString();
    //        else if (LagNr == 2) txtLagEtt.Text = anvLag.ToString();
    //        else if (LagNr == 3) txtLagEtt.Text = anvLag.ToString();
    //        LagNr++;

    //        // Stoppa om vi fyllt alla textrutor
    //        if (LagNr == 4) break;
    //    }

    //}
    // Skriv ut matchresultatet till datagridview


    //Console.WriteLine("Resultat:");
    //foreach (var m in matches)
    //{
    //    Console.WriteLine($"{m.Home.Name} {m.HomeGoals} - {m.AwayGoals} {m.Away.Name}");
    //}

    //// Skriv ut tabell
    //Console.WriteLine("\nTabell:");
    //
    //{
    //    Console.WriteLine($"{t.Name,-12} Poäng: {t.Points}, Mål: {t.GoalsFor}-{t.GoalsAgainst}");
    //}
    //Summera resultatet i ett datagridview som en tabell

    //DGVTabell.Rows.Add($"{Na} Poäng: {Points}, Mål: {GoalsFor}-{GoalsAgainst}");

    //DGVTabell.DataSource = matches;
    //string namn1 = txtLagEtt.Text;
    //lagArray[1] = txtLagTva.Text;
    //lagArray[2] = txtLagTre.Text;
    //lagArray[3] = txtLagFyra.Text;

    //Hämta namn på team från textruta och lägg i lista





    //int ett = lag1 + " " + slumpMal.Next(0, 6);
    //lag2 = lag2 + " " + slumpMal.Next(0, 6);

    //if (lag1.slumpMal < lag2)
    //MessageBox.Show($"{lag1} - {lag2}");
    //for (int i = 0; i < lagArray.Length; i++)
    //{
    //    for (int j = i + 1; j < lagArray.Length; j++)
    //    {
    //        var hemma = lagArray[i];
    //        var borta = lagArray[j];
    // Om ingen rad är vald, avbryt
    // Om en rad är vald, hämta värdena från den raden och skriv dem i textrutorna

    //if (e.RowIndex >= 0)
    //{
    //dataGridView1.MultiSelect = false;
    //dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
    //dataGridView1.Rows[e.RowIndex].Selected = true; // Markera den valda raden
    //// Hämta värdena från den valda raden coh placera i en array

    //string valtVärde = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
    ////Skriv ut värden i textrutor
    //string[] valtLag = new string[4];
    //// Skapa en array för att lagra värdena från den valda raden


    //DataGridViewRow rad = dataGridView1.Rows[e.RowIndex];
    //    valtLag = new string[rad.Cells.Count];

    ////    for (int i = 0; i < rad.Cells.Count; i++)
    ////    {
    ////    //valtLag[i] = valtVärde;
    ////    // Hämta cellvärdet från den klickade raden 
    ////    valtLag[i] = rad.Cells[i].Value?.ToString(); // Använd ?. för att hantera null-värden
    ////}


    ////string[] valtLag = new string[4];
    ////int j = 0;
    ////DataGridViewRow rad = dataGridView1.Rows;
    ////for (int i = 0; i < 4; i++)
    ////{ 
    ////    // Hämta cellvärdet från den klickade raden 
    ////    valtLag[i] = rad.Cells[i].Value?;
    ////    j++;
    ////    // Skriv värdet till textrutan

    ////}
    //string lagString = AngeLag(valtLag);
    //// Skriv värdet till textrutan


    //txtLagEtt.Text = valtLag[0];
    //    txtLagTva.Text = valtLag[1];
    //    txtLagTre.Text = valtLag[2];
    //    txtLagFyra.Text = valtLag[3];

    //}
    //string valtLag = dataGridView1.CellContentClick().ToString();

    //// Skriv värdet till textrutan
    //textBox1.Text = valtVärde;
    //private void dgvLag_CellClick(object sender, DataGridViewCellEventArgs e)
    //if (lstLag.SelectedItems.Count >= 4)
    //{
    //    txtLagEtt.Text = lstLag.SelectedItems[0].ToString();
    //    txtLagTva.Text = lstLag.SelectedItems[1].ToString();
    //    txtLagTre.Text = lstLag.SelectedItems[2].ToString();
    //    txtLagFyra.Text = lstLag.SelectedItems[3].ToString();
    //}
    //else
    //{
    //    MessageBox.Show("Välj minst 4 värden i listan.");
    //}
    //private string AngeLag(string[] x)
    //{
    //    // Skapa en array som tar emot lag från klick i datagridview
    //    string[] lag = new string[4];
    //    for (int i = 0; i < x.Length && i < 4; i++)
    //    {
    //        lag[i] = x[i];
    //    }
    //    string lagString = string.Join(", ", lag);
    //    return lagString;
    //}




}





