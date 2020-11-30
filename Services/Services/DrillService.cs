using System;
using System.Collections.Generic;
using System.Text;
using DrillShopApi.Models.DTO;
using DAL.Mocks;
using DrillShopApi.DAL.Contexts;
using DrillShopApi.DAL.Domain;
using DrillShopApi.Services.Interfaces;
using AutoMapper;

namespace DrillShopApi.Services.Services
{
    // <summary>
    /// Сервис для работы с данными о сверлах.
    /// </summary>
    public class DrillService : IDrillService
    {

        private readonly IMapper _mapper;
        private readonly DrillShopContext _context;

        /// <summary>
        /// Конструктор для сервиса.
        /// </summary>
        /// <param name="context">Контекст.</param>
        /// <param name="mapper">Маппер.</param>
        public DrillService(DrillShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <inheritdoc cref="IDrillService"/>.
        public IEnumerable<DrillDto> Get()
        {
            //var dresses = DrillMock.GetDrill();
            //var response = _mapper.Map<IEnumerable<DrillDto>>(dresses);
            //return response;

            var provider = new Provider
            {
                Id = 1,
                Name = "BOSCH",
                Address = "ул. Ленина, д. 3",
                City = "Ульяновск",
                CreatedDateTimeOffset = DateTime.Now,
                IsDeleted = false
            };

            //var drills = DrillMock.GetDrill();

            var drill = new Drill
            {
                Id = 1,
                ArtCode = "123",
                Description = "Сверло спиральное",
                MaxDiametr = 20.0,
                MinDiametr = 1.2,
                Provider = provider,
                CreatedDateTimeOffset = DateTime.Now,
                IsDeleted = false,
                Weight = 0.01
            };

            var shop = new Shop
            {
                Name = "Мир инструмента",
                Address = "ул. Ленина, д. 31",
                City = "Ульяновск",
                CreatedDateTimeOffset = DateTime.Now,
                IsDeleted = false,
                Telephone = "8 800 00 00 00"
            };

            var warehouse = new Warehouse
            {
                Name = "Cклад №1",
                Address = "ул. Ленина, д. 32",
                City = "Ульяновск",
                CreatedDateTimeOffset = DateTime.Now,
                IsDeleted = false,
                Area = 100,
                Capacity = 40000
            };

            var shopAvail = new ShopAvailability
            {
                Shop = shop,
                Drill = drill,
                Count = 10
            };

            var whAvail = new WHAvailability
            {
                Warehouse = warehouse,
                Drill = drill,
                Count = 15
            };

            _context.Providers.Add(provider);
            _context.Drills.Add(drill);
            _context.Shops.Add(shop);
            _context.Warehouses.Add(warehouse);
            _context.ShopAvailabilities.Add(shopAvail);
            _context.WHAvailabilities.Add(whAvail);

            _context.SaveChanges();
            return _mapper.Map<IEnumerable<DrillDto>>(_context.Drills);
        }

    }
}
