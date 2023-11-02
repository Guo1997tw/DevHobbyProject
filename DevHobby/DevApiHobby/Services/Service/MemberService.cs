using DevApiHobby.Repositorys.Interface;
using DevApiHobby.Services.Dtos;
using DevApiHobby.Services.Interface;

namespace DevApiHobby.Services.Service
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<IEnumerable<MemberDto>> GetUsersAsync()
        {
            var getUser = await _memberRepository.GetListMemberAsync();

            var result = getUser.Select(g => new MemberDto
            {
                Id = g.Id,
                Name = g.Name,
                NickName = g.NickName,
                Gender = g.Gender,
                Account = g.Account,
                PassWord = g.PassWord,
            }).ToList();

            return result;
        }
    }
}