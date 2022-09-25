using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobAggregate
{
    public sealed record JobPosterName
    {
        private string _value = null!;

        public required string Value 
        {
            get => _value;
            init 
            {
                if (string.IsNullOrWhiteSpace(_value) || _value.Length > 50)
                {
                    throw new DomainException("The job poster name is requred and must have a length of maximum 50 characters");
                }

                _value = value;
            }
        }
    }
}
