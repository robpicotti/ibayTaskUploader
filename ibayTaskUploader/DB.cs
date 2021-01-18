using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace ibayTaskUploader
{
    public class DB
    {
		public static string _SERVER = "curl.visualizeit.co.za,44405";

		public static string _DB = "Ibay";

		public static string _STATUS = "PROD";

		public static string _USER = "ibay";

		public static string _PWD = "1b@y2021";

		public static string _VER = "1.0";

		public SqlConnection getSQLConn()
		{
			string conn = "Data Source=" + _SERVER + ";Initial Catalog=" + _DB + ";User id=" + _USER + ";Password=" + _PWD + ";";
			return new SqlConnection(conn);
		}
		public DataTable getSprocResults(string sprocName)
		{

			SqlConnection conn = null;
			SqlDataAdapter retDA = new SqlDataAdapter();
			DataSet ds = new DataSet();
			DataTable dt = new DataTable();
			try
			{
				conn = getSQLConn();
				SqlCommand cmd = new SqlCommand(sprocName, conn);
				try
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandTimeout = 0;
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					try
					{
						da.Fill(dt);
					}
					finally
					{
						da.Dispose();
					}
				}
				finally
				{
					cmd.Dispose();
				}
				conn.Close();
				return dt;
			}
			catch (Exception)
			{
				return dt;
			}
		}

		public bool execSproc(string sprocName, string[,] arrParams)
		{
			bool bln = false;
			SqlConnection conn = null;
			int rows = arrParams.GetUpperBound(0);
			conn = getSQLConn();
			conn.Open();
			SqlCommand cmd = new SqlCommand(sprocName, conn);
			try
			{
				cmd.CommandType = CommandType.StoredProcedure;
				for (int i = 0; i <= rows; i++)
				{
					string par = arrParams[i, 0].ToString();
					string val = arrParams[i, 1].ToString();
					if (val != "")
					{
						cmd.Parameters.AddWithValue(par, val);
					}
					else
					{
						cmd.Parameters.AddWithValue(par, DBNull.Value);
					}
				}
				cmd.ExecuteNonQuery();
				conn.Close();
				bln = true;
			}
			finally
			{
				cmd.Dispose();
			}
			return bln;
		}
		public bool execSproc(string sprocname, SqlConnection conn)
		{
			bool bln = false;
			try
			{
				conn.Open();
				using (var cmd = new SqlCommand(sprocname, conn))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.ExecuteNonQuery();
				}
				conn.Close();
				bln = true;
			}
			catch (Exception ex)
			{
				bln = false;
				string s = ex.Message;
			}
			return bln;
		}
		public DataTable loadCSVToDatatable(string _file)
		{
			DataTable dt = new DataTable();
			string errorRow = "";
			string errorCol = "";
			try
			{

				string de = "";
				using (StreamReader sr = new StreamReader(_file))
				{
					string[] headers = sr.ReadLine().Split(new char[1]
					{
				','
					});
					if (headers[0].ToString() == "")
					{
						headers = sr.ReadLine().Split(new char[1]
						{
					','
						});
					}
					string[] array = headers;
					foreach (string header in array)
					{
						dt.Columns.Add(header);
					}
					while (!sr.EndOfStream)
					{
						string srows = sr.ReadLine();
						if (srows.Replace(",", "") == "")
						{
							return dt;
						}
						string[] rows = Regex.Split(srows, ",");
						DataRow dr = dt.NewRow();
						for (int i = 0; i < headers.Length; i++)
						{
							errorRow = rows[i].ToString();
							de = rows[i].ToString();
							errorCol = rows[i].ToString();
							dr[i] = rows[i].ToString();
						}
						dt.Rows.Add(dr);
					}
				}
				return dt;
			}
			catch(Exception ex)
            {
				Console.WriteLine(errorRow);
				Console.WriteLine(errorCol);
				return dt;
			}
			
		}


		public DataTable getSprocResults(string sprocName, string[,] arrParams)
		{

			SqlConnection conn = null;
			SqlDataAdapter retDA = new SqlDataAdapter();
			DataSet ds = new DataSet();
			DataTable dt = new DataTable();
			int rows = arrParams.GetUpperBound(0);
			try
			{
				conn = getSQLConn();
				SqlCommand cmd = new SqlCommand(sprocName, conn);
				try
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.CommandTimeout = 0;
					for (int i = 0; i <= rows; i++)
					{
						string par = arrParams[i, 0].ToString();
						string val = arrParams[i, 1].ToString();
						cmd.Parameters.AddWithValue(par, (object)val);
					}
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					try
					{
						da.Fill(dt);
					}
					finally
					{
						da.Dispose();
					}
				}
				finally
				{
					cmd.Dispose();
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return dt;
		}
	}
}
