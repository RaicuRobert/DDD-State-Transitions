using StateTransitions.Aggregates.FreelancerAggregate;
using StateTransitions.Aggregates.JobAggregate;
using StateTransitions.Aggregates.JobOfferAggregate;
using StateTransitions.Aggregates.JobOfferAggregate.CommonTransitions;
using StateTransitions.Aggregates.JobPostAggregate;
using StateTransitions.Aggregates.JobPosterAggregate;

namespace StateTransitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companyName = new JobPosterName() { Value = "Company1" };
            var companyJobPoster = new JobPoster(companyName);

            var freelancerName = new FreelancerName() { Value = "Name1" };
            var freelancer = new Freelancer(freelancerName);

            var jobName = new JobPostName() { Value = "Job1" };
            var job = new JobPost(jobName, companyJobPoster);

            var jobOffer = new JobOfferProposedByFreelancer(job, freelancer);
            var acceptedJobOffer = jobOffer.Accept(companyJobPoster);
            var pendingCompletionJobOffer = acceptedJobOffer.MarkAsPendingCompletion(freelancer);
            var retractedJobOffer = (pendingCompletionJobOffer as IJobOfferRetractableByFreelancer).MarkAsRetracted(freelancer);

            // retractedJobOffer has no other transitions
        }
    }
}