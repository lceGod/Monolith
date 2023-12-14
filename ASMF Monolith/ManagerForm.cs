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
            // В конструкторе инициализируем все компоненты и обновляем состояние формы
            InitializeComponent();
            Update();
        }

        // Обработка выбора помещения из списка
        private void placementList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем имя выбранного помезения
            var placementName = placementListBox.SelectedItem.ToString();
            // По имени получаем список материалов
            var materials = service.GetMaterialsList(placementName);
            // Очищаем текущее содержимое списка
            materialListBox.Items.Clear();

            // Выводим все материалы в ListBox
            foreach (var material in materials)
            {
                materialListBox.Items.Add(material);
            }

        }

        // Метод обновления информации  в окне
        public void Update()
        {
            // Обновляем данные внутреннего класса вычислителя
            service.Update();

            // Очищаем текущее содержимое списка
            placementListBox.Items.Clear();

            // Обновляем его содержимое по новому запрошенному списку
            foreach (var item in service.GetPlacementNames())
            {
                placementListBox.Items.Add(item);
            }
        }

        // Обработка нажатия на кнопку добавления помещения
        private void AddPlacementButton_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр нового окна добавления помещения и показываем его
            var addForm = new AddPlacementForm(service);
            addForm.ShowDialog();
        }

        // Обработка нажатия на кнопку обновления
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // запускаем обновление информации
            Update();
        }
    }
}
