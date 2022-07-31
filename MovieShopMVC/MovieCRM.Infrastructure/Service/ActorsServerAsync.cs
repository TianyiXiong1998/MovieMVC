using MovieCRM.Core.Contracts.Repository;
using MovieCRM.Core.Contracts.Service;
using MovieCRM.Core.Entities;
using MovieCRM.Core.Models;
using MovieCRM.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCRM.Infrastructure.Service
{
    public class ActorsServerAsync : IActorServerAsync
    {
        IActorsRepositoryAsync actorsRepositoryAsync;
        public ActorsServerAsync(IActorsRepositoryAsync _actorsRepositoryAsync)
        {
            actorsRepositoryAsync = _actorsRepositoryAsync;
        }

        public async Task<IEnumerable<ActorsModel>> GetAllActors()
        {
            var result = await actorsRepositoryAsync.GetAllAsync();
            List<ActorsModel> actors = new List<ActorsModel>();
            if(result!=null)
            {
                foreach(var item in result)
                {
                    ActorsModel a = new ActorsModel();
                    a.Id = item.Id;
                    a.Name = item.Name;
                    actors.Add(a);
                }
            }
            
            return actors;

        }

        public async Task<int> InsertActors(ActorsModel actorsModel)
        {
            MovieActors actors = new MovieActors();
            actors.Name = actorsModel.Name;
            var action = await actorsRepositoryAsync.InsertAsync(actors);
            return action;
        }
    }
}
