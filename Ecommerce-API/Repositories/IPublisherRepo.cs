using Ecommerce_API.Models;
using Ecommerce_API.ViewModels;

namespace Ecommerce_API.Repositories
{
    public interface IPublisherRepo
    {
        public Task<List<Publisher>> GetAllPublisher();
        public Task<Publisher?> GetPublisher(string id);
        public Task<Publisher> AddPublisher(PublisherVM category);
        public Task UpdatePublisher(string id, PublisherVM category);
    }
}
