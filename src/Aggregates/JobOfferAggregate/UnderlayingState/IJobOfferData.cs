using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobPostAggregate;
using StateTransitions.Seedwork;

namespace StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState
{
    public interface IJobOfferData: IEntity
    {
        public JobPost Job { get; }
        public Freelancer Freelancer { get; }
    }
}
