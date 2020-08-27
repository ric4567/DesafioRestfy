using HashTest;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioRestfy
{
    public partial class Form1 : Form
    {
        private SQLiteConnection m_dbConnection;

        public Form1()
        {
            InitializeComponent();
            GenerateDatabase();
        }

        private async void consumeButton_Click(object sender, EventArgs e)
        {
            var data = await GetDataFromApi();
            dataGrid.DataSource = data;
            foreach (User user in data)
            {
                var query = new SQLiteCommand($"select * from users where id = '{user.Id}'", m_dbConnection);
                var reader = await query.ExecuteReaderAsync();
                if (!reader.Read())
                {
                    var sql = $"insert into users values ({user.Id}, '{user.Name}', '{user.Company}', '{user.Hash}', '{user.HashDescription}', {user.Role})";
                    var command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.AutoGenerateColumns = false;
        }

        private async void filterButton_Click(object sender, EventArgs e)
        {
            var data = await GetDataFromDatabase();

            if (!string.IsNullOrWhiteSpace(companyTextBox.Text))
                data = data.Where(u => u.Company.Contains(companyTextBox.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();

            if (!string.IsNullOrWhiteSpace(userTextBox.Text))
                data = data.Where(u => u.Name.Contains(userTextBox.Text, StringComparison.InvariantCultureIgnoreCase)).ToList();

            dataGrid.DataSource = data;
        }

        private async Task<IEnumerable<User>> GetDataFromDatabase()
        {
            var query = new SQLiteCommand($"select * from users", m_dbConnection);
            var reader = await query.ExecuteReaderAsync();
            var retorno = new List<User>();

            while (reader.Read())
            {
                var user = new User
                {
                    Id = reader["id"].ToString(),
                    Name = reader["name"].ToString(),
                    Company = reader["company"].ToString(),
                    Role = reader["role"].ToString()
                };
                user.SetHash(reader["hash"].ToString());
                retorno.Add(user);
            }
            return retorno;
        }

        private async Task<IList<User>> GetDataFromApi()
        {
            consumeButton.Enabled = false;
            filterButton.Enabled = false;
            var client = new HttpClient();
            var response = await client.GetAsync("https://0f26bdf5-c99d-4193-b418-5a036dc134d8.mock.pstmn.io/users");
            var a = await response.Content.ReadAsStringAsync();

            var b = JsonSerializer.Deserialize<UsersList>(a, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            foreach (var user in b.Users)
            {
                var hash = new Hash();
                user.SetHash(hash.BuildHash(user.Role));
            }
            consumeButton.Enabled = true;
            filterButton.Enabled = true;
            return b.Users.ToList();
        }

        private void GenerateDatabase()
        {
            SQLiteConnection.CreateFile("Restfy.sqlite");
            m_dbConnection = new SQLiteConnection("Data Source=Restfy.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = @"create table users (id int primary key, name varchar(20), company varchar(20), hash varchar(100), hashDescription varchar(20), role int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
    }
}