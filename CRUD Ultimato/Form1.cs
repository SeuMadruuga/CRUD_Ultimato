using System.Data;
using System.Data.SqlClient;

namespace CRUD_Ultimato
{
    public partial class Form1 : Form
    {
        //String Conexão
        SqlConnection con = Connection.con;

        //Limpar Campos
        private void Clean()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtID.Text = string.Empty;
            txtEndereco.Text = string.Empty;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Botão Create
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Connection.OpenDb();
            try
            {
                Connection.Create(txtNome.Text, txtEmail.Text, txtSenha.Text, txtEndereco.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clean();
        }

        //Botão Read
        private void buttonRead_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            Connection.OpenDb();
            try
            {
                Connection.Read(bs);
                dataGridView1.DataSource = bs;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Botão Update
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Connection.OpenDb();
            try
            {
                Connection.Update(txtNome.Text, txtEmail.Text, txtSenha.Text, txtEndereco.Text, txtID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clean();
        }

        //Botão Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Connection.OpenDb();
            try
            {
                Connection.Delete(txtID.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Clean();
        }

        //Tema Claro
        private void buttonLight_Click(object sender, EventArgs e)
        {
            //Cor de Fundo
            //Form
            this.BackColor = Color.White;

            //Textbox
            txtEmail.BackColor = Color.White;
            txtEndereco.BackColor = Color.White;
            txtID.BackColor = Color.White;
            txtNome.BackColor = Color.White;
            txtSenha.BackColor = Color.White;

            //Panel
            panelTitle.BackColor = Color.FromArgb(54, 129, 191);

            //DataGridView
            dataGridView1.BackgroundColor = this.BackColor;

            //Button
            buttonCreate.BackColor = panelTitle.BackColor;
            buttonDelete.BackColor = panelTitle.BackColor;
            buttonRead.BackColor = panelTitle.BackColor;
            buttonUpdate.BackColor = panelTitle.BackColor;
            buttonDark.BackColor = panelTitle.BackColor;
            buttonLight.BackColor = panelTitle.BackColor;
            //----------------------------------------------------------//

            //Bordas
            //Textbox
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            //----------------------------------------------------------//

            //Cor dos Caracteres
            //Textbox
            txtSenha.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtID.ForeColor = Color.Black;
            txtNome.ForeColor = Color.Black;
            txtEndereco.ForeColor = Color.Black;

            //Label
            labelEmail.ForeColor = Color.Black;
            labelEndereco.ForeColor = Color.Black;
            labelID.ForeColor = Color.Black;
            labelNome.ForeColor = Color.Black;
            labelSenha.ForeColor = Color.Black;
            //----------------------------------------------------------//
        }

        //Tema Escuro
        private void buttonDark_Click(object sender, EventArgs e)
        {
            //Cor de Fundo
            //Form
            this.BackColor = Color.FromArgb(18, 18, 18);

            //Textbox
            txtEmail.BackColor = Color.FromArgb(37, 38, 38);
            txtEndereco.BackColor = Color.FromArgb(37, 38, 38);
            txtID.BackColor = Color.FromArgb(37, 38, 38);
            txtNome.BackColor = Color.FromArgb(37, 38, 38);
            txtSenha.BackColor = Color.FromArgb(37, 38, 38);

            //Panel
            panelTitle.BackColor = Color.FromArgb(37, 38, 38);

            //Button
            buttonCreate.BackColor = Color.FromArgb(37, 38, 38);
            buttonRead.BackColor = Color.FromArgb(37, 38, 38);
            buttonUpdate.BackColor = Color.FromArgb(37, 38, 38);
            buttonDelete.BackColor = Color.FromArgb(37, 38, 38);
            buttonDark.BackColor = Color.FromArgb(37, 38, 38);
            buttonLight.BackColor = Color.FromArgb(37, 38, 38);

            //DataGridView
            dataGridView1.BackgroundColor = this.BackColor;
            //----------------------------------------------------------//

            //Bordas
            //Textbox
            txtEmail.BorderStyle = BorderStyle.None;
            txtEndereco.BorderStyle = BorderStyle.None;
            txtID.BorderStyle = BorderStyle.None;
            txtNome.BorderStyle = BorderStyle.None;
            txtSenha.BorderStyle = BorderStyle.None;

            //----------------------------------------------------------//

            //Cor dos Caracteres
            //Textbox
            txtSenha.ForeColor = Color.White;
            txtEmail.ForeColor = Color.White;
            txtID.ForeColor = Color.White;
            txtNome.ForeColor = Color.White;
            txtEndereco.ForeColor = Color.White;

            //Label
            labelEmail.ForeColor = Color.White;
            labelEndereco.ForeColor = Color.White;
            labelID.ForeColor = Color.White;
            labelSenha.ForeColor = Color.White;
            labelNome.ForeColor = Color.White;
            labelTitle.ForeColor = Color.White;

            //Button
            buttonCreate.ForeColor = Color.White;
            buttonRead.ForeColor = Color.White;
            buttonUpdate.ForeColor = Color.White;
            buttonDelete.ForeColor = Color.White;
            buttonDark.ForeColor = Color.White;
            buttonLight.ForeColor = Color.White;
            //----------------------------------------------------------//
        }
    }
}