namespace HospitalDuties.Domain.ValueObjects
{
    public sealed record JobTitle(string Value)
    {
        public const string Doctor = nameof(Doctor);
        public const string Nurse = nameof(Nurse);

        public static implicit operator string(JobTitle jobTitle)
            => jobTitle.Value;

        public static implicit operator JobTitle(string value)
            => new(value);
    }
}