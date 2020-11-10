using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using MySql.Data;
using BunifuColorTransition = BunifuColorTransition.BunifuColorTransition;

namespace Pokedex
{
    public partial class PokeDex : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;database=pokedex;Convert Zero Datetime=True;port=3306;username=root;password=");
        private MySqlDataReader dr;
        private MySqlCommand cmd;
        private int movY;
        private int movX;
        private int mov;
        private BunifuLabel label;
        private string ImagePath = "";
        public PokeDex()
        {
            InitializeComponent();
            getPokeNum();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void getPokeNum()
        {
            con.Open();
            cmd = new MySqlCommand("Select Number, Name from pokemondb",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label = new BunifuLabel();
                label.Text =  dr["Number"].ToString();
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Font = new Font("Roboto", 14);
                label.Cursor = Cursors.Hand;
                label.Tag = dr["Name"].ToString();
                label.CursorType = Cursors.Hand;
                PokeFlowPanel.Controls.Add(label);
                label.Click += new EventHandler(onClick);
            }
            dr.Close();
            con.Close();
        }
        private void upScroll_Click(object sender, EventArgs e)
        {
            Point current = PokeFlowPanel.AutoScrollPosition;
            Point scrolled = new Point(current.X, -current.Y - 70);
            PokeFlowPanel.AutoScrollPosition = scrolled;
        }

        private void downScroll_Click(object sender, EventArgs e)
        {
            Point current = PokeFlowPanel.AutoScrollPosition;
            Point scrolled = new Point(current.X, -current.Y + 70);
            PokeFlowPanel.AutoScrollPosition = scrolled;
        }
        public void onClick(object sender, EventArgs e)
        {
            string tag = ((BunifuLabel)sender).Tag.ToString();
            con.Open();
            cmd = new MySqlCommand("SELECT * from pokemondb where Name like '" + tag + "'",con );
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                bunifuTransition.ShowSync(pokeNumber);
                bunifuTransition.ShowSync(pokeName);
                bunifuTransition.ShowSync(speciesValue);
                bunifuTransition.ShowSync(baseStatsLabel);
                bunifuTransition.ShowSync(type1Content);
                pokeNumber.Text = "#" + dr["Number"].ToString();
                pokeName.Text = dr["Name"].ToString();
                speciesValue.Text = dr["Species"].ToString();
                heightValue.Text = dr["Height"].ToString();
                weightValue.Text = dr["Weight"].ToString();
                pokeType2Content.Text = dr["SecondType"].ToString();
                type1Content.Text = dr["FirstType"].ToString();
                atkValue.Value = int.Parse(dr["Attack"].ToString());
                spAtkContentLabel.Text = dr["Attack"].ToString();
                hpValue.Value = int.Parse(dr["HP"].ToString());
                hpValueLabel.Text = dr["HP"].ToString();
                defValue.Value = int.Parse(dr["Defense"].ToString());
                defenseValueLabel.Text = dr["Defense"].ToString();
                spAtkValue.Value = int.Parse(dr["Sp.Atk"].ToString());
                spAtkContentLabel.Text = dr["Sp.Atk"].ToString();
                spDefValue.Value = int.Parse(dr["Sp.Def"].ToString());
                spDefContentLabel.Text = dr["Sp.Def"].ToString();
                speedValue.Value = int.Parse(dr["Speed"].ToString());
                speedLabelContent.Text = dr["Speed"].ToString();
                totalValue.Value = int.Parse(dr["TotalStats"].ToString());
                totalLabel.Text = dr["TotalStats"].ToString();
                ImagePath = Convert.ToString(dr["PokePath"]);
                if (ImagePath != "")
                {
                    Image image = Image.FromFile(ImagePath);
                    pokemonImage.Image = image;
                }
                else
                {
                    MessageBox.Show("Image Not Found");
                }
                if (type1Content.Text == "Fire")
                {
                   
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(143)))), ((int)(((byte)(127)))));
                }
                else if (type1Content.Text == "Grass")
                {
                    
                    this.BackColor = Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(209)))), ((int)(((byte)(180)))));
                }
                else if (type1Content.Text == "Water")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(135)))), ((int)(((byte)(153)))));
                }
                else if (type1Content.Text == "Bug")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(190)))), ((int)(((byte)(109)))));
                }
                else if (type1Content.Text == "Normal")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(184)))), ((int)(((byte)(177)))));
                }
                else if (type1Content.Text == "Dark")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
                }
                else if (type1Content.Text == "Electric")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(196)))), ((int)(((byte)(106)))));
                }
                else if (type1Content.Text == "Poison")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(111)))), ((int)(((byte)(154)))));
                }
                else if (type1Content.Text == "Ice")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(198)))), ((int)(((byte)(228)))));
                }
                else if (type1Content.Text == "Ground")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(102)))));
                }
                else if (type1Content.Text == "Ghost")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(197)))));
                }
                else if (type1Content.Text == "Fighting")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(109)))), ((int)(((byte)(94)))));
                }
                else if (type1Content.Text == "Psychic")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
                }   
                else if (type1Content.Text == "Flying")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(160)))), ((int)(((byte)(242)))));
                }
                else if (type1Content.Text == "Rock")
                {
                  
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(182)))), ((int)(((byte)(124)))));
                }
                else if (type1Content.Text == "Dragon")
                {
                    
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(199)))));
                }
                else if (type1Content.Text == "Fairy")
                {
                   
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(240)))));
                }
                else if (type1Content.Text == "Steel")
                {
                    this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
                }
                
            }
            con.Close();
        }
        private void PokeDex_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void PokeDex_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void PokeDex_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movY = e.Y;
            movX = e.X;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
