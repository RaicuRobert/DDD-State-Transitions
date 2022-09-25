using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions
{
    public interface IJobOfferRetractableByFreelancer : IJobOfferData
    {
        public JobOfferRetracterByFreelancer MarkAsRetracted(Freelancer freelancer)
        {
            if (freelancer != Freelancer)
            {
                throw new DomainException("Only the freelancer that applied for the job can accept the offer");
            }

            return new JobOfferRetracterByFreelancer(this);
        }
    }
}
