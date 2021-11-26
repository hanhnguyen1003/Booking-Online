using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Controllers;

namespace WebApp
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private IServiceScopeFactory _serviceScopeFactory;
        private string connectionString;
        public Worker(ILogger<Worker> logger, IServiceScopeFactory serviceScopeFactory)
        {
            _logger = logger;
            _serviceScopeFactory = serviceScopeFactory;
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            var configuration = _serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IConfiguration>();
            connectionString = configuration.GetConnectionString("Hospital");
            Console.WriteLine(connectionString);
            //var configuration = _serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IConfiguration>();
            //_numberOfDaysBeforeDelete = int.Parse(configuration["App.Configurations:NumberOfDaysBeforeDelete"]);
            //_runIntervallInHours = int.Parse(configuration["App.Configurations:RunIntervallInHours"]);
            //_folderPaths = File.ReadAllLines(configuration["App.Configurations:ConfigurationFilePath"]).Select(x => x.Trim()).ToList();
            Console.WriteLine("goto start");
            using IDbConnection connection = new SqlConnection(connectionString);
            using IDbCommand command = connection.CreateCommand();
            command.CommandText = "RunRenderSchedule";
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            int ret = command.ExecuteNonQuery();
            Console.WriteLine($"RenderSchedule: ret=>{ret}");
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
           

            while (!stoppingToken.IsCancellationRequested)
            {
                //if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                //{
                    using IDbConnection connection = new SqlConnection(connectionString);
                    using IDbCommand command = connection.CreateCommand();
                    command.CommandText = "RunRenderSchedule";
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    int ret = command.ExecuteNonQuery();
                    Console.WriteLine($"RenderSchedule: ret=>{ret}");
                //}

                //_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                //foreach (var path in _folderPaths)
                //{
                //    if (!stoppingToken.IsCancellationRequested)
                //    {
                //        // Get old files
                //        var files = Directory.GetFiles(path).Select(file => new FileInfo(file)).Where(file => file.LastWriteTime < DateTime.Now.AddDays(-1 * _numberOfDaysBeforeDelete)).ToList();

                //        // Delete found files
                //        files.ForEach(file => file.Delete());
                //    }
                //}              

                await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
            }
        }
    }
}
