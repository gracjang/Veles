namespace Veles.Application.Authentication.Interfaces
{
   using System.Threading.Tasks;

   public interface IAccessTokenStorage
   {
      Task<bool> IsCurrentActiveToken();
      Task DeactivateCurrentAsync();
      Task<bool> IsActiveAsync(string token);
      Task DeactivateAsync(string token);
   }
}