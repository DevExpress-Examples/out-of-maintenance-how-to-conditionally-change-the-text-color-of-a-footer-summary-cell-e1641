using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0 ; i < 10; i++) {
                dataTable1.Rows.Add("name " + i.ToString(), r.NextDouble() * 100);
            }
        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Amount") {
                object v = e.Info.Value;
                if (!(v is decimal)) {
                    return;
                }

                decimal d = Convert.ToDecimal(v);
                if (d <= 0)
                    e.Appearance.ForeColor = Color.Red;
                else if (d <= 500)
                    e.Appearance.ForeColor = Color.GreenYellow;
                else
                    e.Appearance.ForeColor = Color.Green;
            }
            
        }
    }
}