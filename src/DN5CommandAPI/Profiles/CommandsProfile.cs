using AutoMapper;
using DN5CommandAPI.Dtos;
using DN5CommandAPI.Models;

namespace DN5CommandAPI.Profiles
{
    public class CommandsProfile: Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}