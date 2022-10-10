namespace Trackbar_Task
{
    public partial class ColorChange : Form
    {
        public ColorChange()
        {
            InitializeComponent();
        }


        private void trackBar_Scroll(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(tb_green.Value, tb_blue.Value, tb_red.Value);
            var parent = (sender as TrackBar).Parent;
            foreach (var item in parent.Controls)
            {
                if(item is Label lb)
                    lb.Text = (sender as TrackBar).Value.ToString();
            }
        }
    }
}