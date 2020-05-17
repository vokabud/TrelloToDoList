namespace TaskManagementApi.Models.Responses
{
    /// <summary>
    /// Task response.
    /// </summary>
    public class TaskResponse
    {
        /// <summary>
        /// Task response.
        /// </summary>
        /// <param name="id">Task id.</param>
        /// <param name="title">Title.</param>
        /// <param name="description">Description.</param>
        public TaskResponse(
            string id, 
            string title, 
            string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        /// <summary>
        /// DB task id.
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
