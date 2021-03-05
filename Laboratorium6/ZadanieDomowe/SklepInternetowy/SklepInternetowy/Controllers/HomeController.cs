using Microsoft.AspNetCore.Mvc;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SklepInternetowy.Controllers
{
    public class HomeController : Controller
    {
        // Lista przedmiotów do kupienia
        List<ItemViewModel> allItems;
        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        public HomeController()
        {
            this.allItems = new List<ItemViewModel>();
            allItems.Add(new ItemViewModel(1,"Garnitur 1", "Vistula", "Plaza T Standard to jednorzędowy garnitur w linii Vistula w kolorze ciemnogranatowym w kratę. Został wykonany z wysokiej jakości wełny super 100’s. " +
                "Marynarka jest lekko dopasowana do sylwetki.Zapinana jest na dwa guziki, z tyłu posiada dwa rozcięcia. Ma klapy proste, kieszenie boczne dwuwypustkowe z patkami, na piersi kieszonkę z listewką.Spodnie bez " +
                "zakładek, o dopasowanym kroju, z zaprasowanym kantem, z angielskimi kieszeniami.", 1699, "~/Images/garnitur.png"));
            allItems.Add(new ItemViewModel(2,"Garnitur 2", "Vistula", "Ancona to jednorzędowy garnitur w linii Vistula w kolorze bordowym w błękitną kratę. Został wykonany z wysokiej jakości wełny super 100’s. "+
                "Marynarka jest bardzo dobrze dopasowana do sylwetki.Zapinana jest na dwa guziki, z tyłu posiada dwa rozcięcia. Ma klapy proste, kieszenie boczne z patkami, na piersi kieszonkę z listewką. Spodnie " +
                "bez zakładek, o dopasowanym kroju, z zaprasowanym kantem, z angielskimi kieszeniami.", 1699, "~/Images/garnitur2.png"));
            allItems.Add(new ItemViewModel(3,"Garnitur 3", "Vistula", "Columbia T Standard to jednorzędowy garnitur w linii Vistula w kolorze granatowym z delikatną, niebieską kratą. Został wykonany z wysokiej " +
                " jakości wełny super 100’s.Marynarka jest lekko dopasowana do sylwetki.Zapinana jest na dwa guziki, z tyłu posiada jedno rozcięcie. Ma klapy proste, kieszenie boczne jednowypustkowe z patkami," +
                " na piersi kieszonkę z listewką.Spodnie bez zakładek, o dopasowanym kroju, z zaprasowanym kantem, z angielskimi kieszeniami.", 1699, "~/Images/garnitur3.png"));
            allItems.Add(new ItemViewModel(4,"Garnitur 4", "Vistula", "Ancona Uno to jednorzędowy garnitur w linii Vistula w kolorze granatowym w bordową kratę. Został wykonany z wełny.Marynarka jest bardzo dobrze dopasowana " +
                " do sylwetki.Zapinana jest na dwa guziki, z tyłu posiada dwa rozcięcia. Ma klapy proste, dwie kieszenie boczne z patkami, na piersi kieszonkę z listewką.Spodnie bez zakładek, o dopasowanym kroju, z zaprasowanym " +
                "kantem, z angielskimi kieszeniami.", 1699, "~/Images/garnitur4.png"));
            allItems.Add(new ItemViewModel(5,"Garnitur 5", "Vistula", "Ancona to jednorzędowy garnitur w linii Vistula w kolorze granatowym, gładki. Został wykonany z wełny z niewielkim dodatkiem tkaniny odpornej na zagniecenia. " +
                "Marynarka jest bardzo dobrze dopasowana do sylwetki.Zapinana jest na dwa guziki, z tyłu posiada dwa rozcięcia. Ma klapy proste, kieszenie boczne dwuwypustkowe z patkami, na piersi kieszonkę z listewką.Spodnie bez" +
                " zakładek, o dopasowanym kroju, z zaprasowanym kantem, z angielskimi kieszeniami.", 1299, "~/Images/garnitur5.png"));
            allItems.Add(new ItemViewModel(6,"Garnitur 6", "Vistula", "Ancona to jednorzędowy garnitur w linii Vistula w kolorze szarego melanżu w czarno-czerwono-białą kratę. Został wykonany z wysokiej jakości wełny w połączeniu z " +
                "niewielką ilością poliamidu.Marynarka jest bardzo dobrze dopasowana do sylwetki.Zapinana jest na dwa guziki, z tyłu posiada dwa rozcięcia. Ma szersze klapy proste, kieszenie boczne dwuwypustkowe z patkami, na piersi" +
                " kieszonkę z listewką. Spodnie bez zakładek, o dopasowanym kroju, z zaprasowanym kantem, z angielskimi kieszeniami.", 1799, "~/Images/garnitur6.png"));
        }
        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(this.allItems);
        }
        /// <summary>
        /// Strona z dodatkowymi informacjami o produkcie
        /// </summary>
        /// <param name="selectedItemId"></param>
        /// <returns></returns>
        public IActionResult ItemDescription(int selectedItemId)
        {
            var item = allItems.Where(i => i.Id == selectedItemId).FirstOrDefault();
            TempData["Name"] = item.Name;
            return View(item);
        }
        /// <summary>
        /// Wyświetelnie szczegółów zakupu do wypełnienia
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OrderDetails()
        {
            return View();
        }
        /// <summary>
        /// Wyświetlenie formularza kontaktowego po wypełnieniu szczegółów zakupu
        /// </summary>
        /// <param name="itemData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult OrderDetails(OrderDetailsViewModel itemData)
        {
            ViewBag.Color = itemData.Color;
            ViewBag.Size = itemData.Size;
            return View("Basket");
        }
        /// <summary>
        /// Wyświetlenie Końcowej strony
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Basket(ContactFormViewModel userData)
        {
            string firstName = userData.FirstName;
            string lastName = userData.LastName;
            TempData["Name1"] = firstName + " " + lastName;
            return View("EndSession");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
