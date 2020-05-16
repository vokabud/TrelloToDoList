﻿namespace TaskManagementApi.Models
{
    /// <summary>
    /// Task.
    /// </summary>
    public class TaskItem
    {
        /// <summary>
        /// Task id.
        /// </summary>
        public string Id { get; set; }

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
