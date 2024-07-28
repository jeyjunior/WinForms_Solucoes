
using System.Collections.Generic;
using WFServices.Models;

namespace WFServices.Interfaces
{
    public interface IPexelsService
    {
        IEnumerable<PexelsImagem> ObterFotos();
    }
}
