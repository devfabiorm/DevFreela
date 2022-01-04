using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Commands
{
    public class CreateProjectCommandHandlerTests
    {
        [Fact]
        public async Task ThreeProjectsExist_Executed_ReturnThreeProjectViewModels()
        {
            //Arrange
            var projects = new List<Project>
            {
                new Project("Title 1", "Description 1", 1, 1, 10000),
                new Project("Title 2", "Description 2", 2, 2, 10000),
                new Project("Title 3", "Description 3", 3, 3, 10000)
            };

            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetAllAsync())
                .ReturnsAsync(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery("query");
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoryMock.Object);

            //Act
            var projectViewModelList = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            //Assert
            Assert.NotNull(projectViewModelList);
            Assert.NotEmpty(projectViewModelList);
            Assert.Equal(projects.Count, projectViewModelList.Count);

            projectRepositoryMock.Verify(pr => pr.GetAllAsync(), Times.Once);
        }
    }
}
