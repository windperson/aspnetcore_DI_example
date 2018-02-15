using System;
using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample.Models {
    public class Operation:
        IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance {

            public Operation () : this (Guid.NewGuid ()) { }

            public Operation (Guid guid) {
                OperationId = guid;
            }

            public Guid OperationId { get; private set; }
        }
}