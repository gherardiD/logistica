﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace logistica
{
    public partial class logistica_form : Form
    {
        //DataGridView table;
        int prezzo_tot;
        //DataGridView table_copy;
        public logistica_form()
        {
            InitializeComponent();
            this.prezzo_tot = 0;
          //  table_copy= new DataGridView();
        }

        public int check()
        {
            // return 0 if I have to create a default table
            // -1 if the user click annull
            // 1 if I have to create a n X n table

            int numero_produttori = (int)produttori_num.Value;
            int numero_consumatori = (int)consumatori_num.Value;
            if(numero_produttori == 1 || numero_consumatori == 1)
            {
                if (MessageBox.Show("producers or consumers is set to 1. A default 4 X 4 table will be created do you want to continue?", "default Table", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    return 0;
                else
                    return -1;
            }
            return 1;
        }

        private void genera_btn_Click(object sender, EventArgs e)
        {
            int check_result = check();
            if (check_result == -1)
                    return;
            //generate the table
            this.table.Visible = true;
            if (check_result == 0)
            {
                //default table

                //columns
                for (int c = 0; c < 3; c++)
                {
                    this.table.Columns.Add("price_" + c, "Price");
                    this.table.Columns["price_" + c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                this.table.Columns.Add("tot_produced", "Tot produced");
                this.table.Columns["tot_produced"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //rows
                for (int r = 0; r < 3; r++)
                {
                    this.table.Rows.Add("pcd" + r, 30 + r*10, 10 + r * 10, 20 + r * 10, 50*(r+1));
                }
                this.table.Rows.Add("tot" , 100, 120, 80, 300);
            }
            else
            {
                //user table
                int numero_produttori = (int)produttori_num.Value;
                int numero_consumatori = (int)consumatori_num.Value;
 
                //creation table
                //this.table = new DataGridView();
                //this.table.Name= "table";
                //this.table.Dock = DockStyle.Fill;
                //panel_table.Controls.Add(this.table);
                //panel_table.Controls.Remove(this.table);
                //this.table.ColumnHeadersVisible = true;
                ///this.table.Columns.Add("productor", "Productors");


                // columns
                for (int c = 0; c < numero_consumatori; c++)
                {
                    this.table.Columns.Add("price_" + c, "Price");
                    if (numero_consumatori >= 6)
                    {
                        this.table.Columns["price_" + c].Width = 50;
                    }else if(numero_consumatori > 3 && numero_consumatori < 6)
                    {
                        this.table.Columns["price_" + c].Width = 80;
                    }
                }
                this.table.Columns.Add("tot_produced", "Tot produced");

                // rows
                for(int r = 0; r < numero_produttori; r++)
                {
                    this.table.Rows.Add("pcd" + r);
                }
                this.table.Rows.Add("tot");
            }
            this.genera_btn.Enabled = false;
            this.genera_numeri_btn.Enabled = true;
            this.start_btn.Enabled = true;
        }


        private void genera_numeri_btn_Click(object sender, EventArgs e)
        {
            // prices max = 100
            // tot max per line = 300

            int colonne = this.table.Columns.Count;
            int righe = this.table.Rows.Count;
            Random rnd = new Random();

            // price values max 100
            int casual_number_cell = rnd.Next(100);
            int casual_tot_requested = 0;
            int casual_tot_produced = 0;
            int max = 0;

            if(righe > 12)
            {
                max = 3;
            }
            else
            {
                max = 2;
            }

            // tot = total producted = total requested
            int tot = 0;
            
            for (int r = 0; r < righe - 1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    if(r == 0)
                    {
                        // put random numbers in total requested (last line) and calculate tot
                        casual_tot_requested = rnd.Next(colonne + righe, 300);
                        this.table.Rows[righe - 1].Cells[c].Value = casual_tot_requested;
                        tot += casual_tot_requested;
                    }
                    
                    // put random prices
                    this.table.Rows[r].Cells[c].Value = casual_number_cell;
                    casual_number_cell = rnd.Next(1, 100);
            
                    if(c == colonne - 2)
                    {
                        // setting total produced values based to tot
                        if(r == 0)
                        {
                            // set tot value in the last row and last coloumn
                            this.table.Rows[righe - 1].Cells[colonne - 1].Value = tot;
                        }
                        // minimun and maximum to avoid total produced values = 0
                        casual_tot_produced = rnd.Next(1, (tot - (righe - r))/max);

                        if(r == righe - 2)
                        {
                            // setting the last total produced to tot (by doing so -> tot = total porduced = total requested)
                            this.table.Rows[r].Cells[colonne - 1].Value = tot;
                        }
                        else
                        {
                            this.table.Rows[r].Cells[colonne - 1].Value = casual_tot_produced;
                        }
                        // updating tot
                        tot = tot - casual_tot_produced;
                    }
                }
            }

            this.table.Refresh();
        }

        private void CloneDataGrid(DataGridView sorgente, DataGridView destinatario)
        {

            destinatario.ColumnCount = sorgente.ColumnCount;
            destinatario.RowCount = sorgente.RowCount;
            for (int riga = 0; riga < sorgente.RowCount; riga++)
                for (int colonna = 0; colonna < sorgente.ColumnCount; colonna++)
                    destinatario.Rows[riga].Cells[colonna].Value = sorgente.Rows[riga].Cells[colonna].Value;
            for (int colonna = 0; colonna < sorgente.ColumnCount; colonna++)
            {
                destinatario.Columns[colonna].HeaderText=sorgente.Columns[colonna].HeaderText;
                destinatario.Columns[colonna].Name = sorgente.Columns[colonna].Name;
                destinatario.Columns[colonna].Width = sorgente.Columns[colonna].Width;
                destinatario.Columns[colonna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            destinatario.Refresh();
            return;
        }


        private void start_btn_Click(object sender, EventArgs e)
        {
            // disable btns
            this.genera_numeri_btn.Enabled = false;
            this.start_btn.Enabled = false;

            int colonne = this.table.Columns.Count;
            int righe = this.table.Rows.Count;
            this.panel_text.Visible= true;
            this.panel_text.Refresh();
            this.text.Refresh();

            // copy the main dataGrid
            CloneDataGrid(this.table,this.table_copy);
            int costo_nord = nord_ovest(righe , colonne);
            // reset main dataGrid
            CloneDataGrid(this.table_copy,this.table);

            // reset prezzo_tot
            this.prezzo_tot = 0;

            Thread.Sleep(1000);
            int costo_min = minimi_costi(righe , colonne);

            // diff between nord-ovest and minimi-costi systems
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("Hai risparmiato: " + (costo_nord - costo_min) + "$");

            // enable rigenera btn
            this.rigenera_btn.Enabled= true;
            
        }

        private int nord_ovest(int righe, int colonne)
        {
            for (int r = 0; r < righe - 1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    int valore_cella = int.Parse(this.table.Rows[r].Cells[c].Value.ToString());
                    // colour cell text
                    this.table.Rows[r].Cells[c].Style = new DataGridViewCellStyle { ForeColor = Color.YellowGreen };

                    int total_produced = int.Parse(this.table.Rows[r].Cells[colonne - 1].Value.ToString());
                    int total_requested = int.Parse(this.table.Rows[righe - 1].Cells[c].Value.ToString());

                    // numero produttore e consumatore
                    String num_pcd = this.table.Rows[r].Cells[0].Value.ToString().Substring(3);
                    String num_con = this.table.Columns[c].Name.Trim().Substring(6);

                    // write on textbox what is happening
                    this.text.AppendText(Environment.NewLine);
                    this.text.AppendText(" Da produttore  nr: " + num_pcd + " a Consumatore nr: " + num_con + ". Prezzo = " + total_requested * valore_cella + "$");

                    if (delete(r, c, valore_cella, total_produced, total_requested, righe) == 'c')
                    {
                        colonne -= 1;
                        c--;
                    }
                    else
                    {
                        righe -= 1;
                        r--;
                        break;
                    }
                    this.text.Refresh();
                    Thread.Sleep(1000);
                    this.table.Refresh();
                }
                Thread.Sleep(1000);
                this.table.Refresh();
            }
            this.table.Rows.RemoveAt(0);

            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("PREZZO TOTALE: " + this.prezzo_tot + "€");
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.Refresh();

            return prezzo_tot;
        }

        private char delete(int riga, int colonna, int valore_cella, int total_produced, int total_requested, int righe)
        {
            // calculates if we have to delete the producer or the consumer
            if (total_produced - total_requested > 0)
            {
                // colour row and coloumn selected
                this.table.Columns[colonna].DefaultCellStyle.BackColor = Color.Coral;
                this.table.Refresh();

                // delete requester
                this.prezzo_tot += total_requested * valore_cella;
                total_produced -= total_requested;
                this.table.Rows[riga].Cells["tot_produced"].Value = total_produced;
                total_requested = 0;
                this.table.Columns.RemoveAt(colonna);
                return 'c';
            }
            else
            {
                // colour row and coloumn selected
                this.table.Rows[riga].DefaultCellStyle.BackColor = Color.Coral;
                this.table.Refresh();

                // delete producer
                this.prezzo_tot += total_produced * valore_cella;
                total_requested -= total_produced;
                this.table.Rows[righe - 1].Cells[colonna].Value = total_requested;
                total_produced = 0;
                this.table.Rows.RemoveAt(riga);
                return 'r';
            }
        }

        private int minimi_costi(int righe, int colonne)
        {
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("MINIMI-COSTI SYSTEM");
            int[] pos = new int[5];
            while (righe > 1 && colonne >= 3)
            {
                pos = find_min_data(righe, colonne);
                // colour cell text
                this.table.Rows[pos[0]].Cells[pos[1]].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                
                // posizione prosuttore e consumatore
                String num_pcd = this.table.Rows[pos[0]].Cells[0].Value.ToString().Substring(3);
                String num_con = this.table.Columns[pos[1]].Name.Trim().Substring(6);

                // write on textbox what is happening
                this.text.AppendText(Environment.NewLine);
                this.text.AppendText(" Da produttore  nr: " + num_pcd + " a Consumatore nr: " + num_con + ". Prezzo = " + pos[2] * pos[4] + "€");

                // riga[0] - colonna[1] - valore[2] - tot-prod[3] - tot-req[4]
                if (delete(pos[0], pos[1], pos[2], pos[3], pos[4], righe) == 'c')
                {
                    colonne -= 1;
                }
                else
                {
                    righe -= 1;
                }
                Thread.Sleep(1000);
                this.table.Refresh();
            }
            this.table.Rows.RemoveAt(0);

            this.text.AppendText(Environment.NewLine);
            this.text.AppendText(Environment.NewLine);
            this.text.AppendText("PREZZO TOTALE: " + this.prezzo_tot + "€");
            this.text.Refresh();

            return prezzo_tot;
        }

        private int[] find_min_data(int righe, int colonne )
        {
            // return minimun value data - riga[0] - colonna[1] - valore[2] - tot-prod[3] - tot-req[4]
            int Max = 1000000;
            int[] min_data = new int[5];
            int valore_cella = 0;
            int total_produced = 0;
            int total_requested = 0;
            for (int r = 0; r < righe-1; r++)
            {
                for (int c = 1; c < colonne - 1; c++)
                {
                    valore_cella = int.Parse(this.table.Rows[r].Cells[c].Value.ToString());
                    total_produced = int.Parse(this.table.Rows[r].Cells[colonne - 1].Value.ToString());
                    total_requested = int.Parse(this.table.Rows[righe - 1].Cells[c].Value.ToString());
                    if ( valore_cella < Max)
                    {
                        Max = valore_cella;
                        min_data[0] = r;
                        min_data[1] = c;
                        min_data[2] = valore_cella;
                        min_data[3] = total_produced;
                        min_data[4] = total_requested;
                    }
                }
            }
            return min_data;
        }

        private void rigenera_btn_Click(object sender, EventArgs e)
        {
            // enable genera btn
            this.genera_btn.Enabled = true;

            // disable this btn
            this.rigenera_btn.Enabled = false;

            // reset prezzo_tot
            prezzo_tot = 0;

            // reset table

            DataGridView resetted_table = new DataGridView();
            // resetted_table.Name= "table";
            resetted_table.AllowUserToAddRows= false;
            resetted_table.AllowUserToDeleteRows= false;
            resetted_table.CausesValidation= false;
            resetted_table.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resetted_table.Dock = DockStyle.Fill;
            resetted_table.ColumnHeadersVisible = true;
            resetted_table.Columns.Add("productor", "Productors");
            resetted_table.ReadOnly= true;
            resetted_table.RowHeadersVisible= false;

            CloneDataGrid(resetted_table, this.table);
            this.table.Name = "table";

            this.table.Refresh();

            // reset textBox
            this.text.Text = "NORD-OVEST SYSTEM:";
            this.panel_text.Refresh();
            this.text.Refresh();
        }
    }
}
