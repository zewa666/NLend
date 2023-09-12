using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorBootstrap;
using BlazorState;
using System.Reflection;
using MediatR;
using static BlazorState.Pipeline.ReduxDevTools.ReduxDevToolsOptions;
using NLendApp.Features.Shareables;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<NLendApp.Main>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorState
(
	(aOptions) =>
	{
		aOptions.UseReduxDevTools();
		aOptions.Assemblies = new Assembly[]
		{
			typeof(Program).GetTypeInfo().Assembly,
		};
	}
);

builder.Services.AddScoped<IShareableService, ShareableService>();
//builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(Features.EventStream.EventStreamBehavior<,>));


await builder.Build().RunAsync();
