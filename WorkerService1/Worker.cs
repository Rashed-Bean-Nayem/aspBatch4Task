using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
       
        private readonly string _url;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _url = "https://www.dsebd.org/latest_share_price_scroll_l.php";
        }
       
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
               
                var doc = GetHtmlDocument(_url);
          
                var table = doc.DocumentNode.SelectNodes("//table[@class='table table-bordered background-white shares-table fixedHeader']//td")/*.Where(x => x.InnerText)*/;

                int count = 1;
                

                var newCompany = new DSCompany { };
                foreach (var item in table)
                {
                    
                    if (count==1)
                    {
                        newCompany.Cid = item.InnerText;
                        count++;
                    }
                    else if (count == 2)
                    {
                        newCompany.TradingCODE = item.InnerText;
                        count++;
                    }
                    else if (count == 3)
                    {
                        newCompany.Ltp = item.InnerText;
                        count++;
                    }
                    else if (count == 4)
                    {
                        newCompany.High = item.InnerText;
                        count++;
                    }
                    else if (count == 5)
                    {
                        newCompany.Low = item.InnerText;
                        count++;
                    }
                    else if (count == 6)
                    {
                        newCompany.Closep = item.InnerText;
                        count++;
                    }
                    else if (count == 7)
                    {
                        newCompany.Ycp= item.InnerText;
                        count++;
                    }
                    else if (count == 8)
                    {
                        newCompany.Change = item.InnerText;
                        count++;
                    }
                    else if (count == 9)
                    {
                        newCompany.Trade = item.InnerText;
                        count++;
                    }
                    else if (count == 10)
                    {
                        newCompany.Value = item.InnerText;
                        count++;
                    }
                    else if (count == 11)
                    {
                        newCompany.Volume = item.InnerText;

                        if (count == 11)
                        {
                            AddCompany(newCompany);
                            count = 1;
                            newCompany = new DSCompany();
                        }
                    }

                 

                }
                _logger.LogInformation($"Worker Ending at: {DateTimeOffset.Now}");

                await Task.Delay(55000, stoppingToken);
            }
        }
        public void AddCompany(DSCompany newCompany)
        {
           
            var context = new FrameworkContext();

            context.company.Add(newCompany);
            context.SaveChanges();
            context.Dispose();
        }
        public HtmlDocument GetHtmlDocument(string url)
        {
            using(var client=new WebClient())
                
            {
                var html = client.DownloadString(url);
                var doc = new HtmlDocument();
                doc.LoadHtml(html);
                return doc;
            }
        }
    }
}