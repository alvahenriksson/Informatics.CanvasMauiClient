using System.Reflection;
using Informatics.CanvasMauiClient.Pages;
using Informatics.CanvasMauiClient.Services;
using Informatics.CanvasMauiClient.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Informatics.CanvasMauiClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

			var assembly = Assembly.GetExecutingAssembly();
string appsettingsFileName = "Informatics.CanvasMauiClient.appsettings.json"; using (var stream = assembly.GetManifestResourceStream(appsettingsFileName)) {
if (stream != null)
{
builder.Configuration.AddJsonStream(stream);
} }
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<CoursesViewModel>();
builder.Services.AddSingleton<CoursesPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
