using System.Threading.Tasks;

namespace BlazorShop.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}