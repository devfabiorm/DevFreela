using DevFreela.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommandHandler : IRequestHandler<FinishProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectrepository;

        public FinishProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectrepository = projectRepository;
        }

        public async Task<Unit> Handle(FinishProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectrepository.GetByIdAsync(request.Id);

            project.Finish();
            await _projectrepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
