namespace LİNQ_GRUP_JOİN
{
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }

        public Students(int _studentId, string _studentName, int _classId)
        {
            StudentId = _studentId;
            StudentName = _studentName;
            ClassId = _classId;

        }
    }
}
