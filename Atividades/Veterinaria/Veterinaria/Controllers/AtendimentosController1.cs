using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class AtendimentosController1 : Controller
    {
        private static List<Animal> animais = new List<Animal>();
        private static List<Veterinario> veterinarios = new List<Veterinario>();
        private static List<Atendimento> atendimentos = new List<Atendimento>();
        public IActionResult Index()
        {
            return View(Atendimentos);
            public IActionResult Novo()
        {
            ViewBag.Animais = animais;
            ViewBag.Veterinarios = veterinarios;
            return View();
        }

        [HttpPost]
        public IActionResult Novo(Atendimento atendimento)
        {
            atendimento.Id = atendimentos.Count + 1;
            atendimento.Data = DateTime.Now;
            atendimentos.Add(atendimento);

            return RedirectToAction("Index");
        }

        // Cadastrar Animal
        public IActionResult CadastrarAnimal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarAnimal(Animal animal)
        {
            animal.Id = animais.Count + 1;
            animais.Add(animal);
            return RedirectToAction("Novo");
        }

        // Cadastrar Veterinário
        public IActionResult CadastrarVeterinario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarVeterinario(Veterinario veterinario)
        {
            veterinario.Id = veterinarios.Count + 1;
            veterinarios.Add(veterinario);
            return RedirectToAction("Novo");
        }
    }
}
