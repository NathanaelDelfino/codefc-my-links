using System;
using mylinks.domain;

namespace MyLinks.Domain
{
    public abstract class Resources : IResource
    {
        public Guid Id { get ; set; }
        public string Title { get ; set ; }
    }
}