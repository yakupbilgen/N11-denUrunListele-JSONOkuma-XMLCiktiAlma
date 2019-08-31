using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;
using Dapper;

namespace XmlConvert
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteXML();
		}
		public static void WriteXML()
		{
			List<Brand> Brands = new List<Brand>();
			var Brands2 = new List<Brand>();
			using (var con = new SqlConnection(Query.sqlCon))
			{
				Brands2 = con.Query<Brand>(Query.selectBrandQuery, commandType: System.Data.CommandType.Text).ToList();
			}
			var xEle = new XElement("Brands",
							from item in Brands2
							select new XElement("Brand",
										 new XElement("TBLid", item.TBLid),
										   new XElement("TBLname", item.TBLname))
									   );
			
			System.Console.Write(xEle);
			System.Console.Read();
			
		}
	}
}
