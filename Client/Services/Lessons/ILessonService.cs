﻿using Gaby.Shared.Pager;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Lessons
{
    public interface ILessonService
    {
        Task<PagedResult<Lesson>> GetLessons(string page);
        Task<Lesson> GetLesson(int id, string coachId);

        Task DeleteLesson(Lesson lesson);

        Task AddLesson(Lesson lesson);
    }
}