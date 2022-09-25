using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobPostAggregate;
using StateTransitions.Exceptions;
using StateTransitions.Seedwork;

namespace StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState
{
    public abstract class JobOfferData: Entity, IJobOfferData
    {
        public JobOfferData(JobPost job, Freelancer freelancer, int id = default)
        {
            Id = id;

            Job = job ?? throw new DomainException("A job offer requires a job");
            Freelancer = freelancer ?? throw new DomainException("A job offer requires a freelancer");
        }

        public JobOfferData(IJobOfferData jobOffer)
             : this(jobOffer.Job, jobOffer.Freelancer, jobOffer.Id)
        { }

        public JobPost Job { get; init; }
        public Freelancer Freelancer { get; init; }
    }
}
