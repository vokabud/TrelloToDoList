namespace TaskManagementApi.Database.Entities
{
    [BsonCollection("tasks")]
    public class TaskEntity : BaseEntity
    {
        /// <summary>
        /// Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }
    }
}
