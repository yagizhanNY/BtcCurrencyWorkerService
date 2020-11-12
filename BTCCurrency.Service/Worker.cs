using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiClient.Library;
using HtmlAgilityPack;
using Mail.Library;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PercentCheck.Library;

namespace BTCCurrency.Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        BlockchainApiClient apiClient;
        ChangeAnalyzer changeAnalyzer;
        MailManager mailManager;
        double currentValue;
        double pastValue;
        bool send = false;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            apiClient = new BlockchainApiClient();
            changeAnalyzer = new ChangeAnalyzer();
            mailManager = new MailManager();
            currentValue = 0;
            pastValue = 0;
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    currentValue = apiClient.GetCurrentCurrency("TRY");
                    _logger.LogInformation(currentValue.ToString(), DateTimeOffset.Now);

                    if (pastValue == 0)
                    {
                        pastValue = currentValue;
                    }
                    else
                    {
                        send = changeAnalyzer.AnalyzeChange(currentValue, pastValue, Convert.ToDouble(ConfigurationManager.AppSettings.Get("percent")));

                        if (send)
                        {
                            List<string> mailList = new List<string>();
                            mailList = ConfigurationManager.AppSettings.Get("mailtolist").Split(',').ToList();
                            mailManager.SendMail(currentValue, mailList, ConfigurationManager.AppSettings.Get("username"), ConfigurationManager.AppSettings.Get("password"));
                            pastValue = currentValue;
                            send = false;
                        }
                    }

                    _logger.LogInformation(currentValue.ToString() + " | " + pastValue.ToString(), DateTimeOffset.Now);

                    await Task.Delay(30000, stoppingToken);
                }
                catch(Exception ex)
                {
                    _logger.LogInformation(ex.ToString(), DateTimeOffset.Now);
                }  
            }
        }
    }
}
