using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookStore.Views
{
    public partial class MainPanelView : Form
    {
        public MainPanelView()
        {
            InitializeComponent();
        }

        private void MainPanelView_Load(object sender, EventArgs e)
        {
            lstData.Items.Add("Harry Potter");
            lstData.Items.Add("El país de nunca jamás");
            lstData.Items.Add("El principito");
            lstData.Items.Add("El señor de los anillos");
            lstData.Items.Add("La magia en los niños");
            lstData.Items.Add("Lo que cuentan los abuelos");

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstData.Items.Add(txtData.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
