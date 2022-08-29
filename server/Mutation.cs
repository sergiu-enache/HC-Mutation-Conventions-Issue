using System;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Types;

namespace server
{
    public class Mutation
    {
        [UseMutationConvention]
        public Person? AddPerson(string name, TimeSpan time) => new Person(name);

        public Person? EditPerson(string name, TimeSpan time) => new Person(name);

        [Authorize]
        [UseMutationConvention]
        public Person? AddPersonAuthorized(string name, TimeSpan time) => new Person(name);

        [Authorize]
        public Person? EditPersonAuthorized(string name, TimeSpan time) => new Person(name);
    }
}