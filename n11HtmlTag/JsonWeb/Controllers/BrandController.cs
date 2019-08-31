using JsonWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dapper;
using System.Data.SqlClient;
using JsonWeb.Const;

namespace JsonWeb.Controllers
{
	public class BrandController : Controller
	{

		public List<Brand> JsonGetMethod()
		{
			List<Brand> brands2 = new List<Brand>();
			Uri url = new Uri("http://tamentegre.com/kariyer/markalar.json");
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			string jsonVerisi = "";
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				StreamReader reader = new StreamReader(response.GetResponseStream());
				jsonVerisi = reader.ReadToEnd();
			}
			Item brands = JsonConvert.DeserializeObject<Item>(jsonVerisi);
			foreach (var item in brands.brands)
			{
				brands2.Add(item);
			}

			return brands2;
		}
		[HttpGet]
		public ActionResult Index()
		{
			//JsonGetMethod();
			return View(JsonGetMethod());
		}

		[HttpPost]
		public ActionResult Index(List<Brand> brand)
		{
			foreach (var item in JsonGetMethod())
			{
				DynamicParameters parameters = new DynamicParameters();

				using (var sqlConnection = new SqlConnection(Query.sqlCon))
				{

					parameters.Add("id", item.id);
					parameters.Add("name", item.name);

					sqlConnection.Execute("InsertQuery", parameters, commandType: System.Data.CommandType.StoredProcedure);
				}
			}

			return RedirectToAction("Index");
		}
		

	}
}