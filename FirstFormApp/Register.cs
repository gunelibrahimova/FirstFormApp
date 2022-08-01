using FirstFormApp.Data;
using FirstFormApp.Models;
using FirstFormApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApp
{
    public partial class Register : Form
    {
        AuthManager _authManager = new();
        public Register()
        {
            InitializeComponent();
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            var name = TxtName.Text;
            var surname = TxtSurname.Text;
            var email = Txtemail.Text;
            var password = Txtpassword.Text;
            var confirmpassword = Txtconfirmpassword.Text;


            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(surname) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Butun xanalari doldurun", "Diqqet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (confirmpassword != password)
                {
                    MessageBox.Show("Sifreler eyni deyil");
                }
                else {
                    try
                    {
                        User newUser = new()
                        {
                            Email = email,
                            Password = password,
                            Name = name,
                            Surname = surname,
                        };
                        _authManager.Register(newUser, password);
                        MessageBox.Show("Qeydiyyatdan ugurla kecdiniz");
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xeta bas verdi yeniden cehd edin");
                    }
                }
            }
        }


    }
}
