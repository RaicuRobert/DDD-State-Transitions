using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Aggregates.JobPosterAggregate;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferPendingCompletion : JobOfferData, IJobOfferRetractableByFreelancer, IJobOfferRetractableByPoster, IJobOfferFailable
    {
        public JobOfferPendingCompletion(JobOfferOngoing jobOffer)
            : base(jobOffer)
        { }

        public JobOfferOngoing DenyCompletion(JobPoster poster)
        {
            if (poster != Job.JobPoster)
            {
                throw new DomainException("Only the job poster that created the job deny the completion of the offer");
            }

            return new JobOfferOngoing(this);
        }

        public JobOfferCompleted ConfirmCompletion(JobPoster poster)
        {
            if (poster != Job.JobPoster)
            {
                throw new DomainException("Only the job poster that created the job deny the completion of the offer");
            }

            return new JobOfferCompleted(this);
        }
    }
}
