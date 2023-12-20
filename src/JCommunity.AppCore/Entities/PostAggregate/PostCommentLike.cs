﻿namespace JCommunity.AppCore.Entities.PostAggregate
{
    public class PostCommentLike : EntityBase
    {
        public Guid CommentId { get; private set; }
        public Member Author { get; private set; } = null!;
        public Guid AuthorId { get; private set; }
        public bool IsLike { get; private set; }
        public DateTime CreatedOrUpdatedAt { get; protected set; } = SystemTime.now();

        public static PostCommentLike Create(
            Guid authorId,
            bool isLike)
        {
            return new()
            {
                AuthorId = authorId,
                IsLike = isLike
            };
        }

        public void UpdateLike(bool value)
        {
            if(this.IsLike != value)
            {
                this.IsLike = value;
                this.CreatedOrUpdatedAt = SystemTime.now();
            }
        }
    }
}
