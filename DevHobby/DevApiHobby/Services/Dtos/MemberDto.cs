namespace DevApiHobby.Services.Dtos
{
    public class MemberDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? NickName { get; set; }
        public string? Gender { get; set; }
        public string? Account { get; set; }
        public byte[]? PassWord { get; set; }
    }
}