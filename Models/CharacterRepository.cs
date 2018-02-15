using System.Collections.Generic;
using System.Linq;
using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Models {
    public class CharacterRepository : ICharacterRepository {
        private readonly ApplicationDbContext _dbContext;

        public CharacterRepository (ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public void Add (Character character) {
            _dbContext.Characters.Add (character);
            _dbContext.SaveChanges ();
        }

        public IEnumerable<Character> ListAll () {
            return _dbContext.Characters.AsEnumerable ();
        }
    }
}