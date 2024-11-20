using Practica_Final_prog2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Final_prog2
{
    
    public partial class Form1 : Form
    {
        string path = Application.StartupPath + "\\facu.dat";
        public Form1()
        {
            InitializeComponent();
        }
        Facultad facu = new Facultad();
        public void ActualizarLista()
        {
            lbxCursos.Items.Clear();
            foreach(Curso c in facu.DevolverLista())
            {
                lbxCursos.Items.Add(c.ToString());
            }
            
        }
        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbxNombre.Text;
                long dni = Convert.ToInt64(tbxDni.Text);
                string esp = tbxLE.Text;
                string nomC = tbxNombreCurso.Text;
                Curso c = new Curso(nom,dni,esp,nomC);
                facu.AgregarCurso(c);
                ActualizarLista();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = tbxNombre.Text;
                long dni = Convert.ToInt64(tbxDni.Text);
                int leg = Convert.ToInt32(tbxLE.Text);
                int idx = lbxCursos.SelectedIndex;
                facu.AgregarAlumno(nom, dni, leg, idx);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    facu = bf.Deserialize(fs) as Facultad;
                    ActualizarLista();
                }
                finally
                {
                    if(fs!= null) fs.Close();   
                }
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, facu);
            }
            finally
            {
                if(fs!= null) fs.Close();
            }
        }
    }
}
