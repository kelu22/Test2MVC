﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DL_Class
    {
        public static DataSet GetContactUsingDBWithConfig()
        {
            DataTable dt = new DataTable();
            DataSet dsContacts = new DataSet();

            //Config Details and SQL Connection
            string cs = ConfigurationManager.ConnectionStrings["ContactsConnection_DEV"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            string sql = null;
            sql = "Select * from Contacts";

            //Open SQL Connection
            con.Open();

            SqlCommand command;
            command = new SqlCommand(sql, con);

            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            dt.Load(dataReader);
            dsContacts.Tables.Add(dt);

            dataReader.Close();
            command.Dispose();
            con.Close();

            return dsContacts;
        }

        public static DataSet GetImagesUsingDBWithConfig()
        {
            DataTable dt = new DataTable();
            DataSet dsImages = new DataSet();

            //Config Details and SQL Connection
            var cs = ConfigurationManager.ConnectionStrings["ContactsConnection_DEV"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            string sql = null;
            sql = "Select * from Images";

            //Open SQL Connection
            con.Open();

            SqlCommand command;
            command = new SqlCommand(sql, con);

            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();

            dt.Load(dataReader);
            dsImages.Tables.Add(dt);

            dataReader.Close();
            command.Dispose();
            con.Close();

            return dsImages;
        }
    }
}

