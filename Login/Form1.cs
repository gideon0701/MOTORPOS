using PointOfSalesApp.Main;
using PointOfSalesApp.Presenter;
using PointOfSalesApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm, IView
    {

        private MyPresenter presenter = null;

        public Form1()
        {
            presenter = new MyPresenter(this);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            presenter.validateInput(txtUserName.Text, txtPassword.Text);
        }

        public void onLoginResult(int result)
        {
            if (result == 0)
            {
                MainFrm cashier = new MainFrm();
                Hide();
                cashier.ShowDialog();
                Close();
            }
            else if (result == -1)
            {
                MessageBox.Show("Incorrect username or password");
            }
            else
            {
                MessageBox.Show("Cannot connect to the database for a while");
            }
        }

        public void onValidateInput(bool isNotEmpty)
        {
            if (isNotEmpty)
            {
                presenter.doLogin();
            }
            else
            {
                MessageBox.Show("Input username or password");
            }
        }

    }
}
