using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generar_Licencias
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        string FullFile = string.Empty;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TxtUniqueID1.Text = Computer_Info.UniqueID();
            this.TxtUniqueID2.Text = Computer_Info.UniqueID();
        }

        private void BtnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            this.OfdArchivo.ShowDialog();

            if (this.OfdArchivo.FileName.Length > 0)
            {
                this.FullFile = OfdArchivo.FileName;
                string[] x = OfdArchivo.FileName.Split('\\');
                this.TxtArchivo.Text = x[x.Length-1];
            }
            else
            {
                this.TxtArchivo.Text = "";
            }
        }

        private void BtnValidarArchivo_Click(object sender, EventArgs e)
        {
            if (this.TxtArchivo.Text.Length > 0)
            {
                string[] Datos = SHA5.Decrypt(File.ReadAllText(this.FullFile), this.TxtUniqueID1.Text).Split('|');

                if (this.TxtUniqueID1.Text == SHA5.Decrypt(Datos[0], this.TxtUniqueID1.Text))
                {
                    MessageBox.Show(
                        SHA5.Decrypt(Datos[1], this.TxtUniqueID1.Text) + "\r\n" +
                        SHA5.Decrypt(Datos[2], this.TxtUniqueID1.Text) + "\r\n" +
                        SHA5.Decrypt(Datos[3], this.TxtUniqueID1.Text)
                    );

                    if (DateTime.Now > Convert.ToDateTime(SHA5.Decrypt(Datos[3], this.TxtUniqueID1.Text)))
                    {
                        MessageBox.Show(String.Format("Ya no es valida esta licencia."));
                    }
                    else
                    {
                        MessageBox.Show("Aun es valida la licencia.");
                    }
                }
                else
                {
                    MessageBox.Show("Esta licencia no le pertenece.");
                }
            }
        }

        private void BtnGenerarArchivo_Click(object sender, EventArgs e)
        {
            Licencia.Generar(this.TxtUniqueID2.Text, this.TxtSistema.Text, this.TxtEmpresa.Text, this.DatVigencia.DateTime);
        }
    }
}
