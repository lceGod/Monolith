using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ASMF_Monolith
{
    public partial class ManagerForm : Form
    {
        ManagerService service = new(); 
        public ManagerForm()
        {
            InitializeComponent();
            Update();
        }

        private void placementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var placementName = placementListBox.SelectedItem.ToString();
            var materials = service.GetMaterialsList(placementName);
            materialListBox.Items.Clear();
            foreach (var material in materials)
            {
                materialListBox.Items.Add(material);
            }

        }

        public void Update()
        {
            service.Update();
            placementListBox.Items.Clear();
            foreach (var item in service.GetPlacementNames())
            {
                placementListBox.Items.Add(item);
            }
        }

        private void AddPlacementButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddPlacementForm();
            addForm.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
