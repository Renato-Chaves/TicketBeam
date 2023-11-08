using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TicketBeam
{
    internal class MyDBConnection
    {
        private static MyDBConnection instance;
        private String connectionString;
        private MySqlConnection conn;
        private int userCd;

        private MyDBConnection() {
            connectionString = "Server=127.0.0.1; Port=3307; Database=ticketbeamdb; Uid=root; Pwd=usbw;";
            conn = new MySqlConnection(connectionString);
        }

        public static MyDBConnection GetInstance()
        {
            if (instance == null) instance = new MyDBConnection();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }

        public void setUser(int _userCd)
        {
            this.userCd = _userCd;
        }
        public int GetUser()
        {
            return userCd;
        }

        public void Querry(MySqlCommand cmd)
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public DataRow QuerryToRow(MySqlCommand _cmd)
        {
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            _cmd.Connection = conn;

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(_cmd);
                adapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return (dataSet.Tables[0].Rows[0]);
        }

        public DataSet QuerryToDataSet(MySqlCommand _cmd)
        {
            MySqlDataAdapter adapter;
            DataSet dataSet = new DataSet();
            _cmd.Connection = conn;

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(_cmd);
                adapter.Fill(dataSet);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally {
                conn.Close();
            }
            return (dataSet);
        }

    }

}
