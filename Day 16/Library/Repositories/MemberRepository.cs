using Library.Data;
using Library.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.Repositories
{
    internal class MemberRepository
    {
        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;
            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members,
            };
        }

        public GenericResponse<Member> GetMemberById(int id)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Id == id);
            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }

        public GenericResponse<Member> GetMemberByNameAndEmail(string name, string email)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Name == name);
            var memb = DataStore.Members.FirstOrDefault(x => x.Email == email);
            if (member == null && memb == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found",
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member,
            };
        }
    }
}
