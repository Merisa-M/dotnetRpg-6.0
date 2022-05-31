using AutoMapper;
using dotnetRpg.Dtos.Character;
using dotnetRpg.Dtos.Fight;
using dotnetRpg.Dtos.Skill;
using dotnetRpg.Dtos.Weapon;
using dotnetRpg.Models;

namespace dotnetRpg.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
    }
}
