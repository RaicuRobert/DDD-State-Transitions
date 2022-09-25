using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferRetracterByFreelancer : JobOfferData
    {
        public JobOfferRetracterByFreelancer(IJobOfferRetractableByFreelancer jobOffer)
            : base(jobOffer)
        { }
    }
}
