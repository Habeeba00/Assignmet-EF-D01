using Assignmet_EF_D01.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignmet_EF_D01
{
    public partial class Form1 : Form
    {

        ITIContext db;
        public Form1()
        {
            db = new ITIContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.St_Age, n.St_Address, n.Dept_Id, n.Dept.Dept_Name, n.Dept.Dept_Location }).ToList();
            comboBoxDepartment.DataSource = db.Departments.ToList();
            comboBoxDepartment.ValueMember = "Dept_Id";
            comboBoxDepartment.DisplayMember = "Dept_Name";

            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                St_Fname = textBoxFname.Text,
                St_Lname = textBoxLname.Text,
                St_Age = int.Parse(textBoxAge.Text),
                St_Address = textBoxAddress.Text,
                Dept_Id = (int)comboBoxDepartment.SelectedValue,

            };
            db.Students.Add(student);
            db.SaveChanges();
            dataGridViewStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.Dept_Id, n.Dept.Dept_Name, n.Dept.Dept_Location }).ToList();
            textBoxFname.Text = textBoxAge.Text = textBoxLname.Text = textBoxAddress.Text = "";
            MessageBox.Show("Sucessfully Added");





        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        int id;
        private void dataGridViewStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridViewStudents.SelectedRows[0].Cells[0].Value;
            Student s = db.Students.Where(s => s.St_Id == id).SingleOrDefault();
            textBoxFname.Text = s.St_Fname;
            textBoxLname.Text = s.St_Lname;
            textBoxAge.Text = s.St_Age.ToString();
            textBoxAddress.Text = s.St_Address;
            comboBoxDepartment.SelectedValue = s.Dept_Id;

            buttonAdd.Visible = false;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(s => s.St_Id == id).SingleOrDefault();
            s.St_Fname = textBoxFname.Text;
            s.St_Lname = textBoxLname.Text;
            s.St_Age = int.Parse(textBoxAge.Text);
            s.St_Address = textBoxAddress.Text;
            s.Dept_Id = (int)comboBoxDepartment.SelectedValue;
            db.SaveChanges();
            dataGridViewStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.Dept_Id, n.Dept.Dept_Name, n.Dept.Dept_Location }).ToList();
            textBoxFname.Text = textBoxAge.Text = textBoxLname.Text = textBoxAddress.Text = "";
            MessageBox.Show(" Updated Sucessfully");


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Student s = db.Students.Where(s => s.St_Id == id).SingleOrDefault();
            db.Students.Remove(s);
            db.SaveChanges();

            dataGridViewStudents.DataSource = db.Students.Include(n => n.Dept).Select(n => new { n.St_Id, n.St_Fname, n.St_Lname, n.Dept_Id, n.Dept.Dept_Name, n.Dept.Dept_Location }).ToList();
            textBoxFname.Text = textBoxAge.Text = textBoxLname.Text = textBoxAddress.Text = "";
            MessageBox.Show("Sucessfully Deleted");

        }
    }
}
