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
    public partial class PlacementForm : Form
    {
        //PlacementService placementService;
        public PlacementForm(string name)
        {
            InitializeComponent();
            //placementService = new PlacementService(name);
            Update();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var name = nameBox.Text;
            var unit = unitBox.Text;

            //placementService.AddMaterial(name, unit);
            Update();
        }

        void Update()
        {
            materialListBox.Items.Clear();
            //materialListBox.Items.AddRange(placementService.placement.Materials.ToArray());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var index = materialListBox.SelectedIndex;
            if (index == -1) return;

            materialListBox.Items.RemoveAt(index);
            //placementService.DeleteMaterial(index);
        }

        private void countBox_KeyDown(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;
            double count;

            


             if (key == Keys.Enter)
             {
                if (double.TryParse(countBox.Text, out count))
                {
                    var index = materialListBox.SelectedIndex;
                    if (index == -1)
                    {
                        MessageBox.Show("Не указан материал");
                        return;
                    }
                    ////if (placementService.TryChangeMaterialCount(count, index))
                    //{
                    //    materialListBox.Items[index] = placementService.placement.Materials[index];
                    //}
                    //else MessageBox.Show("Слишком большое уменьшение количества");
                }
                else
                {
                    MessageBox.Show("Неправильный ввод");
                }
             }
        }
    }
}
