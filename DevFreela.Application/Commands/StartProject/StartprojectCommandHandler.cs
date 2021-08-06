using Dapper;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartprojectCommandHandler : IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;

        public StartprojectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.GetByIdAsync(request.Id);

            project.Start();

            await _projectRepository.StartAsync(project);

            return Unit.Value;
        }
    }
}
