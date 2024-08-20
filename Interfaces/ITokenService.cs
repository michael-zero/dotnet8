using api.Models;
using api.Dtos.Comment;

namespace api.Interfaces {
  public interface ITokenService {
    string CreateToken(AppUser user);
  }
}