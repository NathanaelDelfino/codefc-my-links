using System;
using System.Collections.Generic;
using MyLinks.Domain;
using MyLinks.Domain.Repository;

namespace MyLinks.API
{
    public class LinkResourceRepository : ILinkResourceRepository
    {
        public void Save(LinkResource domain)
        {
            throw new NotImplementedException();
        }

        public LinkResource GetById(Guid id)
        {
          return new LinkResource{
              Id = Guid.NewGuid(),
              Title = "Site",
              URL = "http://www.codefc.com.br"
          };
        }
        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<LinkResource> GetAll()
        {
            var linkResources = new List<LinkResource>();
         
            linkResources.Add(new LinkResource{
                Id = Guid.NewGuid(),
                Title = "Site",
                URL = "http://www.codefc.com.br"
            });

            linkResources.Add(new LinkResource{
                Id = Guid.NewGuid(),
                Title = "Youtube",
                URL = "http://youtube.com"
            });
            return linkResources;
        }
    }
}