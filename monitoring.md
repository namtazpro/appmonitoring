# Working with Azure Monitoring for your Application

## Default deployment
Deploy a WebApp with default values.
- WebApp
- Windows
- .Net Core 3.0
- Standard, small Plan
- NO application insights configured for the app
- NO Diagnostics settings configured for the app

By default, Metrics are available without enabling anthing. There are metrics for the App and metrics available for the Plan. The list is specified in the article [Monitor apps in Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/web-sites-monitor). These are for example, Data In/Out (bandwidth), Requests, memory, CPU etc. Note that for Metric DataIn/Out this is either for the app (Metric in App Service) or for all apps in the Plan (Metric in App Service Plan)

Metrics showing in landing page by default.
![Metrics](/images/appservicedefaultmetrics.png)

You will see Metrics coming through even in Data In/Out even if no apps is deployed