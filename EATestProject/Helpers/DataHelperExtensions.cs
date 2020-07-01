﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace EAAutoFramework.Helpers
{
    public static class DataHelperExtensions
    {
        //Open the connection

        public static SqlConnection DBConnect(this SqlConnection sqlConnection, string conncetionString)
        {
            try
            {
                sqlConnection = new SqlConnection(conncetionString);
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception e)
            {
                LogHelpers.Write(" ERROR :: " + e.Message);
            }
            return null;
        }

        //Closing the connection
        public static void DBClose(this SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                LogHelpers.Write(" ERROR :: " + e.Message);
            }
        }

        //Executing
        public static DataTable ExecuteQuery(this SqlConnection sqlConnection, string queryString)
        {
            DataSet dataset;
            try
            {
                //Checking for the state of the connection
                if (sqlConnection == null || ((sqlConnection != null && (sqlConnection.State == ConnectionState.Closed ||
                    sqlConnection.State == ConnectionState.Broken))))
                    sqlConnection.Open();

                SqlDataAdapter dataAdaptor = new SqlDataAdapter();
                dataAdaptor.SelectCommand = new SqlCommand(queryString, sqlConnection);
                dataAdaptor.SelectCommand.CommandType = CommandType.Text;
                dataset = new DataSet();
                dataAdaptor.Fill(dataset, "tabel");
                sqlConnection.Close();
                return dataset.Tables["table"];
            }
            catch (Exception e)
            {
                dataset = null;
                sqlConnection.Close();
                LogHelpers.Write(" ERROR :: " + e.Message);
                return null;
            }
            finally
            {
                sqlConnection.Close();
                dataset = null;
            }

        }
    }
}
