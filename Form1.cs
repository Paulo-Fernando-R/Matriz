using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz
{
    public partial class Form1 : Form
    {

        private int row;
        private int coll;
        private double esc = 1;

        public int Row { get => row; set => row = value; }
        public int Coll { get => coll; set => coll = value; }
        public double Esc { get => esc; set => esc = value; }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        dataGridView3A3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridView1A1.Rows[i].Cells[j].Value) + Convert.ToDouble(dataGridView2A2.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Digite apenas números");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                row = Convert.ToInt32(linhas.Text);
                coll = Convert.ToInt32(colunas.Text);
               // esc = Convert.ToDouble(escalar.Text);

                dataGridView1A1.RowCount = row;
                dataGridView1A1.ColumnCount = coll;

                dataGridView2A2.RowCount = row;
                dataGridView2A2.ColumnCount = coll;

                dataGridView3A3.RowCount = row;
                dataGridView3A3.ColumnCount = coll;

                dataGridViewS1.RowCount = row;
                dataGridViewS1.ColumnCount = coll;

                dataGridViewS2.RowCount = row;
                dataGridViewS2.ColumnCount = coll;

                dataGridViewS3.RowCount = row;
                dataGridViewS3.ColumnCount = coll;

                dataGridViewM1.RowCount = row;
                dataGridViewM1.ColumnCount = coll;

                dataGridViewM2.RowCount = row;
                dataGridViewM2.ColumnCount = coll;

                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Apenas numeros inteiros");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        dataGridViewS3.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridViewS1.Rows[i].Cells[j].Value) - Convert.ToDouble(dataGridViewS2.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Digite apenas números");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                esc = Convert.ToDouble(escalar.Text);
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < coll; j++)
                    {
                        dataGridViewM2.Rows[i].Cells[j].Value = Convert.ToDouble(dataGridViewM1.Rows[i].Cells[j].Value) * esc;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Digite apenas números");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
