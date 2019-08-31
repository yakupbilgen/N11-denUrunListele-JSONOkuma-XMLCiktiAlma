using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlConvert
{
	public class Query
	{
		public const string sqlCon = @"Data Source=DESKTOP-7IV832G\MSSQLSERVER01;Initial Catalog=DBJsonWeb;Integrated Security=True";
		public const string selectBrandQuery = "SELECT [TBLid], [TBLname] FROM [TBLJsonWeb]";
	}
}
