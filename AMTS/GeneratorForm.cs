﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTS
{
    public partial class GeneratorForm : Form
    {
        private SqlConnection conn;
        private List<string> druzyny;
        private Terminarz terminarz;

        public GeneratorForm()
        {
            InitializeComponent();
        }

        public GeneratorForm(Terminarz terminarz, List<string> druzyny, SqlConnection conn)
        {
            InitializeComponent();
            this.terminarz = terminarz;
            this.druzyny = druzyny;
            this.conn = conn;
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void GeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            terminarz.changeOpenedWindow();
            terminarz.actualize();
        }

        private void generator_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            save.Visible = true;
            discard.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            for (int i=1; i<=druzyny.Count; i++)
            {
                dataGridView1.Rows.Add(i, "RRRR-MM-DD");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            bool noErrors = true;
            DateTime some;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!DateTime.TryParse(row.Cells[1].Value.ToString(), out some))
                {
                    noErrors = false;
                    label2.Visible = true;
                }
            }
            if (noErrors)
            {
                if (checkBox1.Checked)
                {
                    SqlCommand com = new SqlCommand("delete from TERMINARZ update Klasyfikacja set Duze_punkty = 0, Male_punkty = 0, Male_przegrane_punkty = 0", conn);
                    com.ExecuteNonQuery();
                }
                string[] druz= druzyny.ToArray();
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.CommandText = "exec dbo.dodajSpotkanie @data,@druz,@przeci,0,0,0,0,@r ";

                sqlcom.Connection = conn;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    sqlcom.Parameters.Clear();
                    sqlcom.Parameters.Add("@r", SqlDbType.Int).Value = row.Cells[0].Value;
                    sqlcom.Parameters.Add("@data", SqlDbType.Date).Value = row.Cells[1].Value.ToString(); ;
                    sqlcom.Parameters.Add("@druz", SqlDbType.VarChar).Value = "Seniorzy";
                    sqlcom.Parameters.Add("@przeci", SqlDbType.VarChar).Value = "Juniorzy";
                    sqlcom.ExecuteNonQuery();
                }
            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            dataGridView1.Rows.Clear();
        }
    }
}