﻿using DrillShopApi.DAL.Contexts;
using DrillShopApi.DAL.Domain;
using DrillShopApi.Models.DTO;
using DrillShopApi.Repositories.Interfaces;
using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DrillShopApi.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями "Сверло".
    /// </summary>
    public class DrillRepository : BaseRepository<DrillDto, Drill>, IDrillRepository
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="DrillRepository"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        public DrillRepository(DrillShopContext context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<Drill> DefaultIncludeProperties(DbSet<Drill> dbSet)
        {
            return DbSet.Include(x => x.Provider);
        }
    }
}
