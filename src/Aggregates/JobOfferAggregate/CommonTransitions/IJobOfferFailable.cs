using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Aggregates.JobPosterAggregate;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions
{
    public interface IJobOfferFailable : IJobOfferData
    {
        public JobOfferFailed MarkAsFailed(JobPoster jobPoster)
        {
            if (jobPoster != Job.JobPoster)
            {
                throw new DomainException("Only the job poster that created the job can mark the offer as failed");
            }

            return new JobOfferFailed(this);
        }
    }
}
