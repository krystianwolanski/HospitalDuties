using HospitalDuties.Domain.Entites;

namespace HospitalDuties.Domain.Entities
{
    public class Duty
    {
        public DateOnly Date { get; }
        public Employee Employee { get; }
        public int Id { get; }
    }
}