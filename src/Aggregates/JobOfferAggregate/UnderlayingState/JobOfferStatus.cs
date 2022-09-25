namespace StateTransitions.Aggregates.JobOfferAggregate.UnderlayingState
{
    public enum JobOfferStatus
    {
        ProposedByFreelancer,
        ProposedByPoster,
        Ongoing,
        PendingCompletion,
        Completed,
        Failed,
        RetractedByFreelancer,
        RetractedByPoster
    }
}
