using Ado.Net.Learning.Data.Models;
using Ado.Net.Learning.Data.Repositories;

namespace Ado.Net.Learning.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitData();
        }


        private void InitData()
        {
            var gameRepo = new GameRepository();
            var games = gameRepo.GetGames();
            dataGridView1.DataSource = games;

        }
        //rename btn
        private void button1_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(textBoxIns.Text, false);
            var gameRepo = new GameRepository();
            gameRepo.InsertGame(newGame);
            InitData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var y = this.dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value;
            
            Game newGame = new Game(Convert.ToInt32(y));

            var gameRepo = new GameRepository();
            gameRepo.DeleteGame(newGame);
            InitData();
            new Form1().ShowDialog();
        }

    }
}