using Backend;

namespace ASMF_Monolith
{
    public partial class AddPlacementForm : Form
    {
        ManagerService service;
        public AddPlacementForm(ManagerService mServ)
        {
            InitializeComponent();
            this.service = mServ;
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

            if (service.PlacementExist(name))
            {
                MessageBox.Show("Помещение с таким названием уже существует");
                return;
            }

            service.AddPlacement(name, password, false);
            this.Close();
        }
    }
}
