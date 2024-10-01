using JJCore.Domain.Interfaces;
using JJCore.Infra.Data;
using JJCore.Infra.Data.Extesions;
using System;
using System.Collections.Generic;
using WF.Domain.Interfaces;

namespace Gestor.GES.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public T GetById(object id)
        {
            return _unitOfWork.Connection.Obter<T>(id, _unitOfWork.Transaction);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
