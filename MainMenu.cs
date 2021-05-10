using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trenirovochka
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            getInfo(listView1);
        }

        void getInfo(ListView List)
        {
            String query = "select Money.Id_Money, Money.NameMoney,Datem.NameDateM from Money join DateM on Money.id_Date = DateM.Id_Date order by Id_Money ASC;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска. Попробуйте еще раз");
                MessageBox.Show(ex.Message);
            }
        }
        private void NewUserButton_Click(object sender, EventArgs e)
        {
            AddNewUser win = new AddNewUser();
            win.Show();
        }

        private void NewRecordButton_Click(object sender, EventArgs e)
        {
            AddNewRecord win = new AddNewRecord();
            win.Show();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (DeleteBox.Text == "")
            {
                MessageBox.Show("Поле должно быть заполнено!");
            }
            else
            {
                String query = "delete from Money where Id_Money = '" + DeleteBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка ввода. Попробуйте еще раз");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FindRecordButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (FindBox.Text == "")
            {
                MessageBox.Show("Поле должно быть заполнено!");
            }
            else
            { 
                String query = "select * from Money where Id_Money = '" + FindBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка поиска. Попробуйте еще раз");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            UpdateRecord win = new UpdateRecord();
            win.Show();
            this.Hide();
        }
    }
}
