using DevApiHobby.Models;
using DevApiHobby.Repositorys.Models;

namespace DevApiHobby.Repositorys.Interface
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetListMemberAsync();
    }
}