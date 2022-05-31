using dotnetRpg.Dtos.Character;
using dotnetRpg.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnetRpg.Services
{
    public interface ICharacterService
    {
       Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
       Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
       Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
       Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
       Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
       Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}
