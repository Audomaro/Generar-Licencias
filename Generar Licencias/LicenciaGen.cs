using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Generar_Licencias
{
    public static class Licencia
    {
        public static void Generar(string UniqueID, string Sistema, string Empresa, DateTime Valido)
        {
            DateTime Hora = DateTime.Now;
            string Archivo = string.Format(@"licencias\{0}_{1}_{2:dd-MM-yyyy HH.mm.ss tt}.txt", Sistema, Empresa, Hora);
            string ArchivoLibre = string.Format(@"licencias\{0}_{1}_{2:dd-MM-yyyy HH.mm.ss tt}.Libre.txt", Sistema, Empresa, Hora);

            StringBuilder sbLicencia = new StringBuilder();
            sbLicencia.Append(SHA5.Encrypt(UniqueID, UniqueID) + '|');
            sbLicencia.Append(SHA5.Encrypt(Sistema, UniqueID) + '|');
            sbLicencia.Append(SHA5.Encrypt(Empresa, UniqueID) + '|');
            sbLicencia.Append(SHA5.Encrypt(Valido.ToString(), UniqueID));

            using (StreamWriter fs = new StreamWriter(Archivo, true))
            {
                fs.Write(SHA5.Encrypt(sbLicencia.ToString(), UniqueID));
            }

            sbLicencia.Clear();
            sbLicencia.AppendLine(UniqueID);
            sbLicencia.AppendLine(Sistema);
            sbLicencia.AppendLine(Empresa);
            sbLicencia.Append(Valido.ToString());
            using (StreamWriter fs = new StreamWriter(ArchivoLibre, true))
            {
                fs.Write(sbLicencia.ToString());
            }

            Process.Start(Archivo);
            Process.Start(ArchivoLibre);
        }
    }
}
