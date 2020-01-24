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

You will see Metrics coming through even in Data In/Out even if no apps is deployed. Requests will start showing as soon as you navigate to the WebApp URL.

## Applications

### ASP .Net Core Web Application MVC
Create an app of this type in your favorite IDE...
![ASP .NetCoreWebApp](/images/aspnetcorewebappmvc.png)
...then publish your app to the WebApp on Azure.
At this point there are no other metrics captured than the initial ones from the WebApp and Plan. There are no specific metrics from your apps that are captured (e.g. page name)

## Application Logs
In case you need to access the logs of the application you can configure access to different logs using the App Service logs page under App Service - Monitoring panel.

![App Service logs](/images/appservicelogs.png)

### Send the WebApp diagnostics settings to a Log Analytics workspace

Configure the Diagnostics settings to be sent to a workspace to start capturing logs from the WebApp. As for every service on Azure that have Diagnostics settings configuration available, each will have its own set of logs it can report on.port
![Configure Diagnostics Settings to your web app](/images/configureloganalytics.png)

### Reference articles
[Web application monitoring on Azure](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/app-service-web-app/app-monitoring)

[Best practices for Autoscale](https://docs.microsoft.com/en-us/Azure/azure-monitor/platform/autoscale-best-practices)

[Monitor Azure App Service performance](https://docs.microsoft.com/en-us/azure/azure-monitor/app/azure-web-apps?tabs=net)