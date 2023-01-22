using HospitalDuties.Domain.Entites;
using HospitalDuties.Domain.Entities;
using HospitalDuties.Domain.ValueObjects;

namespace HospitalDuties.Domain.Policies
{
    public class DoctorDutyPolicy : EmployeeDutyPolicy, IDutyPolicy
    {
        public override bool CanAddDuty(Duty duty, IEnumerable<Duty> duties)
        {
            var doctor = (Doctor)duty.Employee;

            return base.CanAddDuty(duty, duties)
                && !IsThereADoctorWithThisSpecialtyOnDuty(duties, doctor.Specialty, duty.Date);
        }

        private static bool IsThereADoctorWithThisSpecialtyOnDuty(IEnumerable<Duty> duties, Specialty specialty, DateOnly date)
        {
            var dutiesCount = duties
                .Count(d => d.Employee is Doctor doctor
                    && d.Date == date && doctor.Specialty == specialty);

            return dutiesCount >= 1;
        }
    }
}
