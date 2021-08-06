using DevFreela.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(int id);
        Task CreateCommentAssync(ProjectComment comment);
        Task CreateAsync(Project project);
        Task SaveChangesAsync();
        Task StartAsync(Project project);
    }
}
