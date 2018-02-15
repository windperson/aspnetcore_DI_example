using DependencyInjectionExample.Models;
using System.Collections.Generic;

namespace DependencyInjectionExample.Interfaces {
    public interface ICharacterRepository {
        IEnumerable<Character> ListAll ();
        void Add (Character character);
    }
}