using HtmlAgilityPack;
using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.XPath;

namespace n11HtmlTag
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			productLink.Text = "https://urun.n11.com/outdoor-kameralar/eken-h9r-4k-ultra-hd-wifi-aksiyon-kamerasi-yedek-batarya-P359363105";
			
		}

		public string ClearHtml(string html)
		{
			string noHTML = Regex.Replace(html, @"<[^>]+>|&nbsp;", "").Trim();
			string noHTMLNormalised = Regex.Replace(noHTML, @"\s{2,}", " ");
			return noHTMLNormalised;
		}

		private void productListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListViewItem selectedListViewCell;
			if (productListView.SelectedItems.Count > 0)
			{
				selectedListViewCell = productListView.SelectedItems[0];
				productPictureBox.ImageLocation = selectedListViewCell.Text;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(productLink.Text))
				ProductGet();
		}

		private void  ProductGet()
		{
			Uri url = new Uri(productLink.Text);

			WebClient client = new WebClient();
			client.Encoding = System.Text.Encoding.UTF8;
			string html = client.DownloadString(url);
			HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
			dokuman.LoadHtml(html);
			productName.Text = dokuman.DocumentNode.SelectSingleNode("//h1[@class='proName']").InnerText.Trim();
			productSubHeader.Text = dokuman.DocumentNode.SelectSingleNode("//h2[@class='proSubName']").InnerText.Trim();
			HtmlNodeCollection descriptions = dokuman.DocumentNode.SelectNodes("//section[@class='tabPanelItem details']");
			HtmlNodeCollection productCategories = dokuman.DocumentNode.SelectNodes("//div[@id='breadCrumb']/ul/li");
			productSalesPrice.Text = dokuman.DocumentNode.SelectSingleNode("//div[@class='newPrice']/ins").InnerText.Trim();

			HtmlNodeCollection htmlNodes = dokuman.DocumentNode.SelectNodes("//div[@class='thumbsHolder slider']/ul/li");

			foreach (var node in htmlNodes)
			{
				productListView.Items.Add(node.Attributes["data-full"].Value);
			}


			int i = 0;
			foreach (var item in productCategories)
			{
				i += 1;
				if (i == 1)
				{
					productCategory.Text = item.InnerText;
				}
				else
				{
					productCategory.Text += "/" + item.InnerText;
				}

			}
			productCategory.Text = ClearHtml(productCategory.Text);

			foreach (var item in descriptions)
			{
				productDescription.Text += item.InnerText;
			}

			productDescription.Text = ClearHtml(productDescription.Text);
		}
	}
}
