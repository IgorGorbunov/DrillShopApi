using System;
using System.Collections.Generic;
using System.Text;
using DrillShopApi.Models.DTO;
using DAL.Mocks;
using Services.Interfaces;
using AutoMapper;

namespace Services.Services
{
    // <summary>
    /// Сервис для работы с данными о сверлах.
    /// </summary>
    class DrillService : IDrillService
    {

        private readonly IMapper _mapper;

        public DrillService(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <inheritdoc cref="IDrillService"/>
        public IEnumerable<DrillDto> GetAsync()
        {
            var dresses = DrillMock.GetDrill();
            var response = _mapper.Map<IEnumerable<DrillDto>>(dresses);
            return response;
        }

    }
}
