using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [MetadataType(typeof(TaskMetadata))]
    public partial class Tasks
    {
    }
    public partial class TaskMetadata
    {
        [DisplayName("Task Id")]
        public int TaskID { get; set; }
        [DisplayName("Task Name")]
        [Required(ErrorMessage = "You Must enter a Name")]
        [MaxLength(50, ErrorMessage = "Name must be 50 letters or less")]
        public string TaskName { get; set; }
        [DisplayName("Task Description")]
        [Required(ErrorMessage = "You must enter a description")]
        [MaxLength(100, ErrorMessage ="You must enter a decription 100 letters or less")]
        public string Description { get; set; }
        [DisplayName("Due Date")]
        [Required(ErrorMessage = "You must enter a due date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyy}")]
        public System.DateTime DueDate { get; set; }

    }
}