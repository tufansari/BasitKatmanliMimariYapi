using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using LoqicLayer;
using EntityLayer;

namespace NKatmanli_Yapı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<Entity> perlist = LogicGorevli.LLPersonellistesi(); 
            dataGridView1.DataSource = perlist;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity(); // Entity'den nesne üretiyoruz.
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text); // smallint'ten dolayı short kullandık.
            LogicGorevli.LLPersonelekle(ent);         
            if (ent.Maas < 4250)
            {
                txtmaas.Text = "";
                MessageBox.Show("Maaş 4250den düşük olamaz");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Id = Convert.ToInt32(txtid.Text);
            LogicGorevli.DLPersonelSil(ent.Id);
        }

        private void btngncl_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.Id = Convert.ToInt32(txtid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            LogicGorevli.LLPersonelguncelle(ent);
        }
    }
}
