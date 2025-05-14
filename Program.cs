using DevExpress.Data.Filtering;
using DevExpress.XtraReports.Expressions;
using DevExpressReports.Reports;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
