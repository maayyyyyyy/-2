using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kfkfkfkf
{
    public partial class Avtorisacia : Form
    {
        public Avtorisacia()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\as2\source\repos\Kfkfkfkf\Kfkfkfkf\Lala.mdf;Integrated Security=True");
        private void avto_Click(object sender, EventArgs e)
        {

            int role1;
            con.Open();
            string query = $"SELECT * FROM lala WHERE login = N'{login.Text}'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if ((bool)reader.Read())
            {
                if (reader.GetValue(2).ToString() == pass.Text)
                {
                    role1 = int.Parse(reader.GetValue(3).ToString());
                    con.Close();
                    if (role1 == 1)
                    {
                        student newform = new student();
                        newform.Show();
                        this.Hide();
                    }
                    else
                    {
                        prepod newform1 = new prepod();
                        newform1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Несовпал парол");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Такого логина нема");
                con.Close();
            }
            con.Close();
        }

    }
}

