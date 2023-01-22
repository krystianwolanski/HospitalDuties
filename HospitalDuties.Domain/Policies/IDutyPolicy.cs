using HospitalDuties.Domain.Entities;

namespace HospitalDuties.Domain.Policies
{
    public interface IDutyPolicy
    {
        bool CanAddDuty(Duty duty, IEnumerable<Duty> duties);
    }
}