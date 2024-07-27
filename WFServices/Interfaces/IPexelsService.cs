using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFServices.Models;

namespace WFServices.Interfaces
{
    public interface IPexelsService
    {
        Task<List<Foto>> BuscarFotosAsync(string query, int maxImages = 10);
    }
}
