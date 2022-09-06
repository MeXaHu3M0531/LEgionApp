
using LegionApp;

namespace LEgionApp
{
    public partial class TablForm : Form
    {
        public TablForm()
        {
            InitializeComponent();
        }

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void îòêğûòüÑõåìóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm FormRoom = new RoomForm();
            FormRoom.Show();
        }
    }
}