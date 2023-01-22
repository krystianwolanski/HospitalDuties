using HospitalDuties.Domain.Entities;

namespace HospitalDuties.Domain.Policies
{
    public class EmployeeDutyPolicy : IDutyPolicy
    {
        private const int _maxDutiesPerMonth = 20;

        public virtual bool CanAddDuty(Duty duty, IEnumerable<Duty> duties)
        {
            var employeeDuties = duties.Where(d => d.Employee.Pesel == duty.Employee.Pesel);

            if (HasDutyOnThisDay(duty.Date, employeeDuties)
                || HasMaxDutiesPerMonth(duty.Date, employeeDuties)
                || IsItDutyTheDayAfterAnother(duty.Date, employeeDuties))
            {
                return false;
            }

            return true;
        }

        private static bool HasDutyOnThisDay(DateOnly date, IEnumerable<Duty> duties)
        {
            return duties.Any(d => d.Equals(date));
        }

        private static bool HasMaxDutiesPerMonth(DateOnly date, IEnumerable<Duty> duties)
        {
            return duties
                .Where(d => d.Date.Equals(date))
                .Count() >= _maxDutiesPerMonth;
        }

        private static bool IsItDutyTheDayAfterAnother(DateOnly date, IEnumerable<Duty> duties)
        {
            return duties.Any(d => d.Date.AddDays(1).Equals(date));
        }
    }
}
