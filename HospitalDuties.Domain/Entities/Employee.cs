using HospitalDuties.Domain.ValueObjects;

namespace HospitalDuties.Domain.Entites
{
    public class Employee
    {
        public JobTitle JobTitle { get; }
        public string Pesel { get; }
    }
}