using System;
using System.Collections.Generic;
using System.Text;
using DrillShopApi.Models.DTO;

namespace DrillShopApi.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для работы с данными о сверлах.
    /// </summary>
    public interface IDrillService
    {
        IEnumerable<DrillDto> Get();
    }

}
