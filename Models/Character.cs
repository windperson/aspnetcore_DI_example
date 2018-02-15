using System;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjectionExample.Models {
    public class Character {

        [Key]
        public Guid Id { get; private set; } = Guid.NewGuid ();

        public string Name { get; private set; } = String.Empty;

        public Character (string name) {
            Name = name;
        }

        private Character(){
            //inorder for EF Core to initiate the Character Instance.
        }
    }
}