using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDataSet1.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.storeDataSet1.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.storeDataSet.Books);

        }
    }
}
