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
    public partial class UpdateRecord : Form
    {
        public UpdateRecord()
        {
            InitializeComponent();
        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            if (numberBox.Text == "" || dateBox.Text == "" || moneyBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                String query = "update Money set NameMoney = '" + moneyBox.Text + "', id_Date = '" + dateBox.Text + "' where Id_Money = '" + numberBox.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Запись изменена!");
                    this.Hide();
                    MainMenu win = new MainMenu();
                    win.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка ввода. Попробуйте еще раз");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
