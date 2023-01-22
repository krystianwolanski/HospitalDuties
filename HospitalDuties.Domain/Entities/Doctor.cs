using HospitalDuties.Domain.ValueObjects;

namespace HospitalDuties.Domain.Entites
{
    internal class Doctor : Employee
    {
        public Specialty Specialty { get; }
    }
}