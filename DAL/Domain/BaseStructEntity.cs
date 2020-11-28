using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Базовый класс для структурных доменных моделей.
    /// </summary>
    public abstract class BaseStructEntity : BaseEntity
    {
        /// <summary>
        /// Атрибут удаления записи.
        /// </summary>
        [Required]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Дата создания записи.
        /// </summary>
        [Required]
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата изменения записи.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Дата удаления записи.
        /// </summary>
        public DateTime Deleted { get; set; }
    }
}