namespace TaskManagementApi.Models.Requests
{
    /// <summary>
    /// Update task request
    /// </summary>
    public class UpdateTaskRequest
    {
        /// <summary>
        /// Update task request.
        /// </summary>
        /// <param name="id">Task id.</param>
        /// <param name="title">Title.</param>
        /// <param name="description">Description.</param>
        public UpdateTaskRequest(
            string id, 
            string title, 
            string description)
        {
            Id = id;
            Title = title;
            Description = description;
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
    }
}
