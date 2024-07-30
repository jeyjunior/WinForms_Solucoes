using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFBase.Interface;

namespace WFBase.Base
{
    public class RecursosBase : IRecursosBase
    {
        public Bitmap ObterRecurso(Recurso recurso)
        {
            Bitmap bitmap = null;

            switch (recurso)
            {
                case Recurso.download: bitmap = Properties.Resources.download; break;
                case Recurso.downloading: bitmap = Properties.Resources.downloading; break;
                case Recurso.download_done: bitmap = Properties.Resources.download_done; break;
            }

            return bitmap;
        }
    }

    public enum Recurso
    {
        download = 0,
        download_done = 1,
        downloading = 2,
    }
}
