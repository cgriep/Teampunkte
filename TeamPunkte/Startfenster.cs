using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeamPunkte
{
    public partial class Startfenster : Form
    {
        public Startfenster()
        {
            InitializeComponent();
        }

        private void tblListe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnOne.Enabled = true;
            btnFive.Enabled = true;
            btnTen.Enabled = true;
            btnMOne.Enabled = true;
            btnMFive.Enabled = true;
            btnColor.Enabled = true;
            btnSort.Enabled = true;
            setZero(e.RowIndex);
        }

        private void tblListe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (tblListe.Rows.Count == 1)
            {
                btnOne.Enabled = false;
                btnFive.Enabled = false;
                btnTen.Enabled = false;
                btnMOne.Enabled = false;
                btnMFive.Enabled = false;
                btnColor.Enabled = false;
                btnSort.Enabled = false;
            }
        }
        private void punkte(int anzahl)
        {
            if (tblListe.SelectedCells.Count == 1)
            {
                DataGridViewCell x = tblListe.SelectedCells[0];
                int i = Convert.ToInt16(tblListe.Rows[x.RowIndex].Cells[2].Value);
                tblListe.Rows[x.RowIndex].Cells[2].Value = Convert.ToString(i + anzahl);
            }
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            punkte(1);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (tblListe.SelectedCells.Count == 1)
            {
                DataGridViewCell x = tblListe.SelectedCells[0];
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    tblListe.Rows[x.RowIndex].DefaultCellStyle.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            punkte(5);
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            punkte(10);
        }

        private void btnMFive_Click(object sender, EventArgs e)
        {
            punkte(-5);
        }

        private void btnMOne_Click(object sender, EventArgs e)
        {
            punkte(-1);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Equals("&Bearbeitung beenden"))
            {
                btnToggle_Click(null, null);
            }
            tblListe.Sort(tblListe.Columns[2], ListSortDirection.Descending);
            int wert = Convert.ToInt16(tblListe.Rows[0].Cells[2].Value);
            int platz = 1;
            for (int i = 0; i < tblListe.Rows.Count; i++)
            {
                if (wert != Convert.ToInt16(tblListe.Rows[i].Cells[2].Value))
                {
                    platz++;

                }
                tblListe.Rows[i].Cells[0].Value = platz.ToString();
                wert = Convert.ToInt16(tblListe.Rows[i].Cells[2].Value);
            }
        }

        private void tblListe_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            try
            {
                int i1 = Convert.ToInt16(e.CellValue1);
                int i2 = Convert.ToInt16(e.CellValue2);
                if (i1 < i2)
                {
                    e.SortResult = -1;
                }
                else
                {
                    if (i1 > i2)
                    {
                        e.SortResult = 1;
                    }
                    else
                    {
                        e.SortResult = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                e.SortResult = String.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
            }
            e.Handled = true;
        }

        private void btnNeustart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tblListe.Rows.Count; i++)
            {
                tblListe.Rows[i].Cells[2].Value = "0";
                tblListe.Rows[i].Cells[0].Value = "";
            }
        }
        private void setZero(int row)
        {
            tblListe.Rows[row].Cells[2].Value = "0";
            switch (row+1)
            {
                case 1:
                    tblListe.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
                    break;
                case 2:
                    tblListe.Rows[row].DefaultCellStyle.ForeColor = Color.Blue;
                    break;
                case 3:
                    tblListe.Rows[row].DefaultCellStyle.ForeColor = Color.Green;
                    break;
                case 4:
                    tblListe.Rows[row].DefaultCellStyle.ForeColor = Color.Yellow;
                    break;
                case 5:
                    tblListe.Rows[row].DefaultCellStyle.ForeColor = Color.DarkViolet;
                    break;
            }

        }
        private void tblListe_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (tblListe.Rows[e.RowIndex].Cells[2].Value == null)
            {
                setZero(e.RowIndex);
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Equals("&Bearbeitung zulassen"))
            {
                btnToggle.Text = "&Bearbeitung beenden";
                tblListe.AllowUserToAddRows = true;
                tblListe.AllowUserToDeleteRows = true;
                tblListe.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;                
            }
            else
            {
                btnToggle.Text = "&Bearbeitung zulassen";
                tblListe.AllowUserToAddRows = false;
                tblListe.AllowUserToDeleteRows = false;
                tblListe.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }


    }
}