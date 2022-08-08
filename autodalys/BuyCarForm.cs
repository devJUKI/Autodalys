using autodalys.Controllers;
using autodalys.Models;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace autodalys
{
    public partial class BuyCarForm : Form
    {
        private Darbuotojas employee;

        public BuyCarForm(Darbuotojas employee) {
            InitializeComponent();

            this.employee = employee;
            InitializeUI();
        }

        private void InitializeUI() {
            MarkeController.GetMakes().ForEach(x => makeDropDown.Items.Add(x.Pavadinimas));
            TextInfo TInfo = new CultureInfo("LT-lt").TextInfo;
            DegaluTipasController.GetFuelTypes().ForEach(
                x => fuelTypeDropDown.Items.Add(TInfo.ToTitleCase(x.Name)));
            PavaruDezeController.GetTransmissionTypes().ForEach(
                x => transmissionDropDown.Items.Add(TInfo.ToTitleCase(x.Name)));
            KebuloTipasController.GetBodyTypes().ForEach(
                x => bodyTypeDownDown.Items.Add(TInfo.ToTitleCase(x.Name)));
            BukleController.GetCarStates().ForEach(
                x => stateDropDown.Items.Add(TInfo.ToTitleCase(x.Name).Replace('_', ' ')));
            VarantysRataiController.GetPoweredWheels().ForEach(
                x => poweredWheelsDropDown.Items.Add(TInfo.ToTitleCase(x.Name).Replace('_', ' ')));
        }

        private void OnMakeTextChanged(object sender, EventArgs e) {
            modelDropDown.SelectedIndex = -1;
            modelDropDown.Items.Clear();
            if (!string.IsNullOrEmpty(makeDropDown.Text)) {
                ModelisController.GetModels(makeDropDown.Text).ForEach(x => modelDropDown.Items.Add(x.Pavadinimas));
            }
        }

        private void buyCar_Click(object sender, EventArgs e) {
            long id = CreateContract();
            Automobilis car = CreateCarObject((int)id);
            AutomobilisController.CreateCar(car);
            Close();
        }

        private long CreateContract() {
            Sutartis contract = new Sutartis {
                SudarymoData = DateTime.Now.Date,
                Kaina = decimal.Parse(price.Text.Replace('.', ',')),
                KlientoAsmensKodas = long.Parse(clientPersonalCode.Text),
                DarbuotojoVidinisKodas = employee.VidinisKodas
            };

            long id = SutartisController.CreateContract(contract);
            return id;
        }

        private Automobilis CreateCarObject(int contractId) {
            if (MarkeController.GetMake(makeDropDown.Text) == null) {
                MarkeController.CreateMake(makeDropDown.Text);
            }

            if (ModelisController.GetModel(modelDropDown.Text) == null) {
                ModelisController.CreateModel(modelDropDown.Text, MarkeController.GetMakeId(makeDropDown.Text));
            }

            return new Automobilis {
                Vin = vin.Text,
                Rida = int.Parse(mileage.Text),
                KilmesSalis = country.Text,
                PagaminimoData = makeDate.Value.Date,
                VietuSkaicius = (int)seatsCount.Value,
                Spalva = color.Text,
                DuruSkaicius = (int)doorCount.Value,
                DegaluTipas = fuelTypeDropDown.SelectedIndex + 1,
                PavaruDeze = transmissionDropDown.SelectedIndex + 1,
                KebuloTipas = bodyTypeDownDown.SelectedIndex + 1,
                Bukle = stateDropDown.SelectedIndex + 1,
                VarantysRatai = poweredWheelsDropDown.SelectedIndex + 1,
                SutartiesId = contractId,
                ModelioId = ModelisController.GetModelId(modelDropDown.Text)
            };

        }
    }
}
