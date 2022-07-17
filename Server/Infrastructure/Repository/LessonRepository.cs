using Gaby.Shared.Model;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;


namespace Gaby.Server.Infrastructure.Repository
{
    public class LessonRepository : ILessonRepository
    {
        protected readonly GabyDbContext context;

        public LessonRepository(GabyDbContext context)
        {
            this.context = context;
        }

        public async Task<Lesson> Add(Lesson entity)
        {
            var coach = context.Coaches
                .FirstOrDefault(c => c.EmployeeId == entity.Coach.EmployeeId);
            entity.Coach = coach;

            var service = context.Services
                .Where(c => c.ServiceId == entity.Service.ServiceId).Include(x => x.ServiceType);
            entity.Service = service.ToArray()[0];


            var result = await context.Lessons.AddAsync(entity);
            await context.SaveChangesAsync();
            return result.Entity;
        }


        public Task<IEnumerable<Lesson>> AddRange(IEnumerable<Lesson> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lesson> Find(string? expression)
        {
            throw new NotImplementedException();
        }

        public PagedResult<Lesson> GetAll([FromQuery] int page)
        {
            int pageSize = 10;

            return context.Lessons
                .Where(p => p.Active)
                .Include(x => x.Service)
                .Include(a => a.Service.ServiceType)
                .Include(y => y.Coach)
                .GetPaged(page, pageSize);
        }

        public IList<Lesson> GetById(int serviceId, string coachId)
        {
            var result = context.Lessons
                .Where(lesson => lesson.Active && lesson.ServiceId == serviceId && lesson.CoachId == coachId)
                .Include(lesson => lesson.Coach)
                .Include(lesson => lesson.Service)
                .Include(lesson => lesson.Service.ServiceType)
                .ToList();
                //.Include(x => x.Service.ServiceType)
                //.FirstOrDefaultAsync(x => x.ServiceId == serviceId && x.CoachId == coachId && x.Service.Active && x.Coach.Active);
            return result;
        }

        public Task Remove(Lesson entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRange(IEnumerable<Lesson> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<Lesson?> Update(Lesson entity)
        {
            var result = context.Lessons.First(p => p == entity);
            if (result != null)
            {
                // Update existing entity
                context.Entry(result).CurrentValues.SetValues(entity);

                await context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Lesson not found");
            }

            return entity;
        }
    }
}