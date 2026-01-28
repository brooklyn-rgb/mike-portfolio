using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MikePortfolio.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> CoreCompetencies { get; set; } = new List<string>();
        public List<string> BackendTechnologies { get; set; } = new List<string>();
        public List<string> FrontendTechnologies { get; set; } = new List<string>();
        public List<string> CloudTechnologies { get; set; } = new List<string>();

        public void OnGet()
        {
            // Core Competencies
            CoreCompetencies = new List<string>
            {
                "ASP.NET Core & .NET 8/10 Development",
                "Enterprise Web Application Architecture",
                "RESTful API Design & Integration",
                "Cloud-Native Application Development",
                "Clean Architecture & SOLID Principles",
                "Agile / Scrum Delivery",
                "Code Reviews & Developer Mentorship",
                "End-to-End Full-Stack Development",
                "SEO Organic Marketing",
                "Shopify Ecommerce",
                "WordPress CMS",
                "Portal/ Dashboard Development"
            };

            // Backend Technologies
            BackendTechnologies = new List<string>
            {
                ".NET 8",
                "ASP.NET Core",
                "ASP.NET MVC",
                "C#",
                "Web API",
                "RESTful Services",
                "SQL Server",
                "Entity Framework Core",
                "MongoDB"
            };

            // Frontend Technologies
            FrontendTechnologies = new List<string>
            {
                "React",
                "Next.js",
                "React Native",
                "TypeScript",
                "JavaScript",
                "HTML5",
                "CSS3",
                "Flutter"
            };

            // Cloud & DevOps
            CloudTechnologies = new List<string>
            {
                "Microsoft Azure",
                "Azure App Services",
                "CI/CD Pipelines",
                "AWS Fundamentals",
                "Docker",
                "Git",
                "GitHub Actions"
            };
        }
    }
}