using Family.Application.Models.Base;
using Family.Application.Models.FamilyMember;

namespace Family.Application.Models.Family;

public record FamilyModel : IModel
{
    public long Id { get; init; }
    
    public string FamilyName { get; init; }

    public IList<FamilyMemberModel> FamilyMembers { get; init; }
}