﻿using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState;
using StateTransitions.Exceptions;

namespace StateTransitions.Aggregates.JobOfferAggregate
{
    public class JobOfferOngoing : JobOfferData, IJobOfferRetractableByFreelancer, IJobOfferRetractableByPoster, IJobOfferFailable
    {
        public JobOfferOngoing(JobOfferProposedByFreelancer jobOffer) 
            : base(JobOfferStatus.Ongoing, jobOffer.Job, jobOffer.Freelancer, jobOffer.Id)
        { }

        public JobOfferOngoing(JobOfferProposedByPoster jobOffer)
            : base(JobOfferStatus.Ongoing, jobOffer.Job, jobOffer.Freelancer, jobOffer.Id)
        { }

        public JobOfferOngoing(JobOfferPendingCompletion jobOffer)
            : base(JobOfferStatus.Ongoing, jobOffer.Job, jobOffer.Freelancer, jobOffer.Id)
        { }

        public JobOfferPendingCompletion MarkAsPendingCompletion(Freelancer freelancer) {
            if (freelancer != Freelancer)
            {
                throw new DomainException("Only the freelancer that applied for the job can mark it as pending completion");
            }

            return new JobOfferPendingCompletion(this);
        }
    }
}
