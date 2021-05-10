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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if(newlogBox.Text == "" || newpassBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                String query = "insert into UsersDB (Login,Password) values ('" + newlogBox.Text + "','" + newpassBox.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка ввода. Попробуйте еще раз");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
