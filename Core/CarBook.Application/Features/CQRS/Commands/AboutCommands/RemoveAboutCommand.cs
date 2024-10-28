﻿namespace CarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public int AboutId { get; set; }

        public RemoveAboutCommand(int id)
        {
            AboutId = id;
        }
    }
}