using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Aggregates.JobPosterAggregate;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions
{
    public interface IJobOfferRetractableByPoster : IJobOfferData
    {
        public JobOfferRetractedByPoster MarkAsRetracted(JobPoster jobPoster)
        {
            if (jobPoster != Job.JobPoster)
            {
                throw new DomainException("Only the job poster that created the job can accept the offer");
            }

            return new JobOfferRetractedByPoster(this);
        }
    }
}
