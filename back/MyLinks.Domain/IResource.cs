using System;

namespace mylinks.domain
{
    public interface IResource
    {
        Guid id { get; set; } 
        public string Title { get; set; }
    }
}