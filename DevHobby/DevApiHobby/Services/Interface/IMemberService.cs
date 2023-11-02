using DevApiHobby.Services.Dtos;

namespace DevApiHobby.Services.Interface
{
    public interface IMemberService
    {
        public Task<IEnumerable<MemberDto>> GetUsersAsync();
    }
}