using StateTransitions.Aggregates.JobPosterAggregate;
using StateTransitions.Exceptions;
using StateTransitions.Seedwork;

namespace StateTransitions.Aggregates.JobPostAggregate
{
    public sealed class JobPost : Entity
    {
        public JobPost(JobPostName name, JobPoster jobPoster) { 
            Name = name ?? throw new DomainException("A job requires a name");
            JobPoster = jobPoster ?? throw new DomainException("A job requires a job poster");
        }

        public JobPostName Name { get; private set; }

        public JobPoster JobPoster { get; private set; }
    }
}
