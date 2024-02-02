﻿using System;
namespace SocialMedia.Domain.Aggregates.PostAggregate
{
	public class PostComment
	{
		private PostComment()
		{

		}
		public Guid CommentId { get; private set; }

		public Guid PostId { get; private set; }

		public string? Text { get; private set; }

		public Guid UserProfileId { get; private set; }

		public DateTime DateCreated { get; private set; }

		public DateTime LastModified { get; private set; }

		// Factory method

		public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId)
		{
			var postComment = new PostComment
			{
				PostId = postId,
				Text = text,
				UserProfileId = userProfileId,
				DateCreated = DateTime.UtcNow,
				LastModified = DateTime.UtcNow
			};

			return postComment;
		}

		public void UpdateCommentText(string newText)
		{
			Text = newText;
			LastModified = DateTime.UtcNow;
		}

	}
}

