namespace HospitalDuties.Domain.ValueObjects
{
    public sealed record Specialty(string Value)
    {
        public const string Surgeon = nameof(Surgeon);

        public static implicit operator string(Specialty specialty)
            => specialty.Value;

        public static implicit operator Specialty(string value)
            => new(value);
    }
}