
using System.Collections.Generic;
using WFServices.Models;
using WFServices.Models.Api;

namespace WFServices.Interfaces
{
    public interface IPexelsService
    {
        IEnumerable<Imagem> ObterImagens();
    }
}
