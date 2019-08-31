namespace n11HtmlTag
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.productName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.productSubHeader = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.productDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.productCategory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.productSalesPrice = new System.Windows.Forms.TextBox();
			this.productPictureBox = new System.Windows.Forms.PictureBox();
			this.productListView = new System.Windows.Forms.ListView();
			this.label6 = new System.Windows.Forms.Label();
			this.productLink = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// productName
			// 
			this.productName.Location = new System.Drawing.Point(88, 85);
			this.productName.Name = "productName";
			this.productName.Size = new System.Drawing.Size(277, 20);
			this.productName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ürün Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Alt Başlık";
			// 
			// productSubHeader
			// 
			this.productSubHeader.Location = new System.Drawing.Point(88, 138);
			this.productSubHeader.Name = "productSubHeader";
			this.productSubHeader.Size = new System.Drawing.Size(277, 20);
			this.productSubHeader.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Açıklama";
			// 
			// productDescription
			// 
			this.productDescription.Location = new System.Drawing.Point(88, 190);
			this.productDescription.Multiline = true;
			this.productDescription.Name = "productDescription";
			this.productDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.productDescription.Size = new System.Drawing.Size(277, 209);
			this.productDescription.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Kategoriler";
			// 
			// productCategory
			// 
			this.productCategory.Location = new System.Drawing.Point(88, 111);
			this.productCategory.Name = "productCategory";
			this.productCategory.Size = new System.Drawing.Size(277, 20);
			this.productCategory.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Satış Fiyatı";
			// 
			// productSalesPrice
			// 
			this.productSalesPrice.Location = new System.Drawing.Point(88, 164);
			this.productSalesPrice.Name = "productSalesPrice";
			this.productSalesPrice.Size = new System.Drawing.Size(277, 20);
			this.productSalesPrice.TabIndex = 8;
			// 
			// productPictureBox
			// 
			this.productPictureBox.Location = new System.Drawing.Point(385, 190);
			this.productPictureBox.Name = "productPictureBox";
			this.productPictureBox.Size = new System.Drawing.Size(391, 209);
			this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.productPictureBox.TabIndex = 10;
			this.productPictureBox.TabStop = false;
			// 
			// productListView
			// 
			this.productListView.Location = new System.Drawing.Point(385, 83);
			this.productListView.MultiSelect = false;
			this.productListView.Name = "productListView";
			this.productListView.Size = new System.Drawing.Size(391, 97);
			this.productListView.TabIndex = 11;
			this.productListView.UseCompatibleStateImageBehavior = false;
			this.productListView.View = System.Windows.Forms.View.List;
			this.productListView.SelectedIndexChanged += new System.EventHandler(this.productListView_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ürün Adresi";
			// 
			// productLink
			// 
			this.productLink.Location = new System.Drawing.Point(88, 12);
			this.productLink.Name = "productLink";
			this.productLink.Size = new System.Drawing.Size(522, 20);
			this.productLink.TabIndex = 12;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(616, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 20);
			this.button1.TabIndex = 14;
			this.button1.Text = "Getir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.productLink);
			this.Controls.Add(this.productListView);
			this.Controls.Add(this.productPictureBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.productSalesPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.productCategory);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.productDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productSubHeader);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.productName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox productName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox productSubHeader;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox productDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox productCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox productSalesPrice;
		private System.Windows.Forms.PictureBox productPictureBox;
		private System.Windows.Forms.ListView productListView;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox productLink;
		private System.Windows.Forms.Button button1;
	}
}

