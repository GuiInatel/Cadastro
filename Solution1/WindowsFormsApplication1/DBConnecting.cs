using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DBConnecting
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnecting()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "localhost";
            database = "cp2cadastro";
            //database = "test";
            uid = "root";
            password = "165145jgr";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        //update banco
        public void Update(string nome)
        {
            string[] split = nome.Split(new Char[] { ',' });
            int login = 0;

            if (split[12] == "True")
            {
                login = 1;
            }
            else
            {
                login = 0;
            }

            string query = "UPDATE empresarios SET nome = '"+split[0]+"', codigo = '"+split[1]+"', imagem = '"+split[2]+"', setor = '"+split[3]+"', cargo = '"+split[4]+"', dataEntrada = '"+split[5]+"', dedicatoria = '"+split[6]+"', atividade = '"+split[7]+"', rg = '"+split[8]+"', cpf = '"+split[9]+"', ativo = '"+split[10]+"', faltas = '"+split[11]+"', login = '"+login+"', endereco = '"+split[13]+"', endNum = '"+split[14]+"', endBairro = '"+split[15]+"', telefone = '"+split[16]+"', curso = '"+split[17]+"' WHERE codigo='"+split[18]+"'";
            

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(int codigo)
        {
            string query = "DELETE FROM empresarios WHERE codigo='" + codigo + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<Empresarios> Select()
        {
            string query = "SELECT * FROM empresarios";

            //Create a list to store the result
            List<Empresarios> empresariosList = new List<Empresarios>();
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Empresarios empresarios = new Empresarios();
                    
                    empresarios.nome = (string)dataReader["nome"];
                    empresarios.id = (int)dataReader["id"];
                    empresarios.codigo = (int)dataReader["codigo"];
                    empresarios.imagem = (string)dataReader["imagem"];
                    empresarios.setor = (string)dataReader["setor"];
                    empresarios.cargo = (string)dataReader["cargo"];
                    empresarios.dataEntrada = (DateTime)dataReader["dataentrada"];
                    empresarios.dataSaida = (DateTime)dataReader["dataSaida"];
                    empresarios.dedicatoria = (string)dataReader["dedicatoria"];
                    empresarios.atividade = (string)dataReader["atividade"];
                    empresarios.rg = (int)dataReader["rg"];
                    empresarios.endereco = (string)dataReader["endereco"];
                    empresarios.endNum = (int)dataReader["endNum"];
                    empresarios.endBairro = (string)dataReader["endBairro"];
                    empresarios.login = (bool)dataReader["login"];
                    empresarios.ativo = (bool)dataReader["ativo"];
                    empresarios.faltas = (int)dataReader["faltas"];
                    empresarios.telefone = (string)dataReader["telefone"];//erro ao buscar informação de telefone e cpf
                    empresarios.cpf = (string)dataReader["cpf"];//provavel erro de variavel no banco de dados
                    empresarios.curso = (string)dataReader["curso"];
                    empresariosList.Add(empresarios);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return empresariosList;
            }
            else
            {
                return empresariosList;
            }
        }

        //retorna por id
        public Empresarios SelectId(int id)
        {
            Empresarios empresarios = new Empresarios();

            //query
            string query = "SELECT * FROM empresarios where id ='"+id+"'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                
                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        empresarios.nome = (string)dataReader["nome"];
                        empresarios.id = (int)dataReader["id"];
                        empresarios.codigo = (int)dataReader["codigo"];
                        empresarios.imagem = (string)dataReader["imagem"];
                        empresarios.setor = (string)dataReader["setor"];
                        empresarios.cargo = (string)dataReader["cargo"];
                        empresarios.dataEntrada = (DateTime)dataReader["dataentrada"];
                        empresarios.dataSaida = (DateTime)dataReader["dataSaida"];
                        empresarios.dedicatoria = (string)dataReader["dedicatoria"];
                        empresarios.atividade = (string)dataReader["atividade"];
                        empresarios.rg = (int)dataReader["rg"];
                        empresarios.endereco = (string)dataReader["endereco"];
                        empresarios.endNum = (int)dataReader["endNum"];
                        empresarios.endBairro = (string)dataReader["endBairro"];
                        empresarios.login = (bool)dataReader["login"];
                        empresarios.ativo = (bool)dataReader["ativo"];
                        empresarios.faltas = (int)dataReader["faltas"];
                        empresarios.telefone = (string)dataReader["telefone"];
                        empresarios.cpf = (string)dataReader["cpf"];
                    }
                
                
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return empresarios;
                }
            }
            else
            {
                return empresarios;
            }      
        }

        //retorna por nome
        public Empresarios SelectNome(string nome)
        {
            Empresarios empresarios = new Empresarios();

            //query
            string query = "SELECT * FROM empresarios where nome ='" + nome + "'";
            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                using (MySqlCommand cmd = new MySqlCommand(query, connection))

                //Create a data reader and Execute the command
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                {
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        empresarios.nome = (string)dataReader["nome"];
                        empresarios.id = (int)dataReader["id"];
                        empresarios.codigo = (int)dataReader["codigo"];
                        empresarios.imagem = (string)dataReader["imagem"];
                        empresarios.setor = (string)dataReader["setor"];
                        empresarios.cargo = (string)dataReader["cargo"];
                        empresarios.dataEntrada = (DateTime)dataReader["dataentrada"];
                        empresarios.dataSaida = (DateTime)dataReader["dataSaida"];
                        empresarios.dedicatoria = (string)dataReader["dedicatoria"];
                        empresarios.atividade = (string)dataReader["atividade"];
                        empresarios.rg = (int)dataReader["rg"];
                        empresarios.endereco = (string)dataReader["endereco"];
                        empresarios.endNum = (int)dataReader["endNum"];
                        empresarios.endBairro = (string)dataReader["endBairro"];
                        empresarios.login = (bool)dataReader["login"];
                        empresarios.ativo = (bool)dataReader["ativo"];
                        empresarios.faltas = (int)dataReader["faltas"];
                        empresarios.telefone = (string)dataReader["telefone"];
                        empresarios.cpf = (string)dataReader["cpf"];
                    }


                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return empresarios;
                }
            }
            else
            {
                return empresarios;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public void Insert(string nome)
        {
            string[] split = nome.Split(new Char[] { ',' });
            int login =0;

            if (split[12]=="true")
            {
                login = 1;
            }

            string query = "INSERT INTO empresarios (nome, codigo, imagem, setor, cargo, dataEntrada, dedicatoria, atividade, rg, cpf, ativo, faltas, login, endereco, endNum, endBairro, telefone, curso, dataSaida) VALUES('" + split[0] + "','" + split[1] + "','" + split[2] + "','" + split[3] + "','"+split[4]+"','" + split[5] + "','" + split[6] + "','" + split[7] + "','" + split[8] + "','" + split[9] + "','" + split[10] + "','" + split[11] + "','" + login + "','" + split[13] + "','" + split[14] + "','" + split[15] + "','" + split[16] + "','" + split[17] + "','"+split[18]+"')";
            
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
