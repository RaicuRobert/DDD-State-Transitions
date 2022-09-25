using StateTransitions.Aggregates.JobAggregate;
using StateTransitions.Aggregates.JobOfferAggregate;
using StateTransitions.Exceptions;
using StateTransitions.Seedwork;

namespace StateTransitions.Aggregates.FreelancerAggregate
{
    public sealed class Freelancer: Entity
    {
        public Freelancer(FreelancerName name) {
            Name = name ?? throw new DomainException("A freelancer requires a name");
        }

        public FreelancerName Name { get; }
    }
}
