using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace oop2_c_sharp_supermarket_management_windowsform
{
    public partial class MessagesChat : Form
    {
        int contact = 0;
        string path = $@"Data Source={EnvironmentProvider.server};Initial Catalog={EnvironmentProvider.database};User Id={EnvironmentProvider.userId};Password={EnvironmentProvider.Password};Integrated Security={EnvironmentProvider.security}";

        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;

        public MessagesChat()
        {
            InitializeComponent();
            panel1.Visible = false;
            messagesBox.Visible = false;

        }

        public MessagesChat(int id)
        {
            InitializeComponent();
            panel1.Visible = true;
            messagesBox.Visible = true;


            con = new SqlConnection(path);
            contact = id;
            loadUsers(id);
        }



        public void loadUsers(int id)
        {

            try
            {
                string query = $@"
IF OBJECT_ID('Messages', 'U') IS NOT NULL 
BEGIN 
select * from Messages Where (Sender = {UserProvider.id} and Reciever = {id}) or (Sender = {id} and Reciever = {UserProvider.id})
END";

                dt = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    for (int index = 0; index < dt.Rows.Count; index++)
                    {
                        Messages(int.Parse(dt.Rows[index].Field<int>("Sender").ToString().Trim()), int.Parse(dt.Rows[index].Field<int>("Reciever").ToString().Trim()), dt.Rows[index].Field<string>("Text").Trim());
                    }


                }
                else
                {
                    MessageBox.Show("There has been an error on importing Messages", "Database Error");

                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Import Error");
            }
        }

        private Label Messages(int sender,int reciever,  string text)
        {
            Label txt = new Label();
            if(sender==UserProvider.id)
            {
                txt.Dock = System.Windows.Forms.DockStyle.Right;
                txt.BackColor = Color.Ivory;

            }
            else
            {
                txt.Dock = System.Windows.Forms.DockStyle.Left;
                txt.BackColor = Color.Beige;

            }


            txt.Name = text ;
            txt.Text = text;

            // messagesBox.Controls.Add(txt);



            return txt;
        }

        private Panel MessageCon(int sender, int reciever, string text)
        {
            Panel Cont = new Panel();
            Cont.Dock = System.Windows.Forms.DockStyle.Top;
            if (sender == UserProvider.id)
            {
                
                Cont.BackColor = Color.Ivory;

            }
            else
            {
                
                Cont.BackColor = Color.Beige;

            }

            Cont.Controls.Add(Messages(sender, reciever, text));
            messagesBox.Controls.Add(Cont);


            return Cont;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            writeInDatabase();
        }

        private void writeInDatabase()
        {
            try
            {
                con.Open();

                string query = $@"
IF OBJECT_ID('Messages', 'U') IS NOT NULL 
BEGIN 
insert into Messages (Sender, Reciever, Text) 
values({UserProvider.id},{contact},'{textBox1.Text}')
END 
ELSE BEGIN 
create table Messages (Id INT NOT NULL PRIMARY KEY identity(1,1), Sender NUMERIC(18) NOT NULL ,Reciever NUMERIC(18) NOT NULL ,   Text NVARCHAR(100) NOT NULL )
insert into Messages (Sender, Reciever, Text) 
values({UserProvider.id},{contact},'{textBox1.Text}')
END";



                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";




            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, ex.Message);
            }
        }
    }
}





