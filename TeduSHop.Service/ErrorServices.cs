using System;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduSHop.Service
{
    public interface IErrorServices
    {
        Error Create(Error Error);

        void Save();
    }

    public class ErrorServices : IErrorServices
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorServices(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error Error)
        {
            return _errorRepository.Add(Error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}