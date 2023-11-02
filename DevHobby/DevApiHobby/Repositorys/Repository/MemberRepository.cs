using DevApiHobby.Models;
using DevApiHobby.Repositorys.Interface;
using DevApiHobby.Repositorys.Models;
using Microsoft.EntityFrameworkCore;

namespace DevApiHobby.Repositorys.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly _94hobbyContext _HobbyContext;

        public MemberRepository(_94hobbyContext HobbyContext)
        {
            _HobbyContext = HobbyContext;
        }

        public async Task<IEnumerable<Member>> GetListMemberAsync()
        {

            var result = await _HobbyContext.Members.ToListAsync();

            return (IEnumerable<Member>)result;
        }
    }
}