using HospitalDuties.Domain.Entites;
using HospitalDuties.Domain.Entities;

namespace HospitalDuties.Domain.Policies
{
    public class PolicyContext
    {
        private readonly IDutyPolicy _dutyPolicy;

        public PolicyContext(Employee employee)
        {
            _dutyPolicy = employee is Doctor ? new DoctorDutyPolicy() : new EmployeeDutyPolicy();
        }

        public bool CanAddDuty(Duty duty, IEnumerable<Duty> duties)
        {
            return _dutyPolicy.CanAddDuty(duty, duties);
        }
    }
}