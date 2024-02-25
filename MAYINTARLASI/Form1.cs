namespace MAYINTARLASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void btn_oyunabasla_Click(object sender, EventArgs e)
        {
            butonuret();
            btn_oyunabasla.Enabled = false;

        }


        private void butonuret()
        {

            flowLayoutPanel1.Controls.Clear();


            int a, b, c;
            Random rnd = new Random();
            a = rnd.Next(1, 24);
            b = rnd.Next(25, 48); s
            c = rnd.Next(48, 72);

            for (int i = 1; i < 73; i++)
            {
                Button _buton = new Button();
                _buton.BackColor = Color.AliceBlue;
                _buton.Name = i.ToString();
                _buton.Size = new System.Drawing.Size(60, 60);
                _buton.Text = i.ToString();
                _buton.Tag = null;

                if (a == i || b == i || c == i)
                {
                    _buton.Tag = true;
                }
                else
                    _buton.Tag = false;

                _buton.Click += _buton_Click;


                flowLayoutPanel1.Controls.Add(_buton);
            }
        }

        public int mayinskorint = 0;
        public int skorint = 0;
        public void _buton_Click(object? sender, EventArgs e)
        {
            Button basilanbuton = (Button)sender;
            bool sayibulundumu = (bool)basilanbuton.Tag;



            if (sayibulundumu)
            {

                MessageBox.Show("MAYINA BASTINIZ..");
                basilanbuton.BackColor = Color.Red;
                basilanbuton.Enabled = false;
                mayinskorint = Convert.ToInt32(lblmay�nskor.Text);
                mayinskorint++;
                lblmay�nskor.Text = mayinskorint.ToString();

            }

            else
            {
                basilanbuton.Enabled = false;
                basilanbuton.BackColor = Color.Green;
                skorint = Convert.ToInt32(lblskor.Text);
                skorint++;
                lblskor.Text = skorint.ToString();

            }

            if (mayinskorint == 3)
            {

                DialogResult dialogResult = MessageBox.Show("B�T�N MAYINLAR PATLADI.BA�TAN BA�LAMAK �STER M�S�N�Z?", "B�LG�LEND�RME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    mayinskorint = Convert.ToInt32(0);
                    mayinskorint = 0;
                    lblmay�nskor.Text = mayinskorint.ToString();
                    skorint = Convert.ToInt32(0);
                    skorint = 0;
                    lblskor.Text = skorint.ToString();

                    butonuret();

                }
                else
                    return;

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblmay�nskor_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}



