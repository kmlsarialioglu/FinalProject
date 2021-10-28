namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public long UserOperationClaimId { get; set; }
        public long UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}