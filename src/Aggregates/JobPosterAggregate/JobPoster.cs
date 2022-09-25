using StateTransitions.Aggregates.JobAggregate;
using StateTransitions.Exceptions;
using StateTransitions.Seedwork;

namespace StateTransitions.Aggregates.JobPosterAggregate
{
    public sealed class JobPoster: Entity
    {
        public JobPoster(JobPosterName name) {
            Name = name ?? throw new DomainException("A job poster requires a name");
        }

        public JobPosterName Name { get; private set; }
    }
}
