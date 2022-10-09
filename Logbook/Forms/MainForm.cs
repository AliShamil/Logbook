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
            uc.Enabled = false;
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
        if (!string.IsNullOrWhiteSpace(lbl_topic.Text))
        {
            rbtn_mark_all.Enabled = true;
            foreach (Control item in pnl_content.Controls)
            {
                if (item is UC_Student uc)
                    uc.Enabled = true;
            }
        }
        else
        {
            rbtn_mark_all.Enabled = false;
            foreach (Control item in pnl_content.Controls)
            {
                if (item is UC_Student uc)
                    uc.Enabled = false;
            }
        }

    }

    private void btn_topic_cancel_Click(object sender, EventArgs e)
    {
        foreach (Control control in pnl_topic.Controls)
        {
            control.Visible = false;
        }
        pnl_topic.Location = new System.Drawing.Point(352, 10);
    }



    private void rBtn_regular_CheckedChanged_1(object sender, EventArgs e)
    {
        btn_topic.Enabled = true;

    }

    private void rbtn_mark_all_CheckedChanged(object sender, EventArgs e)
    {
        foreach(Control control in pnl_content.Controls)
        {
            if (control is UC_Student uc)
            {
                uc.rBtn_1.Checked = true;
            }

        }
    }
}
