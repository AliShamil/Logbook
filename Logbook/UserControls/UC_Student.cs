using Logbook.Models;

namespace Logbook.UserControls;



public partial class UC_Student : UserControl
{

    public UC_Student(Student student)
    {
        InitializeComponent();

        cBox_lab.SelectedIndex = 0;
        cBox_class.SelectedIndex = 0;


        lbl_no.Text = student.Number.ToString();

        if(!string.IsNullOrWhiteSpace(student.PictureUrl))
            pBox_profile.Load($"./../../../Resources/{student.PictureUrl}");


        lbl_fullname.Text = student.FullName;
        lbl_lastIn.Text = student.LastIn.ToShortDateString();


        switch (student.Status)
        {
            case ParticipationStatus.Present:
                rBtn_1.Checked = true;
                break;
            case ParticipationStatus.Late:
                rBtn_2.Checked = true;
                break;
            case ParticipationStatus.Absent:
                rBtn_3.Checked = true;
                break;
        }


    }

    private void btn_comment_Click(object sender, EventArgs e)
    {
        btn_comment.Visible = false;
        txt_comment.Visible = true;
        btn_comment_save.Visible = true;
        btn_comment_cancel.Visible = true;
        
    }

    private void btn_comment_save_Click(object sender, EventArgs e)
    {
        
        if(string.IsNullOrWhiteSpace(txt_comment.Text))
            return;
        
         

       lbl_comment.Text = $"{DateTime.Now.ToShortDateString()}: {txt_comment.Text}";
        lbl_comment.Visible =true;
        txt_comment.Visible = false;
        btn_comment_save.Visible = false;
        btn_comment_cancel.Visible = false;
        btn_comment.Visible = false;
    }

    private void btn_comment_cancel_Click(object sender, EventArgs e)
    {
        lbl_comment.Visible =true;
        txt_comment.Visible = false;
        btn_comment_save.Visible = false;
        btn_comment_cancel.Visible = false;
        btn_comment.Visible = true;
    }
}
