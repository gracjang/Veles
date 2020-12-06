using System;
using System.Collections.Generic;
using System.Text;

namespace Veles.Domain.Repository
{
   using System.Threading.Tasks;
   using Veles.Domain.Entities;

   interface IRefreshTokenRepository
   {
      Task AddAsync(RefreshToken token);

      Task<RefreshToken> GetAsync(string token);

      Task UpdateAsync(RefreshToken token);
   }
}
