using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Application Started...\n");

        // Cancellation Token
        CancellationTokenSource cts = new CancellationTokenSource();

        // Progress Reporter
        Progress<string> progress = new Progress<string>(message =>
        {
            Console.WriteLine($"[PROGRESS] {message}");
        });

        try
        {
            // Run all tasks together
            Task<string> apiTask = FetchUserDataAsync(progress, cts.Token);
            Task databaseTask = SaveToDatabaseAsync(progress, cts.Token);
            Task reportTask = GenerateReportAsync(progress, cts.Token);

            // Wait for all tasks
            await Task.WhenAll(apiTask, databaseTask, reportTask);

            // Get result from API task
            string userData = await apiTask;

            Console.WriteLine($"\nUser Data: {userData}");

            Console.WriteLine("\nAll operations completed successfully!");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("\nOperation was cancelled.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }

        Console.WriteLine("\nApplication Finished.");
    }

    // Fetch Data from API
    static async Task<string> FetchUserDataAsync(
        IProgress<string> progress,
        CancellationToken token)
    {
        progress.Report("Fetching user data from API...");

        await Task.Delay(3000, token);

        progress.Report("API data fetched successfully.");

        return "Nazmul Hoque";
    }

    // Save Data to Database
    static async Task SaveToDatabaseAsync(
        IProgress<string> progress,
        CancellationToken token)
    {
        progress.Report("Saving data to database...");

        await Task.Delay(2000, token);

        progress.Report("Database save completed.");
    }

    // Generate Report File
    static async Task GenerateReportAsync(
        IProgress<string> progress,
        CancellationToken token)
    {
        progress.Report("Generating report file...");

        await Task.Delay(4000, token);

        progress.Report("Report generated successfully.");
    }
}