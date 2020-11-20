using System;
using DrillShopApi.DAL.Domain;
using System.Collections.Generic;
using System.Text;

namespace DAL.Mocks
{
    /// <summary>
    /// Mock для коллекции сущностей "Сверло".
    /// </summary>
    public static class DrillMock
    {
        /// <summary>
        /// Получение коллекции сущности "Сверло".
        /// </summary>
        /// <returns>Коллекция сущностей "Сверло".</returns>
        public static IEnumerable<Drill> GetDrill()
        {
            return new List<Drill> {
                new Drill {Id = 1, ArtCode = "123", Description = "Сверло спиральное", MaxDiametr = 20.0, MinDiametr = 1.2},
                new Drill {Id = 2, ArtCode = "1234", Description = "Сверло Форстнера", MaxDiametr = 30.0, MinDiametr = 10.0},
                new Drill {Id = 1, ArtCode = "1235", Description = "Перовое сверло", MaxDiametr = 50.0, MinDiametr = 15.0},
            };
        }
    }
}
