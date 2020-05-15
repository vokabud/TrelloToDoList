namespace TaskManagementApi.Models
{
    /// <summary>
    /// Task.
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskItem"/> class.
        /// </summary>
        /// <param name="id">Task id.</param>
        /// <param name="title">Title.</param>
        /// <param name="description">Description.</param>
        /// <param name="userId">User id.</param>
        public TaskItem(
            string id, 
            string title, 
            string description, 
            string userId)
        {
            Id = id;
            Title = title;
            Description = description;
            UserId = userId;
        }

        /// <summary>
        /// Task id.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// User id.
        /// </summary>
        public string UserId { get; }
    }
}
