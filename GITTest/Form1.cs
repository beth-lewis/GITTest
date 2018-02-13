using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concertTicketsDataSet.tblTicket' table. You can move, or remove it, as needed.
            this.tblTicketTableAdapter.Fill(this.concertTicketsDataSet.tblTicket);
            // TODO: This line of code loads data into the 'dMU_BoxDataSet.tblHall' table. You can move, or remove it, as needed.
            this.tblHallTableAdapter.Fill(this.dMU_BoxDataSet.tblHall);
            //comment
        }
    }
}
