using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Aggregates.JobPostAggregate;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public sealed class JobOfferProposedByPoster : JobOfferData, IJobOfferRetractableByPoster
    {
        public JobOfferProposedByPoster(JobPost job, Freelancer freelancer)
            : base(JobOfferStatus.ProposedByPoster, job, freelancer)
        { }

        public JobOfferOngoing Accept(Freelancer freelancer)
        {
            if (freelancer != Freelancer)
            {
                throw new DomainException("Only the freelancer that applied for the job can accept the offer");
            }

            return new JobOfferOngoing(this);
        }
    }
}
