using Family.Domain.Entities;

namespace Family.Domain.Repositories.Abstractions;

public interface IFamilyMemberRepository : IRepository<FamilyMember>
{
    public Task<IEnumerable<FamilyMember>> GetAllMembersByFamilyIdAsync(long familyId);
}