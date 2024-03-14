using System.ComponentModel.DataAnnotations;

namespace QLSV_APP.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string StudentCode { get; set; }

        public string DateOfBirth { get; set; }

        public string ExamResult { get ; set ;}

        public string HomeTown { get; set; }
        public string Description { get; set; }

        public string Aspiration { get; set; }
    }
}
