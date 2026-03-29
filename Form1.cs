using System.Drawing.Text;
using TestWins.Controller;

namespace TestWins;

public partial class Form1 : Form
{
    //business

    private readonly StudentController controller = new StudentController();
public Form1()
{
    InitializeComponent();

    
    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    dataGridView1.AutoGenerateColumns = true; 
    dataGridView1.MultiSelect = false; 

    loadData();
}

private void loadData()
{
    try
    {
        dataGridView1.DataSource = controller.getAll();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading data: " + ex.Message);
    }
}

 private void btnAdd_Click(object sender, EventArgs e)
{
    try
    {
        var student = new TestWins.Model.Student
        {
            studentId = txtStudentId.Text,
            Name = txtName.Text,
            age = int.Parse(txtAge.Text),
            course = txtCourse.Text
        };
        controller.createStudent(student);
        loadData();
        clearFields();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error adding student: " + ex.Message);
    }
}

private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        var student = new TestWins.Model.Student
        {
            studentId = txtStudentId.Text,
            Name = txtName.Text,
            age = int.Parse(txtAge.Text),
            course = txtCourse.Text
        };
        controller.update(student);
        loadData();
        clearFields();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error updating student: " + ex.Message);
    }
}

private void btnDelete_Click(object sender, EventArgs e)
{
    try
    {
        controller.delete(txtStudentId.Text);
        loadData();
        clearFields();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error deleting student: " + ex.Message);
    }
}

private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (dataGridView1.CurrentRow != null)
    {
        DataGridViewRow row = dataGridView1.CurrentRow;
        txtStudentId.Text = row.Cells[0].Value.ToString();
        txtName.Text = row.Cells[1].Value.ToString();
        txtAge.Text = row.Cells[2].Value.ToString();
        txtCourse.Text = row.Cells[3].Value.ToString();
    }
}


private void clearFields()
{
    txtStudentId.Text = "";
    txtName.Text = "";
    txtAge.Text = "";
    txtCourse.Text = "";
}
}
