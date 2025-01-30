using System.Data;
using DLWMS.Data;
using DLWMS.Infrastructure;

namespace DLWMS.WinApp.IspitIB230181
{
    public partial class frmPretragaIB230181 : Form
    {
        DLWMSContext db = new DLWMSContext();
        List<Student> studentLista = new List<Student>();
        public frmPretragaIB230181()
        {
            InitializeComponent();
        }

        private void frmPretragaIB230181_Load(object sender, EventArgs e)
        {
            dgvPodaci.AutoGenerateColumns = false;
            UcitajCmb();
            studentLista = db.Studenti.ToList();
            Pretraga();
        }

        private void UcitajPodatke(List<Student> result)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ImePrezime");
            dt.Columns.Add("Drzava");
            dt.Columns.Add("Grad");
            dt.Columns.Add("Spol");
            dt.Columns.Add("Aktivan");

            for (int i = 0; i < result.Count; i++)
            {
                var student = result[i];
                var row = dt.NewRow();
                row["ImePrezime"] = $"({student.BrojIndeksa}) {student.Ime} {student.Prezime}";
                row["Drzava"] = cmbDrzava.Text;
                row["Grad"] = db.Gradovi.Where(x => x.Id == student.GradId).Select(x => x.Naziv).FirstOrDefault();
                row["Spol"] = db.SpoloviIB230181.Where(x => x.Id == student.SpolId).Select(x => x.Naziv).FirstOrDefault();
                row["Aktivan"] = student.Aktivan;
                dt.Rows.Add(row);
            }
            dgvPodaci.DataSource = null;
            dgvPodaci.DataSource = dt;
            Text = $"Pretrazenih studenata -> {dgvPodaci.RowCount}";

        }


        private void UcitajCmb()
        {
            cmbDrzava.DataSource = db.Drzave.Select(x => x.Naziv).ToList();
            cmbSpol.DataSource = db.SpoloviIB230181.Select(x => x.Naziv).ToList();
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            var spol = cmbSpol.Text;
            var ime = tbIme.Text;
            var drzava = cmbDrzava.SelectedIndex + 1;
            if (string.IsNullOrWhiteSpace(ime))
            {
                studentLista = db.Studenti
                .Where(x => x.Spol.Naziv == spol && x.Grad.DrzavaId == drzava)
                .ToList();

            }
            else
            {
                studentLista = db.Studenti
                    .Where(x => x.Spol.Naziv == spol && (x.Ime.StartsWith(ime) || x.Prezime.StartsWith(ime)) && x.Grad.DrzavaId == drzava)
                    .ToList();


            }
            UcitajPodatke(studentLista);
        }



        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();

        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();

        }

        private void dgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "Aktivan")
            {
                if (studentLista[e.RowIndex].Aktivan == true)
                {
                    studentLista[e.RowIndex].Aktivan = false;
                }
                else
                {
                    studentLista[e.RowIndex].Aktivan = true;
                }

                db.Studenti.Update(studentLista[e.RowIndex]);
                db.SaveChanges();
                UcitajPodatke(studentLista);
            }

        }

        private void dgvPodaci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name != "btnRazmjena")
            {
                new frmStudentEditIB230181(studentLista[e.RowIndex]).ShowDialog();
                Pretraga();
            }
        }
    }
}
