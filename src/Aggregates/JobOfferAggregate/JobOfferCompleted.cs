using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferCompleted : JobOfferData
    {
        public JobOfferCompleted(JobOfferPendingCompletion jobOffer)
            : base(JobOfferStatus.Completed, jobOffer.Job, jobOffer.Freelancer, jobOffer.Id)
        { }
    }
}
