using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Aggregates.JobPostAggregate;
using StateTransitions.Aggregates.JobPosterAggregate;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferProposedByFreelancer : JobOfferData, IJobOfferRetractableByFreelancer
    {
        public JobOfferProposedByFreelancer(JobPost job, Freelancer freelancer)
           : base(jobOffer)
        { }

        public JobOfferOngoing Accept(JobPoster poster)
        {
            if (poster != Job.JobPoster)
            {
                throw new DomainException("Only the job poster that created the job can accept the offer");
            }

            return new JobOfferOngoing(this);
        }
    }
}
