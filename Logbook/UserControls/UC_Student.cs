using Logbook.Models;
using static System.Formats.Asn1.AsnWriter;

namespace Logbook.UserControls;



public partial class UC_Student : UserControl
{

    public Predicate<int> ChangeTotalDiamond { get; set; }
    public UC_Student(Student student, Predicate<int> crystalCount)
    {
        InitializeComponent();


        ChangeTotalDiamond = crystalCount;
        cBox_lab.SelectedIndex = 0;
        cBox_class.SelectedIndex = 0;


        lbl_no.Text = student.Number.ToString();

        if (!string.IsNullOrWhiteSpace(student.PictureUrl))
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

        if (string.IsNullOrWhiteSpace(txt_comment.Text))
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

    private void btn_diamond_1_Click(object sender, EventArgs e)
    {
        var diamond = sender as Button;
        int count = 0;

        foreach (var control in pnl_diamond.Controls)
        {
            if (control is Button btn)
            {
                if(btn.BackgroundImage.Tag?.ToString() == "checked")
                    ++count;
            }
        }
        if (!ChangeTotalDiamond(int.Parse(diamond.Tag.ToString())- count))
            return;
        switch (diamond.Tag.ToString())
        {
            case "1":

                diamond.BackgroundImage = Properties.Resources.icons8_gem_stone_96;
                diamond.BackgroundImage.Tag = "checked";
                foreach (Control control in pnl_diamond.Controls)
                {
                    if (control.Tag.ToString()!="1")
                    {
                        control.BackgroundImage = Properties.Resources.output_onlinepngtools;
                        control.BackgroundImage.Tag = "unchecked";
                    }
                }

                break;
            case "2":


                foreach (Control control in pnl_diamond.Controls)
                {
                    if (control.Tag.ToString()!="3")
                    {
                        control.BackgroundImage = Properties.Resources.icons8_gem_stone_96;
                        control.BackgroundImage.Tag = "checked";
                    }
                }
                foreach (Control control in pnl_diamond.Controls)
                {
                    if (control.Tag.ToString()=="3")
                    {
                        control.BackgroundImage = Properties.Resources.output_onlinepngtools;
                        control.BackgroundImage.Tag = "unchecked";
                    }
                }

                break;
            case "3":

                foreach (Control control in pnl_diamond.Controls)
                {
                    control.BackgroundImage = Properties.Resources.icons8_gem_stone_96;
                    control.BackgroundImage.Tag = "checked";
                }

                break;
            default:
                foreach (Control control in pnl_diamond.Controls)
                {
                    control.BackgroundImage = Properties.Resources.output_onlinepngtools;
                    control.BackgroundImage.Tag = "unchecked";
                }
                break;
        }

    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        int count = 0;

        foreach (var control in pnl_diamond.Controls)
        {
            if (control is Button btn)
            {
                if (btn.BackgroundImage.Tag?.ToString() == "checked")
                    ++count;
            }
        }
        if (!ChangeTotalDiamond(-count))
            return;
        foreach (Control control in pnl_diamond.Controls)
        {
            control.BackgroundImage = Properties.Resources.output_onlinepngtools;
            control.BackgroundImage.Tag = "unchecked";
        }
    }
    private void ChangeEnable()
    {
        cBox_class.Enabled = !cBox_class.Enabled;
        cBox_lab.Enabled = !cBox_lab.Enabled;
        foreach (Control item in pnl_diamond.Controls)
        {
            item.Enabled = !item.Enabled;
        }
        btn_clear.Enabled =!btn_clear.Enabled;
        btn_comment.Enabled = !btn_comment.Enabled;

    }

    private void rBtn_1_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is RadioButton rb && rb.Tag.ToString()=="present")
            ChangeEnable();
        
        
    }

    private void rBtn_3_CheckedChanged(object sender, EventArgs e)
    {
        cBox_lab.SelectedIndex = 0;
        cBox_class.SelectedIndex = 0;
        btn_clear_Click(sender, e);
        txt_comment.Clear(); 
        lbl_comment.Text = String.Empty;
        btn_comment.Visible = true;
    }

    private void txt_comment_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == Convert.ToChar(Keys.Enter))
            btn_comment_save_Click(sender, e);

    }
}
