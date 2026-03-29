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

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {



    }

    private void dataGridView1_CellClick(object sender, EventArgs e)
    {

    }
}
