using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WFServices.Interfaces.Sistema;
using static System.Net.Mime.MediaTypeNames;

namespace WFServices.Services.Sistema
{
    public class GerenciadorService : IGerenciadorService
    {
        // EVENTO A SER EXECUTADO

        public bool BaixarImagem(string url, EventArgs e = null)
        {
            using (WebClient webClient = new WebClient())
            {
                var t = new Uri("https://cdn.motor1.com/images/mgl/38zZY/s1/yamaha-mt-07-2019.jpg");

                var data = webClient.DownloadData(t);

                using (MemoryStream mem = new MemoryStream(data))
                {
                }

            }
            return false;
        }
    }
}
