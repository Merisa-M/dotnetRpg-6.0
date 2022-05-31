using dotnetRpg.Dtos.Character;
using dotnetRpg.Dtos.Weapon;
using dotnetRpg.Models;
using System.Threading.Tasks;

namespace dotnetRpg.Services.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto addWeapon);
    }
}
