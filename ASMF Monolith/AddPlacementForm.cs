using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMF_Monolith
{
    public partial class AddPlacementForm : Form
    {
        public AddPlacementForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var password = pwBox.Text;

            if (name == "" || password == "")
            {
                MessageBox.Show("Вначалее введите название и пароль помещения");
                return;
            }

            if (ManagerService.PlacementExist(name))
            {
                MessageBox.Show("Помещение с таким названием уже существует");
                return;
            }

            ManagerService.AddPlacement(name, password, false);
            this.Close();
        }
    }
}
