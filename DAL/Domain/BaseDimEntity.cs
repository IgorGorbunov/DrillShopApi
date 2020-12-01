using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrillShopApi.DAL.Domain
{
    /// <summary>
    /// Базовый класс для сущностных доменных моделей.
    /// </summary>
    public abstract class BaseDimEntity : BaseEntity
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
        public DateTimeOffset CreatedDateTimeOffset { get; set; }

        /// <summary>
        /// Дата изменения записи.
        /// </summary>
        public DateTimeOffset ModifiedDateTimeOffset { get; set; }

        /// <summary>
        /// Дата удаления записи.
        /// </summary>
        public DateTimeOffset DeletedDateTimeOffset { get; set; }
    }
}