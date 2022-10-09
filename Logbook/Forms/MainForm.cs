using Logbook.Repository;
using Logbook.UserControls;
using Microsoft.VisualBasic.Devices;

namespace Logbook.Forms;



public partial class MainForm : Form
{
    public Predicate<int> ChangeTotalDiamond { get; set; }
    public MainForm()
    {
        InitializeComponent();
        ChangeTotalDiamond += (score) =>
        {
            int totalScore = int.Parse(lbl_crystal_count.Text);

            if (totalScore - score < 0)
                return false;

            totalScore -= score;
            lbl_crystal_count.Text = totalScore.ToString();

            return true;
        };
    }

    
    private void MainForm_Load(object sender, EventArgs e)
    {
        
        var students = FakeRepo.GetStudents();

        for (int i = students.Count - 1; i >= 0; i--)
        {
            UC_Student uc = new(students[i], ChangeTotalDiamond);
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
                {
                    uc.Enabled = false;
                    uc.rBtn_3.Checked = true;
                }

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

 
    private void txt_topic_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == Convert.ToChar(Keys.Enter))
            btn_topic_save_Click(sender, e);
        
        else if (e.KeyChar == Convert.ToChar(Keys.Back))
            btn_topic_cancel_Click(sender, e);
    }
}
