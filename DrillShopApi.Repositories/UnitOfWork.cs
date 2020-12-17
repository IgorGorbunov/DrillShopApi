using System;
using DrillShopApi.DAL.Contexts;
using DrillShopApi.Repositories.Interfaces;
using AutoMapper;

namespace DrillShopApi.Repositories
{

    /// <summary>
    /// Класс, реализующий паттерн Unit of Work
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DrillShopContext _db;
        private IMapper _mapper;

        private IDrillRepository _drillRepository;
        private IProviderRepository _providerRepository;
        private IShopRepository _shopRepository;
        private IWarehouseRepository _warehouseRepository;

        private bool _disposed = false;

        public UnitOfWork(DrillShopContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Метод сохраняет DbContext.
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }

        /// <summary>
        /// Метод освобождает выделенные ресурсы контекста.
        /// </summary>
        /// <param name="disposing"></param>
        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this._disposed = true;
            }
        }

        /// <summary>
        /// Метод освобождает выделенные ресурсы контекста.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        

        public IDrillRepository DrillRepository
        {
            get
            {
                if (_drillRepository == null)
                    _drillRepository = new DrillRepository(_db, _mapper);
                return _drillRepository;
            }
        }

        public IProviderRepository ProviderRepository
        {
            get
            {
                if (_providerRepository == null)
                    _providerRepository = new ProviderRepository(_db, _mapper);
                return _providerRepository;
            }
        }

        public IShopRepository ShopRepository
        {
            get
            {
                if (_shopRepository == null)
                    _shopRepository = new ShopRepository(_db, _mapper);
                return _shopRepository;
            }
        }

        public IWarehouseRepository WarehouseRepository
        {
            get
            {
                if (_warehouseRepository == null)
                    _warehouseRepository = new WarehouseRepository(_db, _mapper);
                return _warehouseRepository;
            }
        }


    }
}
