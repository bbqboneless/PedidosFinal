using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using QRCoder;

namespace ProyectoFinal
{
    public class Tienda1Builder : PedidosBuilder
    {
        //pedido construido
        private Pedidos _pedido = new Pedidos();

        public override void PrepararInformacion()
        {
            string path = @"Jsons\JSONTienda1.json";
            string pathqr = @"Qrs\Tienda1.png";
            /*
            if (File.Exists(path))
            {
                File.Delete(path);
            } 
            if (File.Exists(pathqr))
            {
                File.Delete(pathqr);
            }
            */
            _pedido.Check(1);
        }

        public override void CapturarPedido(string p1, int c1, string p2, int c2, string p3, int c3)
        {
            Orden jsonobj = new Orden();
            jsonobj.NombreTienda = "Tienda 1";
            jsonobj.IDTienda = 1;
            jsonobj.orden = new List<Pedido>();
            jsonobj.orden.Add(new Pedido()
            {
                Nombre = p1,
                ID = 11,
                Cantidad = c1,
                Precio = 18
            });

            jsonobj.orden.Add(new Pedido()
            {
                Nombre = p2,
                ID = 12,
                Cantidad = c2,
                Precio = 22
            });

            jsonobj.orden.Add(new Pedido()
            {
                Nombre = p3,
                ID = 13,
                Cantidad = c3,
                Precio = 39
            });

            var json = JsonConvert.SerializeObject(jsonobj);
            string path = @"Jsons\JSONTienda1.json";
            System.IO.File.WriteAllText(path, json);

            _pedido.Check(1);
        }

        public override void GenerarQR()
        {
            string path = @"Jsons\JSONTienda1.json";
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            var json = File.ReadAllText(path);
            qrEncoder.TryEncode(json, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemp = new Bitmap(ms);
            var imagen = new Bitmap(imageTemp, new Size(new Point(149, 162)));
            Image image = (Image)imagen;
            string pathqr = @"Qrs\Tienda1.png";
            //image.Save(pathqr, ImageFormat.Png);

            _pedido.Check(1);
        }

        public override Pedidos GetPedido()
        {
            return _pedido;
        }

    }
}
