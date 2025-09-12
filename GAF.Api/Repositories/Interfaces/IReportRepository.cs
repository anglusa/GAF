namespace GAF.Api.Repositories.Interfaces

public interface IReportRepository
{
    Task<Report> GetMonthlyReportAsync(string userId, int month, int year);
    Task<IEnumerable<Report>> GetYearlyReportAsync(string userId, int year);
    Task<Report> CreateOrUpdateMonthlyReportAsync(Repositories report);      
}
