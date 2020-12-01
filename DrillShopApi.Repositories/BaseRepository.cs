using DrillShopApi.Repositories.Interfaces.CRUD;
using DrillShopApi.Models.DTO;
using DrillShopApi.DAL.Domain;
using DrillShopApi.DAL.Contexts;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Collections.Generic;


namespace DrillShopApi.Repositories
{
    /// <summary>
    /// Базовый класс репозитория для работы с CRUD.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Доменная модель.</typeparam>
    public abstract class BaseRepository<TDto, TModel> : ICrudRepository<TDto, TModel>
        where TDto : BaseDto
        where TModel : BaseEntity
    {
        private readonly IMapper _mapper;
        protected readonly DrillShopContext Context;
        protected DbSet<TModel> DbSet => Context.Set<TModel>();

        /// <summary>
        /// Инициализирует экземпляр <see cref="BaseRepository{TDto, TModel}"/>.
        /// </summary>
        /// <param name="context">Контекст данных.</param>
        /// <param name="mapper">Маппер.</param>
        protected BaseRepository(DrillShopContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        /// <inheritdoc cref="ICreatable{TDto, TModel}.CreateAsync(TDto)"/>.
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<TModel>(dto);
            await DbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return await GetAsync(entity.Id);
        }

        /// <inheritdoc cref="IDeletable{TDto, TModel}.DeleteAsync(long[])"/>.
        public async Task DeleteAsync(params long[] ids)
        {
            var entities = await DbSet
                                .Where(x => ids.Contains(x.Id))
                                .ToListAsync();

            Context.RemoveRange(entities);
            await Context.SaveChangesAsync();
        }

        /// <inheritdoc cref="IGettableById{TDto, TModel}.GetAsync(long)"/>.
        public async Task<TDto> GetAsync(long id)
        {
            var entity = await DbSet
                              .AsNoTracking()
                              .FirstOrDefaultAsync(x => x.Id == id);

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        /// <inheritdoc cref="IUpdatable{TDto, TModel}.UpdateAsync(TDto, CancellationToken)"/>
        public async Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default)
        {
            var entity = _mapper.Map<TModel>(dto);
            Context.Update(entity);
            await Context.SaveChangesAsync(token);
            var newEntity = await GetAsync(entity.Id);

            return _mapper.Map<TDto>(newEntity);
        }

        /// <inheritdoc cref="IGettable{TDto, TModel}.GetAsync(CancellationToken)"/>
        public async Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default)
        {
            var entities = await DbSet.AsNoTracking().ToListAsync();

            var dtos = _mapper.Map<IEnumerable<TDto>>(entities);

            return dtos;
        }
    }
}
