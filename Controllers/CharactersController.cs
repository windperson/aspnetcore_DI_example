using System;
using System.Linq;
using DependencyInjectionExample.Interfaces;
using DependencyInjectionExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExample.Controllers {
    public class CharactersController : Controller {
        private readonly ICharacterRepository _characterRepository;

        public CharactersController (ICharacterRepository characterRepository) {
            _characterRepository = characterRepository;
        }

        public IActionResult Index () {
            PopulateCharactersIfNoneEXist ();
            var characters = _characterRepository.ListAll ();

            return View (characters);
        }

        private void PopulateCharactersIfNoneEXist () {
            if (!_characterRepository.ListAll ().Any ()) {
                _characterRepository.Add (new Character ("Darth Maul"));
                _characterRepository.Add (new Character ("Darth Vader"));
                _characterRepository.Add (new Character ("Yoda"));
                _characterRepository.Add (new Character ("Mace Windu"));
            }
        }
    }
}