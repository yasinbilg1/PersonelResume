using Microsoft.AspNetCore.Mvc;
using PersonelResume.Models;
using System.Collections.Generic;

namespace PersonelResume.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var homeModel = new Home
            {
                skills = new string[]
                {
                    "C#", "ASP.NET", "MVC", "SQL Server", "Python",
                    "MySQL", "Kali/Linux", "3D Print", "Arduino",
                    "JavaScript", "Html/Html5"
                }
            };
            var İnfo = new Personelİnfo
            {
                Name = "Yasin Melih",
                Surname = "Bilgi",
                Title = "Jr. Back-end Developer",
                Email = "y.melihbilgi@gmai.com",
                Phone = "+90(541)-740-7020",
                Address = "İstanbul, Türkiye",

            };

            var experiences = new List<Experience>
            {
                new () { Duration = "Haz 2019 - Nis 2021", Company = "Maker Çocuk", Role = "Stajyer", Description = "Yazılım geliştirme, 3D modelleme ve baskı, robotik ve elektronik gibi çeşitli alanlarda deneyim kazandım." },
                new () { Duration = "Haz 2019 - Nis 2021", Company = "Robot El", Role = "Gönüllü", Description = "Robotik bir elin tasarımı ve geliştirilmesine katkıda bulundum." },
                new () { Duration = "Mar 2024 - Nis 2024", Company = "Confidenya", Role = "Stajyer", Description = "Sızma testleri ve Linux üzerine beceriler edindim." },
                new () { Duration = "Tem 2024 - Günümüz", Company = "Gobito", Role = "Stajyer", Description = "Widget ve back-end üzerine beceriler edindim.S" }
             };

            var references = new List<References>
             {
                new () { ReferenceName = "Hayrettin Dağ", ReferenceCompany = "Robot El", ReferencePhone = "+(90) 543 644 3325", ReferenceEmail = "hayrettin@robotel.org" },
                new () { ReferenceName = "Samet Himyeri", ReferenceCompany = "Maker Çocuk", ReferencePhone = "+(90) 553 776 7263", ReferenceEmail = "samethimyeri@gmail.com" }
            };


            var viewModel = new HomeViewModel
            {
                Personelİnfo = İnfo,
                Home = homeModel,
                Experiences = experiences,
                References = references
            };

            return View(viewModel);
        }

    }
}
