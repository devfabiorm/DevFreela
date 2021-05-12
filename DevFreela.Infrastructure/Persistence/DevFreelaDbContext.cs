using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projecto ASPNET Core 1", "Minha descrição do projeto 1", 1, 1, 10000),
                new Project("Meu projecto ASPNET Core 2", "Minha descrição do projeto 2", 1, 1, 20000),
                new Project("Meu projecto ASPNET Core 3", "Minha descrição do projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Fabio Ribeiro", "devfabiorm@test.com", new DateTime(1991, 1, 1)),
                new User("Fabricio Castro", "castfabri@test.com", new DateTime(1992, 1, 1)),
                new User("Felipe Silva", "devfabiorm@test.com", new DateTime(1993, 1, 1)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("NodeJS"),
                new Skill("SQL")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
