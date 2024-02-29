﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
	public partial class FrmOgrenciDetay : Form
	{
		public FrmOgrenciDetay()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		public string numara;

		//Data Source=emin\SQLEXPRESS;Initial Catalog=DbNotKsyıt;Integrated Security=True;Encrypt=False
		SqlConnection baglanti = new SqlConnection(@"Data Source=emin\SQLEXPRESS;Initial Catalog=DbNotKsyıt;Integrated Security=True;Encrypt=False");
		private void FrmOgrenciDetay_Load(object sender, EventArgs e)
		{
			LblNumara.Text = numara;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("SELECT * From TBLDERS where OGRNUMARA=@p1", baglanti);
			komut.Parameters.AddWithValue("@p1", numara);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				LblAdSoyad.Text = dr[2].ToString() + " " + dr[3].ToString();
				LblSinav1.Text = dr[4].ToString();
				LblSinav2.Text = dr[5].ToString();
				LblSinav3.Text = dr[6].ToString();
				LblOrtalama.Text = dr[7].ToString();
				LblDurum.Text = dr[8].ToString();
			}
			baglanti.Close();
		}
	}
}
