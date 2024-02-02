using System;
using SocialMedia.Domain.Aggregates.UserProfileAggregate;

namespace SocialMedia.Domain.Aggregates.PostAggregate
{
	public class Post
	{
		private readonly List<PostComment> _comments = new();

        private readonly List<PostInteraction> _interactions = new();

        private Post()
		{
			
		}

		public Guid PostId { get; private set; }

		public Guid UserProfileId { get; private set; }

		public UserProfile UserProfile { get; private set; }

		public string? TextContent { get; private set; }

		public IEnumerable<PostComment>? Comments { get { return _comments; } }

		public IEnumerable<PostInteraction>? Interaction { get { return _interactions; } }

		public DateTime DateCreated { get; set; }

		public DateTime LastModified { get; set; }

		// Factory methods
		public static Post CreatePost (Guid userProfileId, string textContent)
		{
			var post = new Post
			{
				UserProfileId = userProfileId,
				TextContent = textContent,
				DateCreated = DateTime.UtcNow,
				LastModified = DateTime.UtcNow
			};


			return post;
		}

		// Public Methods

		public void UpdatePostText(string newText)
		{
			TextContent = newText;
			LastModified = DateTime.UtcNow;
		}

		public void AddComment(PostComment newComment)
		{
			_comments.Add(newComment);
		}

		public void RemoveComment (PostComment comment)
		{
			_comments.Remove(comment);
		}

        public void AddInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
        }

        public void RemoveInteraction(PostInteraction interaction)
        {
            _interactions.Remove(interaction);
        }

    }
}

