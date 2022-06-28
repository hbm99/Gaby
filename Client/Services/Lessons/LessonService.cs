using Gaby.Client.Services.SharedServices;
using Gaby.Shared.Model;
using Gaby.Shared.Pager;

namespace Gaby.Client.Services.Lessons
{
    public class LessonService : ILessonService
    {
        private IHttpService _httpService;
        public LessonService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task AddLesson(Lesson lesson)
        {
            await _httpService.Post($"api/lesson", lesson);
        }

        public async Task DeleteLesson(Lesson lesson)
        {
            await _httpService.Put($"api/lesson", lesson);
        }

        public async Task<Lesson> GetLesson(int id, string coachId)
        {
            return await _httpService.Get<Lesson>($"api/lesson/key");
        }

        public async Task<PagedResult<Lesson>> GetLessons(string page)
        {
            return await _httpService.Get<PagedResult<Lesson>>("api/lesson" + "?page=" + page );
        }
    }
}
