using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferFailed: JobOfferData
    {
        public JobOfferFailed(IJobOfferFailable jobOffer)
            : base(JobOfferStatus.Failed, jobOffer.Job, jobOffer.Freelancer, jobOffer.Id)
        { }
    }
}
