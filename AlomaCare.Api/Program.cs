using System.Text;
using System.Text.Json.Serialization;
using AlomaCare.Data.Repositories;
using AlomaCare.Context;
using AlomaCare.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using AlomaCare.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFungalOrganismRepository, FungalOrganismRepository>();


//Config Cors and then register the pipeline above the authentication pipeline below! NB
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy",builder =>
    {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
    });
});

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IAntimicrobialRepository, AntimicrobialRepository>();
builder.Services.AddScoped<ICongenitalInfectionOrganismRepository, CongenitalInfectionOrganismRepository>();
builder.Services.AddScoped<IFaqRepository, FaqRepository>();
builder.Services.AddScoped<IFungalOrganismRepository, FungalOrganismRepository>();
builder.Services.AddScoped<IHelpResourceRepository, HelpResourceRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IMaternalRepository, MaternalRepository>();
builder.Services.AddScoped<IOrganismRepository, OrganismRepository>();
builder.Services.AddScoped<IlookupRepository, LookupRepository>();
builder.Services.AddScoped<IDiagnosisTreatmentFormRepository, DiagnosisTreatmentFormRepository>();
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ISuburbRepository, SuburbRepository>();
builder.Services.AddScoped<IHospitalRepository, HospitalRepository>();
builder.Services.AddScoped<IUnitRepository, UnitRepository>();

//configured jwt from user controller
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("veryverysceretkeythatislongenoughforhmacsha256algorithm")),
        ValidateAudience = false,
        ValidateIssuer = false,
        ClockSkew = TimeSpan.Zero
    };
}); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Cors is always added above the authentication pipeline!!!
app.UseCors("MyPolicy");

//Add use authentication
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.UseStaticFiles();
app.Run();
