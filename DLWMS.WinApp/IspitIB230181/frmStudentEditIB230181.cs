using DLWMS.Data;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DocumentFormat.OpenXml.Drawing;

namespace DLWMS.WinApp.IspitIB230181
{
    public partial class frmStudentEditIB230181 : Form
    {
        private Student student;


        DLWMSContext db = new DLWMSContext();
        public frmStudentEditIB230181(Student student)
        {
            InitializeComponent();

            this.student = student;
        }

        private void frmStudentEditIB230181_Load(object sender, EventArgs e)
        {
            pbSlika.Image = Ekstenzije.ToImage(student.Slika);
            lbIme.Text = $"{student.Ime} {student.Prezime}";
            lblIndeks.Text = $"{student.BrojIndeksa}";
            UcitajCombo();
        }

        private void UcitajCombo()
        {
            cmbDrzave.DataSource = db.Drzave.Select(x => x.Naziv).ToList();
            cmbGradovi.DataSource = db.Gradovi.Where(x => x.DrzavaId == cmbDrzave.SelectedIndex + 1).Select(x => x.Naziv).ToList();
            cmbGradovi.Text = db.Gradovi.Where(x=>x.Id == student.GradId).Select(x=>x.Naziv).FirstOrDefault();
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGradovi.DataSource = db.Gradovi.Where(x => x.DrzavaId == cmbDrzave.SelectedIndex + 1).Select(x => x.Naziv).ToList();

        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string odabraniGrad = cmbGradovi.SelectedItem.ToString(); // Dobijanje naziva grada

            var grad = db.Gradovi.FirstOrDefault(x => x.Naziv == odabraniGrad); // Pronalazak grada u bazi

            if (grad != null && validiraj()) // Provjera da li je grad pronađen
            {
                student.Slika = Ekstenzije.ToByteArray(pbSlika.Image);
                student.GradId = grad.Id;

                db.Studenti.Update(student);
                db.SaveChanges();
                Close();
            }
        }


        private bool validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, errorProvider1, Kljucevi.RequiredField);
        }
    }
}
