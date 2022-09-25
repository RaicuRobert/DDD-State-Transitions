using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferRetractedByPoster : JobOfferData
    {
        public JobOfferRetractedByPoster(IJobOfferRetractableByPoster jobOffer)
            : base(jobOffer)
        { }
    }
}
