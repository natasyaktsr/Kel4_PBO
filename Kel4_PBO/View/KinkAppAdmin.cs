using FontAwesome.Sharp;
using Kel4_PBO.View;
using System.Runtime.InteropServices;

namespace Kel4_PBO
{
    public partial class KinkAppAdmin : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public KinkAppAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(0, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        //ubah warna click menu
        private struct btnonclick
        {
            public static Color menuclick = Color.FromArgb(0, 0, 0);
        }

        private void ActivateButton(Object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 102, 36);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 0, 0);
                currentBtn.ForeColor = Color.FromArgb(255, 102, 36);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(255, 102, 36);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        { 
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelChildForm.Text = childForm.Text;
        }

        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnonclick.menuclick);
            OpenChildForm(new Dashboard());
        }

        private void iconButtonKotakMasuk_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnonclick.menuclick);
            OpenChildForm(new FormKotakMasuk());
        }

        private void iconButtonDataBarang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnonclick.menuclick);
            OpenChildForm(new DataBarang());
        }

        private void iconButtonPesanan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnonclick.menuclick);
            OpenChildForm(new FormPesanan());
        }

        private void iconButtonDataKaryawan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, btnonclick.menuclick);
            OpenChildForm(new FormDataKaryawan());
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(255, 255, 255);
            labelChildForm.Text = "Home";
        }
    }
}
