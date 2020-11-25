using System;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Сверло.
    /// </summary>
    public class Drill
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Артикул.
        /// </summary>
        public string ArtCode { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Минимальный диаметр.
        /// </summary>
        public double MinDiametr { get; set; }

        /// <summary>
        /// Максимальный диаметр.
        /// </summary>
        public double MaxDiametr { get; set; }

        /// <summary>
        /// Атрибут удаления.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата изменения.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Дата удаления.
        /// </summary>
        public DateTime Deleted { get; set; }
    }
}
