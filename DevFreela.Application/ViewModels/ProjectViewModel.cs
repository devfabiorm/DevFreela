﻿using System;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title, DateTime createdAt, int id)
        {
            Id = id;
            Title = title;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}