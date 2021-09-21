using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AntiIniUI.DataLayer;
using System.Collections.ObjectModel;
namespace Databáze_II_Projekt
{
    
    public partial class SpravceHracu : Form
    {
        Collection<Server> h = new Collection<Server>();
        public SpravceHracu()
        {
            InitializeComponent();

            Table();
        }

        private void Table()
        {
            this.dataGridViewBugy.AllowUserToAddRows = true;
            h = DataConnection.GetServers();

            this.dataGridViewBugy.Rows.Clear();
            #region Inicializace tabulky


            for (int i = 0; i < this.dataGridViewBugy.Rows.Count; i++)
            {
                if (i < h.Count)
                {
                    this.dataGridViewBugy.Rows.Add();
                }
                else
                {
                    this.dataGridViewBugy.AllowUserToAddRows = false;
                    break;
                }

                this.dataGridViewBugy.Rows[i].Cells[0].Value = h[i].ServerName;
                this.dataGridViewBugy.Rows[i].Cells[1].Value = h[i].ConnectionArgument;

            }
            this.dataGridViewBugy.Refresh();

            #endregion
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewBugy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 3)
            //{
            //    int id = -1;
            //    string prezdivka = this.dataGridViewBugy.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    var h_id = prezdivka.Split('#');
            //    id = int.Parse(h_id[1]);

            //    Server.Update(new Hraci()
            //    {
            //        Hrac_id = id,
            //        Prezdivka = this.textBox2.Text,
            //        Steam_id = int.Parse(this.textBox3.Text),
            //        Discord_id = int.Parse(this.textBox4.Text)
            //    });
            //}
            //else if (e.ColumnIndex == 4)
            //{
            //    int id = -1;
            //    string prezdivka = this.dataGridViewBugy.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    var h_id = prezdivka.Split('#');
            //    id = int.Parse(h_id[1]);

            //    HraciTable.Delete(id);
            //}

            //Table();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBAN_Click(object sender, EventArgs e)
        {
            //HraciTable.Insert(new Hraci()
            //{
            //    Prezdivka = this.textBoxName.Text,
            //    Steam_id = int.Parse(this.textBoxStart.Text),
            //    Discord_id = int.Parse(this.textBoxKonec.Text)
            //});

            //Table();
        }
    }
}
