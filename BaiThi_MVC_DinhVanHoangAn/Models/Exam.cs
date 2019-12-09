using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiThi_MVC_DinhVanHoangAn.Models
{
    public class Exam
    {
        public int? Id { get; set; }
        public int ExamSubject { get; set; }
        public string ExamSubjectName { get; set; }
        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Required]
        public TimeSpan StartTime { get; set; }
        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        public int ExamDuration { get; set; }
        public int ClassRoom { get; set; }
        public string ClassRoomName { get; set; }
        public int Faculty { get; set; }
        public string FacultyName { get; set; }
        public StatusType Status { get; set; }

        public enum StatusType { Done = 1, UpComing = 2, OnGoing = 3 }
    }
}