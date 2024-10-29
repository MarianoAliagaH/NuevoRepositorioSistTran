using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;


namespace CapaPresentacion
{
    public partial class PagarFactura : Form
    {
        public PagarFactura()
        {
            InitializeComponent();
        }

        private void PagarFactura_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns.Add("Serie", "Serie");
            dataGridView1.Columns.Add("Cliente", "Cliente");
            dataGridView1.Columns.Add("SubTotal", "SubTotal");
            dataGridView1.Columns.Add("I.G.V", "I.G.V");
        }

        private void bGrabar_Click(object sender, EventArgs e)
        {
            int indice_fila = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[indice_fila];

            //row.Cells["Fecha"].Value = dTPFecha.Value;
            row.Cells["Serie"].Value = txtBSerie.Text;
            row.Cells["Cliente"].Value = txtBCliente.Text;
            row.Cells["SubTotal"].Value = txtBSubtotal.Text;
            row.Cells["I.G.V"].Value = txtBMontoIGV.Text;
        }

        private void bCancelarFactura_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = CapaPresentacion.Properties.Resources.plantilla.ToString();


            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txtBCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            /*string filas = string.Empty;
            //decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Serie"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cliente"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["I.G.V"].Value.ToString() + "</td>";
                filas += "</tr>";
                //total += decimal.Parse(row.Cells["Importe"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            //PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString()); */



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));


                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.trc, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(10, 100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);



                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
