using TaskScheduler.Models;

namespace TaskScheduler.Interfaces
{
    public interface IJobService
    {
        Task TriggerJobToggle(JobNames jobType);
    }
}
