using System;

namespace mylinks.domain
{
    public interface IResource
    {
        Guid Id { get; set; } 
        public string Title { get; set; }
    }
}