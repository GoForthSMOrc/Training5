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
    public partial class AddNewRecord : Form
    {
        public AddNewRecord()
        {
            InitializeComponent();
        }

        private void AddNewRecordButton_Click(object sender, EventArgs e)
        {
            if (newrecordBox.Text == "" || newdateBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                String query = "insert into Money (NameMoney,id_Date) values ('" + newrecordBox.Text + "','" + newdateBox.Text + "');";
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
    }
}
