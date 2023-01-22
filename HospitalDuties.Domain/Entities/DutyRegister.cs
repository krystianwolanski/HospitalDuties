using HospitalDuties.Domain.Policies;

namespace HospitalDuties.Domain.Entities
{
    public class DutyRegister
    {
        private readonly List<Duty> _duties = new();

        public void AddDuty(Duty duty)
        {
            var policyContext = new PolicyContext(duty.Employee);

            if (!policyContext.CanAddDuty(duty, _duties))
            {
                throw new Exception();
            }

            _duties.Add(duty);
        }
    }
}