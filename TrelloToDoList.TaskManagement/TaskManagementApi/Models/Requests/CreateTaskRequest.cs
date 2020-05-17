namespace TaskManagementApi.Models.Requests
{
    /// <summary>
    /// Create task request
    /// </summary>
    public class CreateTaskRequest
    {
        /// <summary>
        /// Create task request.
        /// </summary>
        /// <param name="title">Title.</param>
        /// <param name="description">Description.</param>
        public CreateTaskRequest(
            string title, 
            string description)
        {
            Title = title;
            Description = description;
        }

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
