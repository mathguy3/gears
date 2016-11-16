namespace GEARS.Models
{
    public class DueDateTime
    {
        public int DueDate, DueTime, GradDueDate, GradDueTime;

        public DueDateTime()
        {
        }

        public DueDateTime(int dueDate, int dueTime, int gradDueDate, int gradDueTime)
        {
            DueDate = dueDate;
            DueTime = dueTime;
            GradDueDate = gradDueDate;
            GradDueTime = gradDueTime;
        }
    }
}