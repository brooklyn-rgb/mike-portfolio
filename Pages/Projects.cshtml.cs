using Microsoft.AspNetCore.Mvc.RazorPages;
using MikePortfolio.Models;
using System.Collections.Generic;

namespace MikePortfolio.Pages
{
    public class ProjectsModel : PageModel
    {
        public List<Project> Projects { get; set; } = new List<Project>();

        public void OnGet()
        {
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "A2B Transport System",
                    Description = "A comprehensive transportation management system with real-time tracking and scheduling capabilities.",
                    Technologies = ".NET 8, ASP.NET Core, React, SQL Server, Azure",
                    ImageUrl = "/images/projects/a2z.png",
                    LiveUrl = "https://a2b.onrender.com",
                    DateCreated = new DateTime(2024, 1, 15),
                    Category = "Enterprise Web App"
                },
                new Project
                {
                    Id = 2,
                    Title = "Adans College Portal",
                    Description = "Educational institution management portal with student enrollment, course management, and online learning features.",
                    Technologies = "ASP.NET Core MVC, C#, Entity Framework, Bootstrap",
                    ImageUrl = "/images/projects/adans.png",
                    LiveUrl = "https://www.adanscollege.co.za",
                    DateCreated = new DateTime(2023, 10, 1),
                    Category = "Education Platform"
                },
                new Project
                {
                    Id = 3,
                    Title = "Greenlane E-commerce",
                    Description = "Modern e-commerce platform with payment integration, inventory management, and customer relationship features.",
                    Technologies = ".NET 8, React, MongoDB, Azure Functions",
                    ImageUrl = "/images/projects/greenlane.png",
                    LiveUrl = "https://greenlane.co.za",
                    DateCreated = new DateTime(2024, 3, 1),
                    Category = "E-commerce"
                },
                new Project
                {
                    Id = 4,
                    Title = "MacShop Retail System",
                    Description = "Retail management system with POS integration, inventory control, and sales analytics dashboard.",
                    Technologies = "ASP.NET Core, Blazor, SQL Server, Azure App Services",
                    ImageUrl = "/images/projects/macshap.png",
                    LiveUrl = "https://macshap-gffkduhua3fnbnhk.canadacentral-01.azurewebsites.net",
                    DateCreated = new DateTime(2023, 12, 1),
                    Category = "Retail Management"
                },
                new Project
                {
                    Id = 5,
                    Title = "One Africa Radio Station",
                    Description = "Media streaming platform with live broadcasting, on-demand content, and subscription management.",
                    Technologies = ".NET 8, SignalR, React Native, Azure Media Services",
                    ImageUrl = "/images/projects/radiostation.png",
                    LiveUrl = "https://oneafricaradiotv.onrender.com",
                    DateCreated = new DateTime(2024, 2, 1),
                    Category = "Media Streaming"
                },
                new Project
                {
                    Id = 6,
                    Title = "Ecommerce",
                    Description = "Ecommerce Website full stack.",
                    Technologies = "React, Nextjs, MongoDB, Typscrip & JavaScript",
                    ImageUrl = "/images/projects/macshap2.png",
                    LiveUrl = "#",
                    DateCreated = DateTime.Now,
                    Category = "Ecommerce"
                }
            };
        }
    }
}