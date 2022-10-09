using Logbook.Repository;
using Logbook.UserControls;

namespace Logbook.Forms;



public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }


    private void MainForm_Load(object sender, EventArgs e)
    {
        var students = FakeRepo.GetStudents();

        for (int i = students.Count - 1; i >= 0; i--)
        {
            UC_Student uc = new(students[i]);
            uc.Dock = DockStyle.Top;
            pnl_content.Controls.Add(uc);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        
        foreach (Control control in pnl_topic.Controls)
        {
            control.Visible = true;
        }
        pnl_topic.Location = new System.Drawing.Point(156, 12);

    }

    private void btn_topic_save_Click(object sender, EventArgs e)
    {
        lbl_topic.Text = txt_topic.Text;
        foreach (Control control in pnl_topic.Controls)
        {
            control.Visible = false;
        }
        pnl_topic.Location = new System.Drawing.Point(352, 10);
    }

    private void btn_topic_cancel_Click(object sender, EventArgs e)
    {
        foreach (Control control in pnl_topic.Controls)
        {
            control.Visible = false;
        }
        pnl_topic.Location = new System.Drawing.Point(352, 10);
    }
}
